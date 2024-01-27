using VpAppSolution;

namespace WindowsApplicationForm
{
    public partial class SignUpForm : Form
    {

        public static string fname;
        public static string lname;
        public static string emailaddress;
        public static bool sms;
        public static bool reports;
        public static bool details;

        ConfirmationForm c = new ConfirmationForm();

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnsign_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Signupclick();
            }
        }
        private void btnsign_Click(object sender, EventArgs e)
        {
            Signupclick();
        }

        private void Signupclick()
        {
            fname = txtboxFname.Text;
            lname = txtboxLname.Text;
            emailaddress = txtboxEmail.Text;
            this.Hide();
            c.Show();
        }


        private void chkboxSMS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxSMS.Checked == true)
            {
                sms = true;
                lblSMS.Text = " Service Charges May Apply";
            }
            else
            {
                sms = false;
                lblSMS.Text = "....";
            }
        }



        private void chkboxReports_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkboxReports.Checked == true)
            {
                reports = true;
                lblReports.Text = "Reports will be emailed to your Email Address";
            }
            else
            {
                reports = false;
                lblReports.Text = "....";
            }
        }

        private void chkboxtransdetails_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkboxtransdetails.Checked == true)
            {
                details = true;
                lbldetails.Text = "Service Charges may apply for Transaction Details";
            }
            else
            {
                details = false;
                lbldetails.Text = "....";
            }
        }


    }
}
