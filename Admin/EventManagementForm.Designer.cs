namespace DBProject.Admin
{
    partial class EventManagementForm
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
            this.btnTagCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 16;
            this.lstEvents.Location = new System.Drawing.Point(20, 20);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(360, 180);
            this.lstEvents.TabIndex = 0;
            this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.lstEvents_SelectedIndexChanged);
            // 
            // btnApproveEvent
            // 
            this.btnApproveEvent.Location = new System.Drawing.Point(42, 220);
            this.btnApproveEvent.Name = "btnApproveEvent";
            this.btnApproveEvent.Size = new System.Drawing.Size(150, 30);
            this.btnApproveEvent.TabIndex = 1;
            this.btnApproveEvent.Text = "Approve Event";
            // 
            // cmbCategories
            // 
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(20, 287);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(200, 24);
            this.cmbCategories.TabIndex = 2;
            // 
            // btnTagCategory
            // 
            this.btnTagCategory.Location = new System.Drawing.Point(240, 270);
            this.btnTagCategory.Name = "btnTagCategory";
            this.btnTagCategory.Size = new System.Drawing.Size(140, 30);
            this.btnTagCategory.TabIndex = 3;
            this.btnTagCategory.Text = "Tag Category";
            // 
            // EventManagementForm
            // 
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.btnApproveEvent);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.btnTagCategory);
            this.Name = "EventManagementForm";
            this.Text = "Event Approval & Category Management";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Button btnApproveEvent;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnTagCategory;
    }
}
