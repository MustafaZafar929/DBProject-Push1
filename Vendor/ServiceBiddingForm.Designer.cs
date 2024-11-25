namespace DBProject.Vendor
{
    partial class ServiceBiddingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtEventType;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Button btnCreateEvent;
        private System.Windows.Forms.Button btnSubmitBid;
        private System.Windows.Forms.TextBox txtBidAmount;
        private System.Windows.Forms.Label lblBidAmount;
        private System.Windows.Forms.ListBox lstBidsForSelectedEvent;
        private System.Windows.Forms.Label lblBidsForEvent;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtEventType = new System.Windows.Forms.TextBox();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.btnCreateEvent = new System.Windows.Forms.Button();
            this.btnSubmitBid = new System.Windows.Forms.Button();
            this.txtBidAmount = new System.Windows.Forms.TextBox();
            this.lblBidAmount = new System.Windows.Forms.Label();
            this.lstBidsForSelectedEvent = new System.Windows.Forms.ListBox();
            this.lblBidsForEvent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(120, 20);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(200, 22);
            this.txtEventName.TabIndex = 0;
            // 
            // txtEventType
            // 
            this.txtEventType.Location = new System.Drawing.Point(120, 60);
            this.txtEventType.Name = "txtEventType";
            this.txtEventType.Size = new System.Drawing.Size(200, 22);
            this.txtEventType.TabIndex = 1;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(120, 100);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(254, 22);
            this.dtpEventDate.TabIndex = 2;
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.ItemHeight = 16;
            this.lstEvents.Location = new System.Drawing.Point(120, 180);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(200, 100);
            this.lstEvents.TabIndex = 3;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(40, 20);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(81, 16);
            this.lblEventName.TabIndex = 4;
            this.lblEventName.Text = "Event Name";
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(40, 60);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(76, 16);
            this.lblEventType.TabIndex = 5;
            this.lblEventType.Text = "Event Type";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(40, 100);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(73, 16);
            this.lblEventDate.TabIndex = 6;
            this.lblEventDate.Text = "Event Date";
            // 
            // btnCreateEvent
            // 
            this.btnCreateEvent.Location = new System.Drawing.Point(120, 140);
            this.btnCreateEvent.Name = "btnCreateEvent";
            this.btnCreateEvent.Size = new System.Drawing.Size(100, 30);
            this.btnCreateEvent.TabIndex = 7;
            this.btnCreateEvent.Text = "Create Event";
            this.btnCreateEvent.UseVisualStyleBackColor = true;
            // 
            // btnSubmitBid
            // 
            this.btnSubmitBid.Location = new System.Drawing.Point(120, 300);
            this.btnSubmitBid.Name = "btnSubmitBid";
            this.btnSubmitBid.Size = new System.Drawing.Size(100, 30);
            this.btnSubmitBid.TabIndex = 9;
            this.btnSubmitBid.Text = "Submit Bid";
            this.btnSubmitBid.UseVisualStyleBackColor = true;
            // 
            // txtBidAmount
            // 
            this.txtBidAmount.Location = new System.Drawing.Point(120, 250);
            this.txtBidAmount.Name = "txtBidAmount";
            this.txtBidAmount.Size = new System.Drawing.Size(200, 22);
            this.txtBidAmount.TabIndex = 8;
            // 
            // lblBidAmount
            // 
            this.lblBidAmount.AutoSize = true;
            this.lblBidAmount.Location = new System.Drawing.Point(40, 250);
            this.lblBidAmount.Name = "lblBidAmount";
            this.lblBidAmount.Size = new System.Drawing.Size(75, 16);
            this.lblBidAmount.TabIndex = 10;
            this.lblBidAmount.Text = "Bid Amount";
            // 
            // lstBidsForSelectedEvent
            // 
            this.lstBidsForSelectedEvent.FormattingEnabled = true;
            this.lstBidsForSelectedEvent.ItemHeight = 16;
            this.lstBidsForSelectedEvent.Location = new System.Drawing.Point(138, 361);
            this.lstBidsForSelectedEvent.Name = "lstBidsForSelectedEvent";
            this.lstBidsForSelectedEvent.Size = new System.Drawing.Size(200, 100);
            this.lstBidsForSelectedEvent.TabIndex = 11;
            this.lstBidsForSelectedEvent.SelectedIndexChanged += new System.EventHandler(this.lstBidsForSelectedEvent_SelectedIndexChanged);
            // 
            // lblBidsForEvent
            // 
            this.lblBidsForEvent.AutoSize = true;
            this.lblBidsForEvent.Location = new System.Drawing.Point(40, 350);
            this.lblBidsForEvent.Name = "lblBidsForEvent";
            this.lblBidsForEvent.Size = new System.Drawing.Size(92, 16);
            this.lblBidsForEvent.TabIndex = 12;
            this.lblBidsForEvent.Text = "Bids for Event:";
            // 
            // ServiceBiddingForm
            // 
            this.ClientSize = new System.Drawing.Size(809, 500);
            this.Controls.Add(this.lblBidsForEvent);
            this.Controls.Add(this.lstBidsForSelectedEvent);
            this.Controls.Add(this.lblBidAmount);
            this.Controls.Add(this.txtBidAmount);
            this.Controls.Add(this.btnSubmitBid);
            this.Controls.Add(this.btnCreateEvent);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.txtEventType);
            this.Controls.Add(this.txtEventName);
            this.Name = "ServiceBiddingForm";
            this.Text = "Service and Sponsorship Bidding";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
