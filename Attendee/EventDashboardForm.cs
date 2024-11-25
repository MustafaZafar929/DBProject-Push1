using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBProject.Attendee
{
    public partial class EventDashboardForm : Form
    {
        public EventDashboardForm()
        {
            InitializeComponent();
            this.Load += EventDashboardForm_Load;
        }

        


        private void EventDashboardForm_Load(object sender, EventArgs e)
        {
            // Example data
            var items = new ListViewItem[]
            {
                new ListViewItem(new[] { "Music Concert", "12/05/2024", "New York", "Upcoming" }),
                new ListViewItem(new[] { "Tech Conference", "01/15/2025", "San Francisco", "Upcoming" }),
                new ListViewItem(new[] { "Sports Event", "11/20/2024", "Chicago", "Completed" }),
            };

            listViewRegisteredEvents.Items.AddRange(items);
        }

    }
}
