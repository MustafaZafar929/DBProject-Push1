namespace DBProject.Admin
{
    partial class UserManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.btnApproveEvent = new System.Windows.Forms.Button();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnTagEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lstEvents
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.Location = new System.Drawing.Point(20, 20);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(360, 180);

            // btnApproveEvent
            this.btnApproveEvent.Location = new System.Drawing.Point(20, 220);
            this.btnApproveEvent.Name = "btnApproveEvent";
            this.btnApproveEvent.Size = new System.Drawing.Size(150, 30);
            this.btnApproveEvent.Text = "Approve Event";

            // cmbCategories
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(20, 270);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(200, 23);

            // btnTagEvent
            this.btnTagEvent.Location = new System.Drawing.Point(240, 270);
            this.btnTagEvent.Name = "btnTagEvent";
            this.btnTagEvent.Size = new System.Drawing.Size(140, 30);
            this.btnTagEvent.Text = "Tag Event Category";

            // EventManagementForm
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.btnApproveEvent);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.btnTagEvent);
            this.Name = "EventManagementForm";
            this.Text = "Event Management";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Button btnApproveEvent;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnTagEvent;
    }
}
