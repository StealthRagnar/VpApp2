namespace WindowsApplicationForm
{
    partial class SignUpForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFirstName = new Label();
            txtboxFname = new TextBox();
            txtboxEmail = new TextBox();
            lblEmail = new Label();
            txtboxLname = new TextBox();
            lblLastName = new Label();
            grpServices = new GroupBox();
            lbldetails = new Label();
            lblReports = new Label();
            lblSMS = new Label();
            chkboxtransdetails = new CheckBox();
            chkboxReports = new CheckBox();
            chkboxSMS = new CheckBox();
            btnsign = new Button();
            grpServices.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirstName.Location = new Point(12, 40);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(179, 33);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name: ";
            // 
            // txtboxFname
            // 
            txtboxFname.Location = new Point(193, 40);
            txtboxFname.Name = "txtboxFname";
            txtboxFname.Size = new Size(536, 31);
            txtboxFname.TabIndex = 1;
            // 
            // txtboxEmail
            // 
            txtboxEmail.Location = new Point(193, 148);
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.Size = new Size(536, 31);
            txtboxEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(12, 148);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(102, 33);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // txtboxLname
            // 
            txtboxLname.Location = new Point(193, 92);
            txtboxLname.Name = "txtboxLname";
            txtboxLname.Size = new Size(536, 31);
            txtboxLname.TabIndex = 5;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(12, 92);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(176, 33);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name: ";
            // 
            // grpServices
            // 
            grpServices.Controls.Add(lbldetails);
            grpServices.Controls.Add(lblReports);
            grpServices.Controls.Add(lblSMS);
            grpServices.Controls.Add(chkboxtransdetails);
            grpServices.Controls.Add(chkboxReports);
            grpServices.Controls.Add(chkboxSMS);
            grpServices.Location = new Point(22, 204);
            grpServices.Name = "grpServices";
            grpServices.Size = new Size(906, 183);
            grpServices.TabIndex = 6;
            grpServices.TabStop = false;
            grpServices.Text = "Services";
            // 
            // lbldetails
            // 
            lbldetails.AutoSize = true;
            lbldetails.ForeColor = Color.Red;
            lbldetails.Location = new Point(449, 132);
            lbldetails.Name = "lbldetails";
            lbldetails.Size = new Size(36, 25);
            lbldetails.TabIndex = 5;
            lbldetails.Text = "......";
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.ForeColor = Color.Red;
            lblReports.Location = new Point(449, 86);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(36, 25);
            lblReports.TabIndex = 4;
            lblReports.Text = "......";
            // 
            // lblSMS
            // 
            lblSMS.AutoSize = true;
            lblSMS.ForeColor = Color.Red;
            lblSMS.Location = new Point(449, 40);
            lblSMS.Name = "lblSMS";
            lblSMS.Size = new Size(36, 25);
            lblSMS.TabIndex = 3;
            lblSMS.Text = "......";
            // 
            // chkboxtransdetails
            // 
            chkboxtransdetails.AutoSize = true;
            chkboxtransdetails.Location = new Point(16, 132);
            chkboxtransdetails.Name = "chkboxtransdetails";
            chkboxtransdetails.Size = new Size(184, 29);
            chkboxtransdetails.TabIndex = 2;
            chkboxtransdetails.Text = "Transaction Details";
            chkboxtransdetails.UseVisualStyleBackColor = true;
            chkboxtransdetails.CheckedChanged += chkboxtransdetails_CheckedChanged_1;
            // 
            // chkboxReports
            // 
            chkboxReports.AutoSize = true;
            chkboxReports.Location = new Point(16, 86);
            chkboxReports.Name = "chkboxReports";
            chkboxReports.Size = new Size(99, 29);
            chkboxReports.TabIndex = 1;
            chkboxReports.Text = "Reports";
            chkboxReports.UseVisualStyleBackColor = true;
            chkboxReports.CheckedChanged += chkboxReports_CheckedChanged_1;
            // 
            // chkboxSMS
            // 
            chkboxSMS.AutoSize = true;
            chkboxSMS.Location = new Point(16, 40);
            chkboxSMS.Name = "chkboxSMS";
            chkboxSMS.Size = new Size(171, 29);
            chkboxSMS.TabIndex = 0;
            chkboxSMS.Text = "SMS Notification";
            chkboxSMS.UseVisualStyleBackColor = true;
            chkboxSMS.CheckedChanged += chkboxSMS_CheckedChanged;
            // 
            // btnsign
            // 
            btnsign.Location = new Point(876, 492);
            btnsign.Name = "btnsign";
            btnsign.Size = new Size(112, 34);
            btnsign.TabIndex = 7;
            btnsign.Text = "Sign Up";
            btnsign.UseVisualStyleBackColor = true;
            btnsign.Click += btnsign_Click;
            btnsign.KeyPress += btnsign_KeyPress;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 551);
            Controls.Add(btnsign);
            Controls.Add(grpServices);
            Controls.Add(txtboxLname);
            Controls.Add(lblLastName);
            Controls.Add(txtboxEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtboxFname);
            Controls.Add(lblFirstName);
            Name = "SignUpForm";
            Text = "Sign Up Form ";
            grpServices.ResumeLayout(false);
            grpServices.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private TextBox txtboxFname;
        private TextBox txtboxEmail;
        private Label lblEmail;
        private TextBox txtboxLname;
        private Label lblLastName;
        private GroupBox grpServices;
        private Label lbldetails;
        private Label lblReports;
        private Label lblSMS;
        private CheckBox chkboxtransdetails;
        private CheckBox chkboxReports;
        private CheckBox chkboxSMS;
        private Button btnsign;
    }
}
