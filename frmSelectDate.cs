using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_44905165
{
    public partial class frmSelectDate : MaterialForm
    {
        public DateTime newDate { get; set; }
        public bool isSelected = false;

        public frmSelectDate()
        {
            InitializeComponent();
        }

        private void frmSelectDate_Load(object sender, EventArgs e)
        {
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

            // set to current booking date and time - can't use newDate directly because setting cmbTime/calDate fires event that updates newDate
            DateTime start = newDate;
            cmbTime.Text = start.ToShortTimeString();
            calDate.SelectionRange = new SelectionRange(start, start);
        }

        private void UpdateDate()
        {
            // update date 
            newDate = DateTime.Parse($"{calDate.SelectionEnd.ToShortDateString()} {cmbTime.Text}");
            lblNewDateTime.Text = newDate.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (newDate < DateTime.Now)
            {
                MessageBox.Show("Select an upcoming date and time", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isSelected = true;
            Close();
        }

        private void calDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateDate();
        }

        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDate();
        }
    }
}
