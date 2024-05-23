using MaterialSkin;
using MaterialSkin.Controls;
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

namespace Desktop_44905165
{
    public partial class frmMain : MaterialForm
    {
        DataHandler handler;
        private string currentFilter = "";
        
        public frmMain()
        {
            InitializeComponent();

            //initialize color scheme
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.Green400, Primary.Cyan600, Primary.Cyan500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // create a database handler
            handler = new DataHandler();            
        }

        private void DisplayAppointments(string status = "") // use default param value instead of overloading function
        {
            // get appointment details
            string sql =
                    @"select concat(pa.name, concat(' ', pa.surname)) as Patient, pa.number as Contact, pr.name as [Procedure], ap.booking_time as Booking, ap.status as Status, ap.id as ap_id " +
                    "from appointment ap " +
                    "join patient pa on ap.patient_id = pa.id " +
                    "join [procedure] pr on ap.procedure_id = pr.id " +
                    // filter appointments by status
                    (status != "" ? "where status = @status" : "");

            SqlCommand cmd = new SqlCommand(sql, handler.conn);

            if (status != "")
            {
                // add parameter to query
                cmd.Parameters.AddWithValue("@status", status);
            }

            // populate datagridview
            handler.FillDataGridView(cmd, ref dgvAppointments);

            // no columns exist if no appointments exist
            if (dgvAppointments.Rows.Count != 0)
            {
                //hide appointment id column
                dgvAppointments.Columns["ap_id"].Visible = false;
                cardActions.Enabled = true;
            }
            else
            {
                cardActions.Enabled = false;
            }
        }

        private string GetAppointmentValue(string column)
        {
            // get value from selected row
            return dgvAppointments.SelectedRows[0].Cells[column].Value.ToString();
        }       

        private void tabViewAppointments_Enter(object sender, EventArgs e)
        {
            // set default filter that also fires radio button event and loads datagridview
            rdoNone.Checked = true;
        }

        private bool ValidStatus(string action)
        {
            // checks appointment status for validation
            string status = GetAppointmentValue("Status");

            if (status != "Open")
            {
                MessageBox.Show($"Only open appointments may be {action}", "Check Appointment Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (!ValidStatus("moved")) return;

            int id = int.Parse(GetAppointmentValue("ap_id"));

            // open date and time picker form
            frmSelectDate selectDate = new frmSelectDate();
            selectDate.ShowDialog();

            if (!selectDate.isSelected)
            {
                MessageBox.Show("No date and time selected", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // get new date and time for appointment
            DateTime newDate = selectDate.newDate;

            // update appointment date
            string sql = @"update appointment set booking_time = @newDate where id = @id";
            SqlCommand cmd = new SqlCommand(sql,handler.conn);

            cmd.Parameters.AddWithValue("@newDate", newDate);
            cmd.Parameters.AddWithValue("@id", id);

            handler.ExecuteUpdate(cmd);

            // refresh datagridview with active filter
            DisplayAppointments(currentFilter);
        }

        private void UpdateAppointmentStatus(string status)
        {
            int id = int.Parse(GetAppointmentValue("ap_id"));

            // update appointment status
            string sql = @"update appointment set status = @status where id = @id";
            SqlCommand cmd = new SqlCommand(sql, handler.conn);

            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", id);

            handler.ExecuteUpdate(cmd);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (!ValidStatus("cancelled")) return;

            // open cancellation reason form
            frmCancelAppointment cancel = new frmCancelAppointment();
            cancel.ShowDialog();

            if (!cancel.isSelected)
            {
                MessageBox.Show("No reason selected", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string reason = cancel.reason;

            UpdateAppointmentStatus(reason);

            // refresh datagridview with active filter
            DisplayAppointments(currentFilter);
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (!ValidStatus("completed")) return;

            int ap_id = int.Parse(GetAppointmentValue("ap_id"));

            // open complete appointment form
            frmCompleteAppointment complete = new frmCompleteAppointment();
            // pass application id for invoice creation
            complete.ap_id = ap_id;
            complete.ShowDialog();

            if (!complete.isCompleted)
            {
                MessageBox.Show("Invoice not completed", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateAppointmentStatus("Completed");

            // refresh datagridview with active filter
            DisplayAppointments(currentFilter);
        }

        #region Filter appointments radio buttons

        private void FilterAppointments()
        {
            // filter appointments by status
            if (rdoNone.Checked)
            {
                currentFilter = "";
            }
            else if(rdoOpen.Checked)
            {
                currentFilter = "Open";
            }
            else if(rdoCompleted.Checked)
            {
                currentFilter = "Completed";
            }
            else if(rdoCancelled.Checked)
            {
                currentFilter = "Cancelled";
            }
            else if (rdoNoShow.Checked)
            {
                currentFilter = "No show";
            }
            else
            {
                // early return when a radio button is unchecked but fires CheckedChanged event
                return;
            }

            DisplayAppointments(currentFilter);
        }      

        private void rdoNone_CheckedChanged(object sender, EventArgs e)
        {
            FilterAppointments();
        }

        private void rdoOpen_CheckedChanged(object sender, EventArgs e)
        {
            FilterAppointments();
        }

        private void rdoCompleted_CheckedChanged(object sender, EventArgs e)
        {
            FilterAppointments();
        }

        private void rdoCancelled_CheckedChanged(object sender, EventArgs e)
        {
            FilterAppointments();
        }

        private void rdoNoShow_CheckedChanged(object sender, EventArgs e)
        {
            FilterAppointments();
        }

        #endregion
    }
}
