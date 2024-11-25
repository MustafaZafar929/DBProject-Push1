namespace DBProject.Vendor
{
    partial class Registration
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtBusinessType;
        private System.Windows.Forms.Button btnAddService;

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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtBusinessType = new System.Windows.Forms.TextBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.txtService = new System.Windows.Forms.TextBox();
            this.lstServicesOffered = new System.Windows.Forms.ListBox();
            this.lblRegistrations = new System.Windows.Forms.Label();
            this.lstRegistrations = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(120, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(120, 100);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 22);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(120, 160);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 30);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(40, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(40, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(40, 100);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(97, 16);
            this.lblPhoneNumber.TabIndex = 8;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtBusinessType
            // 
            this.txtBusinessType.Location = new System.Drawing.Point(120, 130);
            this.txtBusinessType.Name = "txtBusinessType";
            this.txtBusinessType.Size = new System.Drawing.Size(200, 22);
            this.txtBusinessType.TabIndex = 3;
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(120, 510);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(100, 30);
            this.btnAddService.TabIndex = 11;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(132, 464);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(200, 22);
            this.txtService.TabIndex = 12;
            // 
            // lstServicesOffered
            // 
            this.lstServicesOffered.FormattingEnabled = true;
            this.lstServicesOffered.ItemHeight = 16;
            this.lstServicesOffered.Location = new System.Drawing.Point(132, 358);
            this.lstServicesOffered.Name = "lstServicesOffered";
            this.lstServicesOffered.Size = new System.Drawing.Size(200, 100);
            this.lstServicesOffered.TabIndex = 10;
            // 
            // lblRegistrations
            // 
            this.lblRegistrations.AutoSize = true;
            this.lblRegistrations.Location = new System.Drawing.Point(40, 240);
            this.lblRegistrations.Name = "lblRegistrations";
            this.lblRegistrations.Size = new System.Drawing.Size(86, 16);
            this.lblRegistrations.TabIndex = 9;
            this.lblRegistrations.Text = "Registrations";
            // 
            // lstRegistrations
            // 
            this.lstRegistrations.FormattingEnabled = true;
            this.lstRegistrations.ItemHeight = 16;
            this.lstRegistrations.Location = new System.Drawing.Point(132, 240);
            this.lstRegistrations.Name = "lstRegistrations";
            this.lstRegistrations.Size = new System.Drawing.Size(200, 100);
            this.lstRegistrations.TabIndex = 5;
            // 
            // Registration
            // 
            this.ClientSize = new System.Drawing.Size(860, 600);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.lstServicesOffered);
            this.Controls.Add(this.txtBusinessType);
            this.Controls.Add(this.lblRegistrations);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstRegistrations);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Name = "Registration";
            this.Text = "Vendor/Sponsor Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.ListBox lstServicesOffered;
        private System.Windows.Forms.Label lblRegistrations;
        private System.Windows.Forms.ListBox lstRegistrations;
    }
}
