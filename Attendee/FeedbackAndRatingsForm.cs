using DBProject.Admin;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBProject.Attendee
{
    public partial class FeedbackAndRatingsForm : Form
    {
        public FeedbackAndRatingsForm()
        {
            InitializeComponent();
            LoadRegisteredEvents(); // Load events when form is initialized
        }

        private void LoadRegisteredEvents()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EventManagement;Integrated Security=True";
            int attendeeId = UserSession.UserId;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT E.Title, E.Date
                    FROM Event E
                    INNER JOIN EventRegistration ER ON E.EventID = ER.EventID
                    WHERE ER.AttendeeID = @AttendeeID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AttendeeID", attendeeId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    listViewEvents.Items.Clear();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("No registered events found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Title"].ToString());
                        item.SubItems.Add(Convert.ToDateTime(reader["Date"]).ToString("yyyy-MM-dd HH:mm"));
                        listViewEvents.Items.Add(item);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSubmitFeedback_Click(object sender, EventArgs e)
        {
            if (listViewEvents.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an event to provide feedback.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string feedback = textBoxFeedback.Text.Trim();
            string rating = comboBoxRating.SelectedItem?.ToString().Split('-')[0].Trim();

            if (string.IsNullOrEmpty(feedback) || string.IsNullOrEmpty(rating))
            {
                MessageBox.Show("Please provide feedback and a rating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EventManagement;Integrated Security=True";
            int attendeeId = UserSession.UserId;
            string selectedEvent = listViewEvents.SelectedItems[0].Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO Feedback (AttendeeID, EventID, Comments, Rating)
                    SELECT @AttendeeID, EventID, @Comments, @Rating
                    FROM Event
                    WHERE Title = @EventTitle";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AttendeeID", attendeeId);
                command.Parameters.AddWithValue("@Comments", feedback);
                command.Parameters.AddWithValue("@Rating", rating);
                command.Parameters.AddWithValue("@EventTitle", selectedEvent);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Feedback submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxFeedback.Clear();
                    comboBoxRating.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error submitting feedback: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
