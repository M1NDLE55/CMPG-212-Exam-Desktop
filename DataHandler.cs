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
                // connect to database
                conn = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\BrightonMedical.mdf;Integrated Security=True");
            }
            catch (Exception ex)
            {
                // error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        public bool Login(string username, string password)
        {
            try
            {
                conn.Open();

                // get a dummy row if a record exists
                SqlCommand cmd = new SqlCommand(@"select 1 from admin where username = @username and password = @password", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SqlDataReader dr = cmd.ExecuteReader();

                // return state of record existence
                if (dr.Read())
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }            
            }
            catch (SqlException ex)
            {
                // error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);

                return false;
            }
        }
    }
}
