using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Desktop_44905165
{
    internal class DataHandler
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataSet ds;

        public DataHandler()
        {
            try
            {
                // get path to database - this is specific to the folder structure of the parent folder
                // this prevents errors related to database copies when using |DataDirectory|
                string parentFolder = AppDomain.CurrentDomain.BaseDirectory;
                string relativePath = @"..\..\BrightonMedical.mdf";
                string databasePath = Path.GetFullPath(Path.Combine(parentFolder, relativePath));

                // connect to database
                conn = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True");       
                adapter = new SqlDataAdapter();
                ds = new DataSet();
            }
            catch (Exception ex)
            {
                // error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        public SqlConnection GetSqlConnection()
        {
            return conn;
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
                    cmd.Dispose();
                    conn.Close();
                    return true;
                }
                else
                {
                    cmd.Dispose();
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

        public void FillDataGridView(SqlCommand cmd, ref DataGridView dgv)
        {
            try
            {
                // uses sql statement with or without parameters to fill referenced datagridview
                conn.Open();     
                
                ds.Clear();

                adapter.SelectCommand = cmd;
                adapter.Fill(ds);

                dgv.DataSource = ds;
                dgv.DataMember = ds.Tables[0].TableName;

                cmd.Dispose();

                conn.Close();
            }
            catch (SqlException ex)
            {
                // error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        public void ExecuteUpdate(SqlCommand cmd)
        {
            try
            {
                // uses sql statement with or without parameters to update database
                conn.Open();

                adapter.UpdateCommand = cmd;
                adapter.UpdateCommand.ExecuteNonQuery();

                cmd.Dispose();

                conn.Close();
            }
            catch(SqlException ex)
            {
                // error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
    }
}
