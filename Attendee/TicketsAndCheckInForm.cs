using System;
using System.Windows.Forms;

namespace DBProject.Attendee
{
    public partial class TicketsAndCheckInForm : Form
    {
        public TicketsAndCheckInForm()
        {
            InitializeComponent();
        }

        private void TicketsAndCheckInForm_Load(object sender, EventArgs e)
        {
            // Example data
            var tickets = new ListViewItem[]
            {
                new ListViewItem(new[] { "Music Concert", "E-Ticket", "Pending" }),
                new ListViewItem(new[] { "Tech Conference", "QR Code", "Checked In" }),
                new ListViewItem(new[] { "Sports Event", "E-Ticket", "Not Checked In" }),
            };

            listViewTickets.Items.AddRange(tickets);
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count > 0)
            {
                string eventName = listViewTickets.SelectedItems[0].Text;
                MessageBox.Show($"Downloading e-ticket for: {eventName}", "Download Ticket");
            }
            else
            {
                MessageBox.Show("Please select a ticket to download.", "Error");
            }
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count > 0)
            {
                string eventName = listViewTickets.SelectedItems[0].Text;
                MessageBox.Show($"Checking in to: {eventName} using QR code.", "Check-In");
            }
            else
            {
                MessageBox.Show("Please select a ticket to check-in.", "Error");
            }
        }

        private void listViewTickets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
