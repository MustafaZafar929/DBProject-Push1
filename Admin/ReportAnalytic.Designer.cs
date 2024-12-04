namespace DBProject.Admin
{
    partial class ReportAnalytic
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnEventReport = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnEngagementReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEventReport
            // 
            this.btnEventReport.Location = new System.Drawing.Point(20, 20);
            this.btnEventReport.Name = "btnEventReport";
            this.btnEventReport.Size = new System.Drawing.Size(350, 30);
            this.btnEventReport.TabIndex = 0;
            this.btnEventReport.Text = "Generate Event Activity Report";
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(20, 70);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(350, 30);
            this.btnSalesReport.TabIndex = 1;
            this.btnSalesReport.Text = "Generate Ticket Sales Report";
            // 
            // btnEngagementReport
            // 
            this.btnEngagementReport.Location = new System.Drawing.Point(20, 120);
            this.btnEngagementReport.Name = "btnEngagementReport";
            this.btnEngagementReport.Size = new System.Drawing.Size(350, 30);
            this.btnEngagementReport.TabIndex = 2;
            this.btnEngagementReport.Text = "Generate User Engagement Report";
            // 
            // ReportAnalytic
            // 
            this.ClientSize = new System.Drawing.Size(400, 189);
            this.Controls.Add(this.btnEventReport);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnEngagementReport);
            this.Name = "ReportAnalytic";
            this.Text = "Reports and Platform Analytics";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnEventReport;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnEngagementReport;
    }
}
