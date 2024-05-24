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
    public partial class frmLogin : MaterialForm
    {
        private DataHandler handler;

        public frmLogin()
        {
            InitializeComponent();

            //initialize color scheme
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue700, Primary.Blue200, Accent.Green700, TextShade.WHITE);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // create a database handler
            handler = new DataHandler();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // input validation
            bool hasError = false;
            errProvider.Clear();

            // username
            if (string.IsNullOrEmpty(username))
            {
                errProvider.SetError(txtUsername, "Required*");
                hasError = true;
            }

            // password
            if (string.IsNullOrEmpty(password))
            {
                errProvider.SetError(txtPassword, "Required*");
                hasError = true;
            }

            if (hasError) return;
         
            
            if (handler.Login(username, password))
            {
                // hide login form
                Hide();

                // open dashboard on successful login
                frmMain main = new frmMain();
                main.ShowDialog();       
                
                // show login form when dashboard closes
                txtUsername.Clear();
                txtPassword.Clear();
                Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
