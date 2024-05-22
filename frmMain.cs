﻿using MaterialSkin;
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

        private void DisplayAppointments() 
        {
            // get appointment details
            string sql =
                    @"select concat(pa.name, concat(' ', pa.surname)) as Patient, pa.number as Contact, pr.name as [Procedure], ap.booking_time as Booking, ap.status as Status, ap.id as ap_id " +
                    "from appointment ap " +
                    "join patient pa on ap.patient_id = pa.id " +
                    "join [procedure] pr on ap.procedure_id = pr.id";

            SqlCommand cmd = new SqlCommand(sql, handler.GetSqlConnection());

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
            DisplayAppointments();
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
            SqlCommand cmd = new SqlCommand(sql,handler.GetSqlConnection());

            cmd.Parameters.AddWithValue("@newDate", newDate);
            cmd.Parameters.AddWithValue("@id", int.Parse(GetAppointmentValue("ap_id")));

            handler.ExecuteUpdate(cmd);

            // refresh datagridview
            DisplayAppointments();
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

            // update appointment status
            string sql = @"update appointment set status = @status where id = @id";
            SqlCommand cmd = new SqlCommand(sql, handler.GetSqlConnection());

            cmd.Parameters.AddWithValue("@status", reason);
            cmd.Parameters.AddWithValue("@id", int.Parse(GetAppointmentValue("ap_id")));

            handler.ExecuteUpdate(cmd);

            // refresh datagridview
            DisplayAppointments();
        }
    }
}
