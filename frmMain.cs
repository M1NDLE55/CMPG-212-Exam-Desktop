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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Desktop_44905165
{
    public partial class frmMain : MaterialForm
    {
        DataHandler handler;

        // view appointments tab
        private string currentFilter = "";

        // create appointment tab
        private DateTime selectedDate;
        
        public frmMain()
        {
            InitializeComponent();         
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // create database handlers
            handler = new DataHandler();        
        }

        // ------ VIEW APPOINTMENTS TAB ------

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
            DisplayAppointments();
            currentFilter = "";
            rdoNone.Checked = true;
        }

        private bool ValidStatus(string action)
        {
            // checks appointment status for validation
            string status = GetAppointmentValue("Status");

            if (status != "Open")
            {
                MessageBox.Show($"Only open appointments may be {action}", "Check Appointment Status", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            return true;
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (!ValidStatus("moved")) return;

            int id = int.Parse(GetAppointmentValue("ap_id"));
            DateTime startDate = DateTime.Parse(GetAppointmentValue("Booking"));

            // open date and time picker form
            frmSelectDate selectDate = new frmSelectDate();

            // set initial date on select form
            selectDate.newDate = startDate;

            selectDate.ShowDialog();

            if (!selectDate.isSelected)
            {
                MessageBox.Show("No date and time selected", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (selectDate.newDate.Equals(startDate))
            {
                // don't update record if the new date is the same
                MessageBox.Show("Appointment updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // get new date and time for appointment
            DateTime newDate = selectDate.newDate;

            // update appointment date
            string sql = @"update appointment set booking_time = @newDate where id = @id";
            SqlCommand cmd = new SqlCommand(sql,handler.conn);

            cmd.Parameters.AddWithValue("@newDate", newDate);
            cmd.Parameters.AddWithValue("@id", id);

            if (handler.ExecuteUpdate(cmd))
            {
                MessageBox.Show("Appointment updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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

            if (handler.ExecuteUpdate(cmd))
            {
                MessageBox.Show("Appointment updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }       
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure? This action can't be undone.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(GetAppointmentValue("ap_id"));

                // delete appointment
                string sql = @"delete appointment where id = @id";
                SqlCommand cmd = new SqlCommand(sql, handler.conn);

                cmd.Parameters.AddWithValue("@id", id);

                if(handler.ExecuteDelete(cmd))
                {
                    MessageBox.Show("Appointment removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // refresh datagridview with active filter
                DisplayAppointments(currentFilter);
            }
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

        // ------ CREATE APPOINTMENT TAB ------

        private void tabCreateAppointment_Enter(object sender, EventArgs e)
        {
            // get patient emails since they're unique - names and surnames may have duplicates
            SqlCommand cmdEmails = new SqlCommand(@"select email from patient order by email asc", handler.conn);
            handler.FillComboBox(cmdEmails ,ref cmbEmail, "email");

            // get procedures offered
            SqlCommand cmdProcedures = new SqlCommand(@"select name from [procedure] order by name asc", handler.conn);
            handler.FillComboBox(cmdProcedures, ref cmbProcedure, "name");

            // config calendar control
            calDate.MaxSelectionCount = 1;
            calDate.MinDate = DateTime.Now;
            calDate.MaxDate = DateTime.Now.AddYears(1);

            //load time slots into combobox
            DateTime timeSlots = new DateTime(2000, 1, 1, 8, 0, 0);
            do
            {
                cmbTime.Items.Add(timeSlots.ToShortTimeString());
                timeSlots = timeSlots.AddMinutes(30);
            }
            while (!timeSlots.Equals(new DateTime(2000, 1, 1, 16, 30, 0)));

            // config combobox
            cmbTime.SelectedIndex = 0;

            UpdateDate();
        }

        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDate();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string email = cmbEmail.Text;
            string procedure = cmbProcedure.Text;

            if (selectedDate < DateTime.Now)
            {
                MessageBox.Show("Select an upcoming date and time", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // insert a record into appointment using ids from other tables
            string sql =
                @"insert into appointment (patient_id, procedure_id, booking_time, status) " +
                "values (" +
                "(select id from patient where email = @email)," +
                "(select id from [procedure] where name = @name)," +
                "@booking_time," +
                "'Open') ";

            SqlCommand cmd = new SqlCommand(sql,handler.conn);

            cmd.Parameters.AddWithValue("@email",email);
            cmd.Parameters.AddWithValue("@name",procedure);
            cmd.Parameters.AddWithValue("@booking_time",selectedDate);

            if (handler.ExecuteInsert(cmd))
            {
                MessageBox.Show("Appointment created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            string
                name = txtName.Text,
                surname = txtSurname.Text,
                number = txtNumber.Text,
                email = txtEmail.Text,
                emergency = txtEmergency.Text;

            // input validation
            bool hasError = false;
            errProvider.Clear();

            // name
            if (string.IsNullOrEmpty(name))
            {
                errProvider.SetError(txtName, "Required*");
                hasError = true;
            }

            // surname
            if (string.IsNullOrEmpty(surname))
            {
                errProvider.SetError(txtSurname, "Required*");
                hasError = true;
            }

            // number
            Regex numberRegex = new Regex(@"^\d{10}$");

            if (string.IsNullOrEmpty(number))
            {
                errProvider.SetError(txtNumber, "Required*");
                hasError = true;
            }
            else if (!numberRegex.IsMatch(number))
            {
                errProvider.SetError(txtNumber, "Invalid format*");
                hasError = true;
            }
            
            // emergency number
            if (string.IsNullOrEmpty(emergency))
            {
                errProvider.SetError(txtEmergency, "Required*");
                hasError = true;
            }
            else if (!numberRegex.IsMatch(emergency))
            {
                errProvider.SetError(txtEmergency, "Invalid format*");
                hasError = true;
            }

            // email
            Regex emailRegex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

            if (string.IsNullOrEmpty(email))
            {
                errProvider.SetError(txtEmail, "Required*");
                hasError = true;
            }
            else if (!emailRegex.IsMatch(email))
            {
                errProvider.SetError(txtEmail, "Invalid format*");
                hasError = true;
            }

            if (hasError) return;

            // get allergies - ensure no duplicates
            HashSet<string> allergies = new HashSet<string>();

            for (int i = 0; i < lstAllergies.Items.Count; i++)
            {
                allergies.Add(lstAllergies.Items[i].Text.ToString());
            }
           

            // create new patient
            string sqlPatient =
                @"insert into patient (name, surname, number, email, emergency_contact) " +
                "values (@name, @surname, @number, @email, @emergency_contact)";

            SqlCommand cmdPatient = new SqlCommand(sqlPatient, handler.conn);

            cmdPatient.Parameters.AddWithValue("@name", name);
            cmdPatient.Parameters.AddWithValue("@surname", surname);
            cmdPatient.Parameters.AddWithValue("@number", number);
            cmdPatient.Parameters.AddWithValue("@email", email);
            cmdPatient.Parameters.AddWithValue("@emergency_contact", emergency);

            // only continue if patient was inserted correctly
            if (!handler.ExecuteInsert(cmdPatient))
            {
                MessageBox.Show("Something unexpected happend", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // get new patient's id to reduce query load in loop
            SqlCommand cmdID = new SqlCommand(@"select id from patient where email = @email", handler.conn);
            cmdID.Parameters.AddWithValue("@email", email);

            int patientID = int.Parse(handler.GetRowValues(cmdID)[0]);

            // add allergies
            foreach (string allergy in allergies)
            {
                SqlCommand cmdAllergy = new SqlCommand(@"insert into allergy (patient_id, allergy) values (@patient_id, @allergy)", handler.conn);

                cmdAllergy.Parameters.AddWithValue("@patient_id", patientID);
                cmdAllergy.Parameters.AddWithValue("@allergy", allergy);

                handler.ExecuteInsert(cmdAllergy);
            }

            MessageBox.Show("Patient added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // clear input
            txtName.Clear();
            txtSurname.Clear();
            txtNumber.Clear();
            txtEmail.Clear();
            txtEmergency.Clear();
            lstAllergies.Clear();
        }

        private void btnAddAllergy_Click(object sender, EventArgs e)
        {
            string allergy = txtAllergy.Text;

            // validation
            if (string.IsNullOrEmpty(allergy))
            {
                errProvider.SetError(txtAllergy, "Required*");
                return;
            }

            // add allergy to list box
            lstAllergies.Items.Add(new MaterialListBoxItem(allergy));
            txtAllergy.Clear();
        }

        private void btnRemoveAllergy_Click(object sender, EventArgs e)
        {
            // remove an allergy
            if (lstAllergies.Items.Count > 0 && lstAllergies.SelectedIndex >= 0)
            {
                lstAllergies.Items.RemoveAt(lstAllergies.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select an allergy", "No Allergy Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateDate()
        {
            // update selected date 
            selectedDate = DateTime.Parse($"{calDate.SelectionEnd.ToShortDateString()} {cmbTime.Text}:00");
            lblSelectedDate.Text = selectedDate.ToString();
        }

        private void calDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateDate();
        }
    }
}
