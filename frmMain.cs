using MaterialSkin;
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
            handler = new DataHandler();
        }
    }
}
