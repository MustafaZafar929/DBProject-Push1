namespace DBProject.Attendee
{
    partial class TicketsAndCheckInForm
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
            this.listViewTickets = new System.Windows.Forms.ListView();
            this.columnEvent = new System.Windows.Forms.ColumnHeader();
            this.columnType = new System.Windows.Forms.ColumnHeader();
            this.columnStatus = new System.Windows.Forms.ColumnHeader();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(12, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(215, 26);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Tickets and Check-In";

            // 
            // listViewTickets
            // 
            this.listViewTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEvent,
            this.columnType,
            this.columnStatus});
            this.listViewTickets.FullRowSelect = true;
            this.listViewTickets.HideSelection = false;
            this.listViewTickets.Location = new System.Drawing.Point(16, 60);
            this.listViewTickets.Name = "listViewTickets";
            this.listViewTickets.Size = new System.Drawing.Size(550, 200);
            this.listViewTickets.TabIndex = 1;
            this.listViewTickets.UseCompatibleStateImageBehavior = false;
            this.listViewTickets.View = System.Windows.Forms.View.Details;

            // 
            // columnEvent
            // 
            this.columnEvent.Text = "Event Name";
            this.columnEvent.Width = 200;

            // 
            // columnType
            // 
            this.columnType.Text = "Pass Type";
            this.columnType.Width = 150;

            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Check-In Status";
            this.columnStatus.Width = 200;

            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(16, 280);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(100, 30);
            this.buttonDownload.TabIndex = 2;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);

            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Location = new System.Drawing.Point(470, 280);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(100, 30);
            this.buttonCheckIn.TabIndex = 3;
            this.buttonCheckIn.Text = "Check-In";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);

            // 
            // TicketsAndCheckInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 340);
            this.Controls.Add(this.buttonCheckIn);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.listViewTickets);
            this.Controls.Add(this.labelTitle);
            this.Name = "TicketsAndCheckInForm";
            this.Text = "Tickets and Check-In";
            this.Load += new System.EventHandler(this.TicketsAndCheckInForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListView listViewTickets;
        private System.Windows.Forms.ColumnHeader columnEvent;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonCheckIn;
    }
}
