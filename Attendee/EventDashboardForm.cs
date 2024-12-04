using DBProject.Admin;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBProject.Attendee
{
    public partial class EventDashboardForm : Form
    {
        public EventDashboardForm()
        {
            InitializeComponent();
            LoadRegisteredEvents(); // Load events when form is initialized
        }

        private void LoadRegisteredEvents()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EventManagement;Integrated Security=True";
            int attendeeId = UserSession.UserId; // Assuming UserSession.UserId holds the logged-in user's ID

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT E.Title, E.Date, E.Location, 'Booked' AS Status
            FROM Event E
            INNER JOIN EventRegistration ER ON E.EventID = ER.EventID
            WHERE ER.AttendeeID = @AttendeeID";  // Filter by logged-in user

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AttendeeID", attendeeId);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        listViewRegisteredEvents.Items.Clear();  // Clear existing items

                        if (!reader.HasRows)
                        {
                            MessageBox.Show("You have not booked any events.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        while (reader.Read())
                        {
                            // Create new ListView item for each registered event
                            ListViewItem item = new ListViewItem(reader["Title"].ToString());
                            item.SubItems.Add(Convert.ToDateTime(reader["Date"]).ToString("yyyy-MM-dd HH:mm"));
                            item.SubItems.Add(reader["Location"].ToString());
                            item.SubItems.Add(reader["Status"].ToString());  

                           
                            listViewRegisteredEvents.Items.Add(item);
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading registered events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



    }
}
