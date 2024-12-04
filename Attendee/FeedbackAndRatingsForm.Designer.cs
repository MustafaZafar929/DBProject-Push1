namespace DBProject.Attendee
{
    partial class FeedbackAndRatingsForm
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
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.columnEventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSubmitFeedback = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxFeedback = new System.Windows.Forms.TextBox();
            this.labelFeedback = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.comboBoxRating = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(14, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(306, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Feedback and Ratings";
            // 
            // listViewEvents
            // 
            this.listViewEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEventName,
            this.columnDate});
            this.listViewEvents.FullRowSelect = true;
            this.listViewEvents.HideSelection = false;
            this.listViewEvents.Location = new System.Drawing.Point(18, 64);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(628, 160);
            this.listViewEvents.TabIndex = 1;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            this.listViewEvents.View = System.Windows.Forms.View.Details;
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
            // buttonSubmitFeedback
            // 
            this.buttonSubmitFeedback.Location = new System.Drawing.Point(18, 427);
            this.buttonSubmitFeedback.Name = "buttonSubmitFeedback";
            this.buttonSubmitFeedback.Size = new System.Drawing.Size(171, 32);
            this.buttonSubmitFeedback.TabIndex = 4;
            this.buttonSubmitFeedback.Text = "Submit Feedback";
            this.buttonSubmitFeedback.UseVisualStyleBackColor = true;
            this.buttonSubmitFeedback.Click += new System.EventHandler(this.buttonSubmitFeedback_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(537, 427);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(114, 32);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxFeedback
            // 
            this.textBoxFeedback.Location = new System.Drawing.Point(18, 267);
            this.textBoxFeedback.Multiline = true;
            this.textBoxFeedback.Name = "textBoxFeedback";
            this.textBoxFeedback.Size = new System.Drawing.Size(628, 85);
            this.textBoxFeedback.TabIndex = 2;
       //     this.textBoxFeedback.TextChanged += new System.EventHandler(this.textBoxFeedback_TextChanged);
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Location = new System.Drawing.Point(18, 245);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(153, 16);
            this.labelFeedback.TabIndex = 6;
            this.labelFeedback.Text = "Provide Your Feedback:";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(18, 373);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(49, 16);
            this.labelRating.TabIndex = 7;
            this.labelRating.Text = "Rating:";
            // 
            // comboBoxRating
            // 
            this.comboBoxRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRating.FormattingEnabled = true;
            this.comboBoxRating.Items.AddRange(new object[] {
            "1 - Poor",
            "2 - Fair",
            "3 - Good",
            "4 - Very Good",
            "5 - Excellent"});
            this.comboBoxRating.Location = new System.Drawing.Point(91, 370);
            this.comboBoxRating.Name = "comboBoxRating";
            this.comboBoxRating.Size = new System.Drawing.Size(138, 24);
            this.comboBoxRating.TabIndex = 3;
            // 
            // FeedbackAndRatingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 480);
            this.Controls.Add(this.comboBoxRating);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.textBoxFeedback);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSubmitFeedback);
            this.Controls.Add(this.listViewEvents);
            this.Controls.Add(this.labelTitle);
            this.Name = "FeedbackAndRatingsForm";
            this.Text = "Feedback and Ratings";
    //        this.Load += new System.EventHandler(this.FeedbackAndRatingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.ColumnHeader columnEventName;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.Button buttonSubmitFeedback;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxFeedback;
        private System.Windows.Forms.Label labelFeedback;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.ComboBox comboBoxRating;
    }
}
