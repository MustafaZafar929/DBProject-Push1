namespace DBProject.Admin
{
    partial class FeedbackModerationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstFeedback = new System.Windows.Forms.ListBox();
            this.btnModerateFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFeedback
            // 
            this.lstFeedback.FormattingEnabled = true;
            this.lstFeedback.ItemHeight = 16;
            this.lstFeedback.Location = new System.Drawing.Point(20, 20);
            this.lstFeedback.Name = "lstFeedback";
            this.lstFeedback.Size = new System.Drawing.Size(360, 180);
            this.lstFeedback.TabIndex = 0;
            // 
            // btnModerateFeedback
            // 
            this.btnModerateFeedback.Location = new System.Drawing.Point(20, 220);
            this.btnModerateFeedback.Name = "btnModerateFeedback";
            this.btnModerateFeedback.Size = new System.Drawing.Size(360, 30);
            this.btnModerateFeedback.TabIndex = 1;
            this.btnModerateFeedback.Text = "Moderate Feedback";
            // 
            // FeedbackModerationForm
            // 
            this.ClientSize = new System.Drawing.Size(426, 327);
            this.Controls.Add(this.lstFeedback);
            this.Controls.Add(this.btnModerateFeedback);
            this.Name = "FeedbackModerationForm";
            this.Text = "Feedback Moderation";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ListBox lstFeedback;
        private System.Windows.Forms.Button btnModerateFeedback;
    }
}
