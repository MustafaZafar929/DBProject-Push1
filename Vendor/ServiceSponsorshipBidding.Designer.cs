using System.Data.SqlClient;
using System.Data;
using System;

namespace DBProject.Vendor
{
    partial class ServiceSponsorshipBidding
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbEvent;
        private System.Windows.Forms.TextBox txtProposal;
        private System.Windows.Forms.Button btnSubmitBid;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblProposal;

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
            this.cmbEvent = new System.Windows.Forms.ComboBox();
            this.txtProposal = new System.Windows.Forms.TextBox();
            this.btnSubmitBid = new System.Windows.Forms.Button();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblProposal = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // cmbEvent
            this.cmbEvent.FormattingEnabled = true;
            this.cmbEvent.Location = new System.Drawing.Point(120, 20);
            this.cmbEvent.Name = "cmbEvent";
            this.cmbEvent.Size = new System.Drawing.Size(200, 24);
            this.cmbEvent.TabIndex = 0;

            // txtProposal
            this.txtProposal.Location = new System.Drawing.Point(120, 60);
            this.txtProposal.Multiline = true;
            this.txtProposal.Name = "txtProposal";
            this.txtProposal.Size = new System.Drawing.Size(200, 100);
            this.txtProposal.TabIndex = 1;

            // btnSubmitBid
            this.btnSubmitBid.Location = new System.Drawing.Point(120, 180);
            this.btnSubmitBid.Name = "btnSubmitBid";
            this.btnSubmitBid.Size = new System.Drawing.Size(100, 30);
            this.btnSubmitBid.TabIndex = 2;
            this.btnSubmitBid.Text = "Submit Bid";
            this.btnSubmitBid.UseVisualStyleBackColor = true;

            // lblEvent
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(40, 20);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(44, 16);
            this.lblEvent.TabIndex = 3;
            this.lblEvent.Text = "Event";

            // lblProposal
            this.lblProposal.AutoSize = true;
            this.lblProposal.Location = new System.Drawing.Point(40, 60);
            this.lblProposal.Name = "lblProposal";
            this.lblProposal.Size = new System.Drawing.Size(69, 16);
            this.lblProposal.TabIndex = 4;
            this.lblProposal.Text = "Proposal";

            // ServiceSponsorshipBidding
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.txtProposal);
            this.Controls.Add(this.cmbEvent);
            this.Controls.Add(this.lblProposal);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.btnSubmitBid);
            this.Name = "ServiceSponsorshipBidding";
            this.Text = "Service and Sponsorship Bidding";
            this.Load += new System.EventHandler(this.ServiceSponsorshipBidding_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void ServiceSponsorshipBidding_Load(object sender, EventArgs e)
        {
            PopulateEventComboBox();
        }

        private void PopulateEventComboBox()
        {
            string connectionString = "your_connection_string_here"; 

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT EventId, EventName FROM Event"; 

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbEvent.DataSource = dt;
                cmbEvent.DisplayMember = "EventName"; 
                cmbEvent.ValueMember = "EventId";
            }
        }
    }
}
