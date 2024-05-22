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
    public partial class frmCancelAppointment : MaterialForm
    {
        public bool isSelected = false;
        public string reason = "";

        public frmCancelAppointment()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            isSelected = true;
            
            // set reason for cancellation
            if (rdoCancelled.Checked)
            {
                reason = "Cancelled";
            }
            else if(rdoNoShow.Checked)
            {
                reason = "No show";
            }
            
            Close();
        }
    }
}
