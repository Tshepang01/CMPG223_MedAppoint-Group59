using System.Diagnostics;

namespace MyPage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                btnBook = " ",
                UseShellExecute = true
            });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string appointmentId = AppointmentIdTextBox.Text;


            string connectionString = "your_connection_string_here";
            string query = "DELETE FROM Appointments WHERE AppointmentID = @AppointmentID";

            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AppointmentID", appointmentId);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        ResultLabel.Text = "Appointment canceled successfully.";
                    }
                    else
                    {
                        ResultLabel.Text = "No appointment found with the provided ID.";
                    }
                }
                catch (Exception ex)
                {
                    ResultLabel.Text = "Error: " + ex.Message;
                }
            }
        }
    }
}
