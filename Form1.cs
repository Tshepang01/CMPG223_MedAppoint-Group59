using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class FormInvoice : Form
    {
        public FormInvoice()
        {
            InitializeComponent();
            LoadInvoiceData();
        }

        private void LoadInvoiceData()
        {
            
            dataGridViewInvoice.ColumnCount = 4;

            
            dataGridViewInvoice.Columns[0].Name = "Patient Name";
            dataGridViewInvoice.Columns[1].Name = "Appointment Type";
            dataGridViewInvoice.Columns[2].Name = "Doctor";
            dataGridViewInvoice.Columns[3].Name = "Cash";

            
            string[] row1 = new string[] { "Lerato", "Consultation", "Dr. Smith", "R400" };
            string[] row2 = new string[] { "Mosa Mpandlane", "Surgery", "Dr. Johnson", "R1500" };
            string[] row3 = new string[] { "Tshepang", "Therapy", "Dr. Lee", "R300" };
            string[] row4 = new string[] { "Tebogo", "Surgery", "Dr. Mukwevho", "R4500" };
            string[] row5 = new string[] { "Refilwe", "Consultation", "Dr. Banda", "R450" };
            string[] row6 = new string[] { "Inkosiyama2k", "Dentist", "Dr. Radebe", "R6000" };
            string[] row7 = new string[] { "Sihle", "Therapy", "Dr. Naidoo", "R500" };

            
            dataGridViewInvoice.Rows.Add(row1);
            dataGridViewInvoice.Rows.Add(row2);
            dataGridViewInvoice.Rows.Add(row3);
            dataGridViewInvoice.Rows.Add(row4);
            dataGridViewInvoice.Rows.Add(row5);
            dataGridViewInvoice.Rows.Add(row6);
            dataGridViewInvoice.Rows.Add(row7);

            
            dataGridViewInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
