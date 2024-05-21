using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_44905165
{
    internal class DataHandler
    {
        private SqlConnection conn;

        public DataHandler()
        {
            try
            {
                conn = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BrightonMedical.mdf;Integrated Security=True");
            }
            catch (Exception ex)
            {
                // error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
    }
}
