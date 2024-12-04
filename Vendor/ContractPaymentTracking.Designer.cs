namespace DBProject.Vendor
{
    partial class ContractPaymentTracking
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstContracts;
        private System.Windows.Forms.ListBox lstPayments;
        private System.Windows.Forms.Button btnViewContract;
        private System.Windows.Forms.Button btnViewPayment;
        private System.Windows.Forms.Label lblContracts;
        private System.Windows.Forms.Label lblPayments;

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
            this.lstPayments = new System.Windows.Forms.ListBox();
            this.btnViewContract = new System.Windows.Forms.Button();
            this.btnViewPayment = new System.Windows.Forms.Button();
            this.lblContracts = new System.Windows.Forms.Label();
            this.lblPayments = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstContracts
            // 
            this.lstContracts.FormattingEnabled = true;
            this.lstContracts.ItemHeight = 16;
            this.lstContracts.Location = new System.Drawing.Point(120, 20);
            this.lstContracts.Name = "lstContracts";
            this.lstContracts.Size = new System.Drawing.Size(200, 100);
            this.lstContracts.TabIndex = 0;
            // 
            // lstPayments
            // 
            this.lstPayments.FormattingEnabled = true;
            this.lstPayments.ItemHeight = 16;
            this.lstPayments.Location = new System.Drawing.Point(120, 194);
            this.lstPayments.Name = "lstPayments";
            this.lstPayments.Size = new System.Drawing.Size(200, 100);
            this.lstPayments.TabIndex = 1;
            // 
            // btnViewContract
            // 
            this.btnViewContract.Location = new System.Drawing.Point(120, 120);
            this.btnViewContract.Name = "btnViewContract";
            this.btnViewContract.Size = new System.Drawing.Size(100, 30);
            this.btnViewContract.TabIndex = 2;
            this.btnViewContract.Text = "View Contract";
            this.btnViewContract.UseVisualStyleBackColor = true;
            // 
            // btnViewPayment
            // 
            this.btnViewPayment.Location = new System.Drawing.Point(120, 300);
            this.btnViewPayment.Name = "btnViewPayment";
            this.btnViewPayment.Size = new System.Drawing.Size(100, 30);
            this.btnViewPayment.TabIndex = 3;
            this.btnViewPayment.Text = "View Payment";
            this.btnViewPayment.UseVisualStyleBackColor = true;
            // 
            // lblContracts
            // 
            this.lblContracts.AutoSize = true;
            this.lblContracts.Location = new System.Drawing.Point(40, 20);
            this.lblContracts.Name = "lblContracts";
            this.lblContracts.Size = new System.Drawing.Size(63, 16);
            this.lblContracts.TabIndex = 4;
            this.lblContracts.Text = "Contracts";
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.Location = new System.Drawing.Point(40, 140);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(67, 16);
            this.lblPayments.TabIndex = 5;
            this.lblPayments.Text = "Payments";
            // 
            // ContractPaymentTracking
            // 
            this.ClientSize = new System.Drawing.Size(400, 422);
            this.Controls.Add(this.lstPayments);
            this.Controls.Add(this.lstContracts);
            this.Controls.Add(this.lblPayments);
            this.Controls.Add(this.lblContracts);
            this.Controls.Add(this.btnViewPayment);
            this.Controls.Add(this.btnViewContract);
            this.Name = "ContractPaymentTracking";
            this.Text = "Contract and Payment Tracking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
