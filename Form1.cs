using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadInvoiceData();
        }

        private void LoadInvoiceData()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\Invoice\Invoice\DatabaseInvoice.mdf;Integrated Security=True";
            string query = "SELECT PatientName, AppointmentType, DoctorName, AppointmentDate, Cash FROM Invoice";

            using (SqlConnection conn = new SqlConnection(connectionString))
                try
                {
                    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    invoiceDataGridView.DataSource = dt;



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
        }

        private void invoiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetInvoice);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetInvoice.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter.Fill(this.dataSetInvoice.Invoice);

        }

        private void invoiceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
