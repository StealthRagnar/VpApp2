using WindowsApplicationForm;

namespace VpAppSolution
{
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {
            labelFname.Text = SignUpForm.fname;
            labelLname.Text = SignUpForm.lname;
            labelEmail.Text = SignUpForm.emailaddress;

            if (SignUpForm.sms)
            {
                lblSMS.Text = "J";

            }
            if (SignUpForm.reports)
            {
                lblReports.Text = "J";
            }
            if (SignUpForm.details)
            {
                lblDetails.Text = "J";
            }
        }
    }
}
