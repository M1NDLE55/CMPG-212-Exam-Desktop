using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
        public SqlConnection conn { get; set; }
        private SqlDataAdapter adapter;
        private DataSet ds;

        public DataHandler()
        {
            try
            {
                // get path to database - this is specific to the folder structure of the parent folder
                // this prevents problems related to the database copy in output directory when using |DataDirectory|
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
                // uses sql select statement to fill referenced datagridview
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

        public DataSet GetDataSet(SqlCommand cmd)
        {
            // for use with combo boxes

            try
            {
                // uses sql select statement to fill dataset with required column
                conn.Open();

                DataSet dataSet = new DataSet();

                adapter.SelectCommand = cmd;
                adapter.Fill(dataSet);

                cmd.Dispose();

                conn.Close();

                return dataSet;
            }
            catch (SqlException ex)
            {
                // error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }

        public void FillComboBox(DataSet dataSet, ref MaterialComboBox cmbRef, string column)
        {
            // uses dataset loaded with above function to associate combo box with column

            try
            {
                cmbRef.DisplayMember = column;
                cmbRef.ValueMember = column;
                cmbRef.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                // error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

        public bool ExecuteUpdate(SqlCommand cmd)
        {
            try
            {
                // uses sql update statement to update database
                conn.Open();

                adapter.UpdateCommand = cmd;
                adapter.UpdateCommand.ExecuteNonQuery();

                cmd.Dispose();

                conn.Close();

                return true;
            }
            catch (SqlException ex)
            {
                // error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);

                return false;
            }

        }
        public bool ExecuteDelete(SqlCommand cmd)
        {
            try
            {
                // uses sql delete statement to delete record from database
                conn.Open();

                adapter.DeleteCommand = cmd;
                adapter.DeleteCommand.ExecuteNonQuery();

                cmd.Dispose();

                conn.Close();

                return true;
            }
            catch(SqlException ex)
            {
                // error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);

                return false;
            }
        }

        public bool ExecuteInsert(SqlCommand cmd)
        {
            try
            {
                // uses sql insert statement to insert record into database
                conn.Open();

                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();

                conn.Close();

                return true;
            }
            catch (SqlException ex)
            {
                // error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);

                return false;
            }
        }

        public string[] GetRowValues(SqlCommand cmd)
        {
            // returns array with fields in row

            string[] data = new string[100];

            try
            {
                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                // create array with values of row
                if (dr.Read())
                {
                    // get number of fields in row
                    int fields = dr.FieldCount;

                    for(int i = 0; i < fields; i++)
                    {
                        data[i] = dr[i].ToString();
                    }

                    cmd.Dispose();
                    conn.Close();
                    return data;
                }
                else
                {
                    cmd.Dispose();
                    conn.Close();
                    return null;
                }             
            }
            catch (SqlException ex)
            {
                // error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
