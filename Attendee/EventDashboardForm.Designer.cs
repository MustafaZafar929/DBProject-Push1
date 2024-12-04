using System;
using System.Windows.Forms;

namespace DBProject.Attendee
{
    public partial class EventDashboardForm : Form
    {
      

        private void InitializeComponent()
        {
            this.labelDashboardTitle = new System.Windows.Forms.Label();
            this.listViewRegisteredEvents = new System.Windows.Forms.ListView();
            this.columnEventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDashboardTitle
            // 
            this.labelDashboardTitle.AutoSize = true;
            this.labelDashboardTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelDashboardTitle.Location = new System.Drawing.Point(12, 20);
            this.labelDashboardTitle.Name = "labelDashboardTitle";
            this.labelDashboardTitle.Size = new System.Drawing.Size(240, 32);
            this.labelDashboardTitle.TabIndex = 0;
            this.labelDashboardTitle.Text = "Event Dashboard";
            // 
            // listViewRegisteredEvents
            // 
            this.listViewRegisteredEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEventName,
            this.columnDate,
            this.columnLocation,
            this.columnStatus});
            this.listViewRegisteredEvents.FullRowSelect = true;
            this.listViewRegisteredEvents.HideSelection = false;
            this.listViewRegisteredEvents.Location = new System.Drawing.Point(18, 74);
            this.listViewRegisteredEvents.Name = "listViewRegisteredEvents";
            this.listViewRegisteredEvents.Size = new System.Drawing.Size(550, 200);
            this.listViewRegisteredEvents.TabIndex = 1;
            this.listViewRegisteredEvents.UseCompatibleStateImageBehavior = false;
            this.listViewRegisteredEvents.View = System.Windows.Forms.View.Details;
            // 
            // columnEventName
            // 
            this.columnEventName.Text = "Event Name";
            this.columnEventName.Width = 200;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 100;
            // 
            // columnLocation
            // 
            this.columnLocation.Text = "Location";
            this.columnLocation.Width = 150;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            this.columnStatus.Width = 100;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(470, 280);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 30);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // EventDashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(600, 340);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.listViewRegisteredEvents);
            this.Controls.Add(this.labelDashboardTitle);
            this.Name = "EventDashboardForm";
            this.Text = "Event Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private System.Windows.Forms.Label labelDashboardTitle;
        private System.Windows.Forms.ListView listViewRegisteredEvents;
        private System.Windows.Forms.ColumnHeader columnEventName;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnLocation;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.Button buttonClose;
    }
}
