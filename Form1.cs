namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelAppointmentForm cancelAppointmentForm = new CancelAppointmentForm();
            cancelAppointmentForm.ShowDialog();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            requestAmbulanceForm = new RequestAmbulanceForm();
            requestAmbulanceForm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string patientName = txtPatientName.Text;
            string location = txtLocation.Text;
            string reason = txtReason.Text;


            MessageBox.Show("Ambulance request submitted:\n" +
                            $"Patient Name: {patientName}\n" +
                            $"Location: {location}\n" +
                            $"Reason: {reason}");


            InvoiceForm invoiceForm = new InvoiceForm();
            invoiceForm.ShowDialog();


            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            this.Close();


            HomePageForm homePageForm = new HomePageForm();
            homePageForm.Show();
        }

        private void rbButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (rbManageProfile.Checked)
            {
                
                LoginDetailsForm loginDetailsForm = new LoginDetailsForm();
                loginDetailsForm.ShowDialog();
            }
        }

        private void rbButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLogout.Checked)
            {
                foreach (Form form in Application.OpenForms)
                {
                    form.Close();
                }

                Application.Exit();
            }
        }
    }
}
