namespace DBProject.Attendee
{
    partial class ProfileManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxPersonalInfo = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonUpdateInfo = new System.Windows.Forms.Button();
            this.checkBoxReceiveEmails = new System.Windows.Forms.CheckBox();
            this.checkBoxReceiveNotifications = new System.Windows.Forms.CheckBox();
            this.buttonSavePreferences = new System.Windows.Forms.Button();
            this.listViewPastEvents = new System.Windows.Forms.ListView();
            this.columnEventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPastEvents = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxPersonalInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(14, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(275, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Profile Management";
            // 
            // groupBoxPersonalInfo
            // 
            this.groupBoxPersonalInfo.Controls.Add(this.textBoxEmail);
            this.groupBoxPersonalInfo.Controls.Add(this.textBoxName);
            this.groupBoxPersonalInfo.Controls.Add(this.labelEmail);
            this.groupBoxPersonalInfo.Controls.Add(this.labelName);
            this.groupBoxPersonalInfo.Controls.Add(this.buttonUpdateInfo);
            this.groupBoxPersonalInfo.Location = new System.Drawing.Point(18, 64);
            this.groupBoxPersonalInfo.Name = "groupBoxPersonalInfo";
            this.groupBoxPersonalInfo.Size = new System.Drawing.Size(629, 128);
            this.groupBoxPersonalInfo.TabIndex = 1;
            this.groupBoxPersonalInfo.TabStop = false;
            this.groupBoxPersonalInfo.Text = "Personal Information";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(91, 64);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(342, 22);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(91, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(342, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(23, 64);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 16);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(23, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // buttonUpdateInfo
            // 
            this.buttonUpdateInfo.Location = new System.Drawing.Point(457, 43);
            this.buttonUpdateInfo.Name = "buttonUpdateInfo";
            this.buttonUpdateInfo.Size = new System.Drawing.Size(149, 32);
            this.buttonUpdateInfo.TabIndex = 3;
            this.buttonUpdateInfo.Text = "Update Info";
            this.buttonUpdateInfo.UseVisualStyleBackColor = true;
            this.buttonUpdateInfo.Click += new System.EventHandler(this.buttonUpdateInfo_Click);
            // 
            // checkBoxReceiveEmails
            // 
            this.checkBoxReceiveEmails.Location = new System.Drawing.Point(0, 0);
            this.checkBoxReceiveEmails.Name = "checkBoxReceiveEmails";
            this.checkBoxReceiveEmails.Size = new System.Drawing.Size(104, 24);
            this.checkBoxReceiveEmails.TabIndex = 0;
            // 
            // checkBoxReceiveNotifications
            // 
            this.checkBoxReceiveNotifications.Location = new System.Drawing.Point(0, 0);
            this.checkBoxReceiveNotifications.Name = "checkBoxReceiveNotifications";
            this.checkBoxReceiveNotifications.Size = new System.Drawing.Size(104, 24);
            this.checkBoxReceiveNotifications.TabIndex = 0;
            // 
            // buttonSavePreferences
            // 
            this.buttonSavePreferences.Location = new System.Drawing.Point(0, 0);
            this.buttonSavePreferences.Name = "buttonSavePreferences";
            this.buttonSavePreferences.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePreferences.TabIndex = 0;
            // 
            // listViewPastEvents
            // 
            this.listViewPastEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEventName,
            this.columnDate});
            this.listViewPastEvents.FullRowSelect = true;
            this.listViewPastEvents.HideSelection = false;
            this.listViewPastEvents.Location = new System.Drawing.Point(18, 352);
            this.listViewPastEvents.Name = "listViewPastEvents";
            this.listViewPastEvents.Size = new System.Drawing.Size(628, 160);
            this.listViewPastEvents.TabIndex = 7;
            this.listViewPastEvents.UseCompatibleStateImageBehavior = false;
            this.listViewPastEvents.View = System.Windows.Forms.View.Details;
            // 
            // columnEventName
            // 
            this.columnEventName.Text = "Event Name";
            this.columnEventName.Width = 300;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            this.columnDate.Width = 200;
            // 
            // labelPastEvents
            // 
            this.labelPastEvents.AutoSize = true;
            this.labelPastEvents.Location = new System.Drawing.Point(18, 331);
            this.labelPastEvents.Name = "labelPastEvents";
            this.labelPastEvents.Size = new System.Drawing.Size(81, 16);
            this.labelPastEvents.TabIndex = 8;
            this.labelPastEvents.Text = "Past Events:";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(537, 533);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(114, 32);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ProfileManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 587);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelPastEvents);
            this.Controls.Add(this.listViewPastEvents);
            this.Controls.Add(this.groupBoxPersonalInfo);
            this.Controls.Add(this.labelTitle);
            this.Name = "ProfileManagementForm";
            this.Text = "Profile Management";
            this.Load += new System.EventHandler(this.ProfileManagementForm_Load);
            this.groupBoxPersonalInfo.ResumeLayout(false);
            this.groupBoxPersonalInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupBoxPersonalInfo;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonUpdateInfo;
        private System.Windows.Forms.CheckBox checkBoxReceiveEmails;
        private System.Windows.Forms.CheckBox checkBoxReceiveNotifications;
        private System.Windows.Forms.Button buttonSavePreferences;
        private System.Windows.Forms.ListView listViewPastEvents;
        private System.Windows.Forms.ColumnHeader columnEventName;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.Label labelPastEvents;
        private System.Windows.Forms.Button buttonClose;
    }
}
