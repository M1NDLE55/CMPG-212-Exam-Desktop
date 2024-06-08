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

        public void FillComboBox(SqlCommand cmd, ref MaterialComboBox cmbRef, string column)
        {
            // creates and assigns a new dataset to a combo box

            try
            {
                conn.Open();

                DataSet dataSet = new DataSet();

                adapter.SelectCommand = cmd;
                adapter.Fill(dataSet);

                cmd.Dispose();

                conn.Close();

                // assign desired column to dataset
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

                bool result = false;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    result = true;
                }

                cmd.Dispose();

                conn.Close();

                return result;
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

                bool result = false;
                if (adapter.DeleteCommand.ExecuteNonQuery() > 0)
                {
                    result = true;
                }

                cmd.Dispose();

                conn.Close();

                return result;
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

                bool result = false;
                if (adapter.InsertCommand.ExecuteNonQuery() > 0)
                {
                    result = true;
                }

                cmd.Dispose();

                conn.Close();

                return result;
            }
            catch (SqlException ex)
            {
                // error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.Diagnostics.Debug.WriteLine(ex.Message);

                return false;
            }
        }

        public string[] GetRowValues(SqlCommand cmd, int MAX_FIELDS = 50)
        {
            // returns array with fields of a single row

            string[] data = new string[MAX_FIELDS];

            try
            {
                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                // create array with values of row
                if (dr.Read())
                {
                    // get number of fields in row
                    int fields = dr.FieldCount;

                    // populate array
                    for(int i = 0; i < fields; i++)
                    {
                        data[i] = dr[i].ToString();
                    }
                }
                else
                {
                    data = null;
                }

                cmd.Dispose();
                conn.Close();
                return data;
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
