namespace VpAppSolution
{
    partial class ConfirmationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblFName = new Label();
            lblLName = new Label();
            lblEmail = new Label();
            labelFname = new Label();
            labelLname = new Label();
            labelEmail = new Label();
            groupBox1 = new GroupBox();
            lblSMS = new Label();
            lblReports = new Label();
            lblDetails = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 27);
            label1.Name = "label1";
            label1.Size = new Size(346, 25);
            label1.TabIndex = 0;
            label1.Text = "Thanks for Signing Up! Contact you Soon!";
            // 
            // lblFName
            // 
            lblFName.AutoSize = true;
            lblFName.Location = new Point(59, 73);
            lblFName.Name = "lblFName";
            lblFName.Size = new Size(138, 25);
            lblFName.TabIndex = 1;
            lblFName.Text = "Your First name:";
            // 
            // lblLName
            // 
            lblLName.AutoSize = true;
            lblLName.Location = new Point(59, 126);
            lblLName.Name = "lblLName";
            lblLName.Size = new Size(139, 25);
            lblLName.TabIndex = 2;
            lblLName.Text = "Your Last Name:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(59, 180);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(168, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Your Email Address:";
            // 
            // labelFname
            // 
            labelFname.AutoSize = true;
            labelFname.Location = new Point(426, 73);
            labelFname.Name = "labelFname";
            labelFname.Size = new Size(24, 25);
            labelFname.TabIndex = 4;
            labelFname.Text = "...";
            // 
            // labelLname
            // 
            labelLname.AutoSize = true;
            labelLname.Location = new Point(426, 126);
            labelLname.Name = "labelLname";
            labelLname.Size = new Size(24, 25);
            labelLname.TabIndex = 5;
            labelLname.Text = "...";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(426, 180);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(24, 25);
            labelEmail.TabIndex = 6;
            labelEmail.Text = "...";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblSMS);
            groupBox1.Controls.Add(lblReports);
            groupBox1.Controls.Add(lblDetails);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Location = new Point(24, 239);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(712, 169);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Services That You Choose - ";
            // 
            // lblSMS
            // 
            lblSMS.AutoSize = true;
            lblSMS.Location = new Point(483, 38);
            lblSMS.Name = "lblSMS";
            lblSMS.Size = new Size(23, 25);
            lblSMS.TabIndex = 7;
            lblSMS.Text = "X";
            // 
            // lblReports
            // 
            lblReports.AutoSize = true;
            lblReports.Location = new Point(483, 84);
            lblReports.Name = "lblReports";
            lblReports.Size = new Size(23, 25);
            lblReports.TabIndex = 6;
            lblReports.Text = "X";
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Location = new Point(483, 131);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(23, 25);
            lblDetails.TabIndex = 5;
            lblDetails.Text = "X";
            lblDetails.Click += label11_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 131);
            label10.Name = "label10";
            label10.Size = new Size(162, 25);
            label10.TabIndex = 3;
            label10.Text = "Transaction Details:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 84);
            label9.Name = "label9";
            label9.Size = new Size(77, 25);
            label9.TabIndex = 2;
            label9.Text = "Reports:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 38);
            label8.Name = "label8";
            label8.Size = new Size(157, 25);
            label8.TabIndex = 1;
            label8.Text = "SMS Notifications:";
            // 
            // ConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(labelEmail);
            Controls.Add(labelLname);
            Controls.Add(labelFname);
            Controls.Add(lblEmail);
            Controls.Add(lblLName);
            Controls.Add(lblFName);
            Controls.Add(label1);
            Name = "ConfirmationForm";
            Text = "ConfirmationForm";
            Load += ConfirmationForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFName;
        private Label lblLName;
        private Label lblEmail;
        private Label labelFname;
        private Label labelLname;
        private Label labelEmail;
        private GroupBox groupBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label lblSMS;
        private Label lblReports;
        private Label lblDetails;
    }
}