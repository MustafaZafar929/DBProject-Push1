namespace DBProject.Vendor
{
    partial class ContractAndPaymentTrackingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstContracts;
        private System.Windows.Forms.Label lblContracts;
        private System.Windows.Forms.TextBox txtContractDetails;
        private System.Windows.Forms.Label lblContractDetails;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.Button btnUpdateContract;
        private System.Windows.Forms.Button btnDeleteContract;
        private System.Windows.Forms.Label lblPaymentStatus;
        private System.Windows.Forms.ComboBox cmbPaymentStatus;
        private System.Windows.Forms.Button btnTrackPayment;
        private System.Windows.Forms.ListBox lstPayments;
        private System.Windows.Forms.Label lblPayments;
        private System.Windows.Forms.Button btnViewContract;

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
            this.lstContracts = new System.Windows.Forms.ListBox();
            this.lblContracts = new System.Windows.Forms.Label();
            this.txtContractDetails = new System.Windows.Forms.TextBox();
            this.lblContractDetails = new System.Windows.Forms.Label();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.btnUpdateContract = new System.Windows.Forms.Button();
            this.btnDeleteContract = new System.Windows.Forms.Button();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.btnTrackPayment = new System.Windows.Forms.Button();
            this.lstPayments = new System.Windows.Forms.ListBox();
            this.lblPayments = new System.Windows.Forms.Label();
            this.btnViewContract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstContracts
            // 
            this.lstContracts.FormattingEnabled = true;
            this.lstContracts.ItemHeight = 16;
            this.lstContracts.Location = new System.Drawing.Point(120, 50);
            this.lstContracts.Name = "lstContracts";
            this.lstContracts.Size = new System.Drawing.Size(250, 100);
            this.lstContracts.TabIndex = 0;
            // 
            // lblContracts
            // 
            this.lblContracts.AutoSize = true;
            this.lblContracts.Location = new System.Drawing.Point(40, 50);
            this.lblContracts.Name = "lblContracts";
            this.lblContracts.Size = new System.Drawing.Size(66, 16);
            this.lblContracts.TabIndex = 1;
            this.lblContracts.Text = "Contracts:";
            // 
            // txtContractDetails
            // 
            this.txtContractDetails.Location = new System.Drawing.Point(150, 156);
            this.txtContractDetails.Name = "txtContractDetails";
            this.txtContractDetails.Size = new System.Drawing.Size(250, 22);
            this.txtContractDetails.TabIndex = 2;
            // 
            // lblContractDetails
            // 
            this.lblContractDetails.AutoSize = true;
            this.lblContractDetails.Location = new System.Drawing.Point(12, 159);
            this.lblContractDetails.Name = "lblContractDetails";
            this.lblContractDetails.Size = new System.Drawing.Size(104, 16);
            this.lblContractDetails.TabIndex = 3;
            this.lblContractDetails.Text = "Contract Details:";
            // 
            // btnAddContract
            // 
            this.btnAddContract.Location = new System.Drawing.Point(120, 200);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(75, 30);
            this.btnAddContract.TabIndex = 4;
            this.btnAddContract.Text = "Add";
            this.btnAddContract.UseVisualStyleBackColor = true;
            // 
            // btnUpdateContract
            // 
            this.btnUpdateContract.Location = new System.Drawing.Point(205, 200);
            this.btnUpdateContract.Name = "btnUpdateContract";
            this.btnUpdateContract.Size = new System.Drawing.Size(75, 30);
            this.btnUpdateContract.TabIndex = 5;
            this.btnUpdateContract.Text = "Update";
            this.btnUpdateContract.UseVisualStyleBackColor = true;
            // 
            // btnDeleteContract
            // 
            this.btnDeleteContract.Location = new System.Drawing.Point(290, 200);
            this.btnDeleteContract.Name = "btnDeleteContract";
            this.btnDeleteContract.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteContract.TabIndex = 6;
            this.btnDeleteContract.Text = "Delete";
            this.btnDeleteContract.UseVisualStyleBackColor = true;
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(40, 250);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(103, 16);
            this.lblPaymentStatus.TabIndex = 7;
            this.lblPaymentStatus.Text = "Payment Status:";
            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Items.AddRange(new object[] {
            "Paid",
            "Pending",
            "Overdue"});
            this.cmbPaymentStatus.Location = new System.Drawing.Point(160, 250);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(200, 24);
            this.cmbPaymentStatus.TabIndex = 8;
            // 
            // btnTrackPayment
            // 
            this.btnTrackPayment.Location = new System.Drawing.Point(120, 290);
            this.btnTrackPayment.Name = "btnTrackPayment";
            this.btnTrackPayment.Size = new System.Drawing.Size(140, 30);
            this.btnTrackPayment.TabIndex = 9;
            this.btnTrackPayment.Text = "Track Payment";
            this.btnTrackPayment.UseVisualStyleBackColor = true;
            // 
            // lstPayments
            // 
            this.lstPayments.FormattingEnabled = true;
            this.lstPayments.ItemHeight = 16;
            this.lstPayments.Location = new System.Drawing.Point(120, 330);
            this.lstPayments.Name = "lstPayments";
            this.lstPayments.Size = new System.Drawing.Size(250, 100);
            this.lstPayments.TabIndex = 10;
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Location = new System.Drawing.Point(40, 330);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(70, 16);
            this.lblPayments.TabIndex = 11;
            this.lblPayments.Text = "Payments:";
            // 
            // btnViewContract
            // 
            this.btnViewContract.Location = new System.Drawing.Point(120, 440);
            this.btnViewContract.Name = "btnViewContract";
            this.btnViewContract.Size = new System.Drawing.Size(140, 30);
            this.btnViewContract.TabIndex = 12;
            this.btnViewContract.Text = "View Contract";
            this.btnViewContract.UseVisualStyleBackColor = true;
            // 
            // ContractAndPaymentTrackingForm
            // 
            this.ClientSize = new System.Drawing.Size(710, 500);
            this.Controls.Add(this.btnViewContract);
            this.Controls.Add(this.lblPayments);
            this.Controls.Add(this.lstPayments);
            this.Controls.Add(this.btnTrackPayment);
            this.Controls.Add(this.cmbPaymentStatus);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.btnDeleteContract);
            this.Controls.Add(this.btnUpdateContract);
            this.Controls.Add(this.btnAddContract);
            this.Controls.Add(this.lblContractDetails);
            this.Controls.Add(this.txtContractDetails);
            this.Controls.Add(this.lblContracts);
            this.Controls.Add(this.lstContracts);
            this.Name = "ContractAndPaymentTrackingForm";
            this.Text = "Contract and Payment Tracking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
