using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace SQLBackupDesk
{
    public partial class DbForm : Form
    {
        public string? connectionstring;
        public List<string> list = new List<string>();
        public bool save = false;
        public string[] selectedDb;
        public DataTable tbl;

        private Stopwatch stopwatch;
        private System.Threading.Timer timer;
        private int totalTime = 120000;
        public DbForm()
        {
            InitializeComponent();
        }

        private void DbForm_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

                // change cursor to hourglass type

                // change cursor to normal type

                try
                {
                    Cursor = Cursors.WaitCursor;
                    checkedListBox1.Items.Clear();

                    var oconn = new SqlConnection(connectionstring);
                    oconn.Open();

                    SqlCommand cmd = oconn.CreateCommand();
                    var dbid = checkBox1.Checked == true ? 0 : 4;
                    cmd.CommandText = $"SELECT name FROM sys.databases where state=0 and  database_id > {dbid} ";
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string dbName = reader["name"].ToString();
                        var seldb = selectedDb.Where(w => w == dbName).FirstOrDefault();
                        checkedListBox1.Items.Add(dbName, seldb != null);
                    }
                    oconn.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Cursor = Cursors.Arrow;
                }



            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {


            foreach (string s in checkedListBox1.CheckedItems)
            {
                list.Add(s);
            }
            save = true;
            this.Close();
        }

        private void DbForm_Shown(object sender, EventArgs e)
        {

        }

        private void DbForm_Activated(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var oconn = new SqlConnection(connectionstring);
                oconn.Open();

                SqlCommand cmd = oconn.CreateCommand();
                cmd.CommandText = "SELECT name FROM sys.databases WHERE database_id > 4 and state=0";
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    string dbName = reader["name"].ToString();
                    var seldb=selectedDb.Where(w => w == dbName).FirstOrDefault();
                    checkedListBox1.Items.Add(dbName,seldb!=null);

                }
                oconn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Arrow;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
