using DBProject.Admin;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBProject.Attendee
{
    public partial class EventSearchForm : Form
    {
        public EventSearchForm()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EventManagement;Integrated Security=True";

            string searchText = textBoxSearch.Text.Trim();
            string category = comboBoxCategory.SelectedItem.ToString();
            string location = comboBoxLocation.SelectedItem.ToString();
            DateTime fromDate = dateTimePickerFrom.Value.Date;
            DateTime toDate = dateTimePickerTo.Value.Date.AddDays(1).AddMilliseconds(-1);

            string query = @"
                SELECT E.Title, E.Date, E.Location, C.Name AS Category
                FROM Event E
                INNER JOIN EventCategory C ON E.CategoryID = C.CategoryID
                WHERE (@searchText = '' OR E.Title LIKE '%' + @searchText + '%')
                AND (@category = 'All Categories' OR C.Name = @category)
                AND (@location = 'All Locations' OR E.Location = @location)
                AND E.Date BETWEEN @fromDate AND @toDate";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@searchText", searchText);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@location", location);
                command.Parameters.AddWithValue("@fromDate", fromDate);
                command.Parameters.AddWithValue("@toDate", toDate);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    listViewEvents.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Title"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["Date"]).ToString("yyyy-MM-dd HH:mm"));
                        item.SubItems.Add(reader["Location"].ToString());
                        item.SubItems.Add(reader["Category"].ToString());
                        listViewEvents.Items.Add(item);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            if (listViewEvents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an event to book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected event details
            ListViewItem selectedItem = listViewEvents.SelectedItems[0];
            string title = selectedItem.Text;
            DateTime date = DateTime.Parse(selectedItem.SubItems[1].Text);
            string location = selectedItem.SubItems[2].Text;

            // Retrieve EventID using the GetEventIdByTitle function
            int eventId = GetEventIdByTitle(title, date, location);
            if (eventId == 0)
            {
                MessageBox.Show("Error retrieving event information. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int attendeeId = UserSession.UserId; // User's ID from session

            using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EventManagement;Integrated Security=True"))
            {
                string query = @"
            INSERT INTO EventRegistration (EventID, AttendeeID)
            VALUES (@EventID, @AttendeeID)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EventID", eventId);
                    command.Parameters.AddWithValue("@AttendeeID", attendeeId);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Event booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error booking event: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private int GetEventIdByTitle(string title, DateTime date, string location)
        {
            int eventID = 0;
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EventManagement;Integrated Security=True";
            string query = @"
                SELECT EventID 
                FROM Event 
                WHERE Title = @title AND Date = @date AND Location = @location";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@date", date);
                command.Parameters.AddWithValue("@location", location);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        eventID = Convert.ToInt32(result);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving event ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return eventID;
        }

        private void EventSearchForm_Load(object sender, EventArgs e)
        {
        }
    }
}
