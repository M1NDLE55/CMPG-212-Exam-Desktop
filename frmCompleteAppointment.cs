using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_44905165
{
    public partial class frmCompleteAppointment : MaterialForm
    {
        public int ap_id {get;set;}
        public bool isCompleted = false;
        private DataHandler handler;
        private string invoice;

        public frmCompleteAppointment()
        {
            InitializeComponent();
        }

        private void frmCompleteAppointment_Load(object sender, EventArgs e)
        {
            handler = new DataHandler();

            // get data needed for invoice
            string sql =
                @"select concat(pa.name, concat(' ', pa.surname)) as patient, pa.number, pa.email, pr.name as [procedure], pr.fee, ap.booking_time " +
                "from appointment ap " +
                "join patient pa on ap.patient_id = pa.id " +
                "join [procedure] pr on ap.procedure_id = pr.id " +
                "where ap.id = @ap_id";

            SqlCommand cmd = new SqlCommand(sql, handler.conn);
            cmd.Parameters.AddWithValue("@ap_id", ap_id);

            // array with values from query | [patient,number,email,procedure,fee,booking_time]
            string[] data = handler.GetRowValues(cmd);

            // query ran without error but didn't return a row
            if (data == null )
            {
                MessageBox.Show("Something unexpected happend", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // create invoice
            invoice = 
                $"------------------------------------------------------\n" +
                $"Patient\n" +
                $"------------------------------------------------------\n" +
                $"Full Name: {data[0]}\n" +
                $"Number: {data[1]}\n" +
                $"Email: {data[2]}\n" +
                $"------------------------------------------------------\n" +
                $"Procedure\n" +
                $"------------------------------------------------------\n" +
                $"Name: {data[3]}\n" +
                $"Date: {DateTime.Parse(data[5]).ToLongDateString()}\n" +
                $"Time: {DateTime.Parse(data[5]).ToLongTimeString()}\n" +
                $"------------------------------------------------------\n" +
                $"Total Cost: {decimal.Parse(data[4]):C}";

            rtbInvoice.Text = invoice;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // write to text file
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = saveFileDialog.FileName;

                StreamWriter outputFile = new StreamWriter(file);

                outputFile.Write(invoice);

                outputFile.Close();

                // confirmation
                MessageBox.Show("Invoice successfully saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invoice not saved", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            isCompleted = true;
            Close();
        }
    }
}
