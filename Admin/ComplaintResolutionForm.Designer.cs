namespace DBProject.Admin
{
    partial class ComplaintResolutionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstComplaints = new System.Windows.Forms.ListBox();
            this.btnResolveComplaint = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lstComplaints
            this.lstComplaints.FormattingEnabled = true;
            this.lstComplaints.Location = new System.Drawing.Point(20, 20);
            this.lstComplaints.Size = new System.Drawing.Size(360, 180);

            // btnResolveComplaint
            this.btnResolveComplaint.Location = new System.Drawing.Point(20, 220);
            this.btnResolveComplaint.Size = new System.Drawing.Size(360, 30);
            this.btnResolveComplaint.Text = "Resolve Complaint";

            // ComplaintResolutionForm
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lstComplaints);
            this.Controls.Add(this.btnResolveComplaint);
            this.Text = "Complaint Resolution";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox lstComplaints;
        private System.Windows.Forms.Button btnResolveComplaint;
    }
}
