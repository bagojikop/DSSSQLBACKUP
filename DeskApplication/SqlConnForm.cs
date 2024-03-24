using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using SQLBackupService;
namespace SQLBackupDesk
{
    public partial class SqlConnForm : Form
    {
        
        public bool save = false;
        public SqlSetting sqlSetting = new SqlSetting();
        public SqlConnForm()
        {
            InitializeComponent();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            string sqlAuth = "Integrated Security=True";
            if (hopeRadioButtonSqlAuth.Checked)
            {
                sqlAuth = $"User Id={txtuser.Text}; Password={txtpassword.Text}";
            }

             
           string ConnectionString = $"Server={txtServer.Text}; {sqlAuth};    Encrypt={isEncrypt.Checked}; MultipleActiveResultSets=true;Connect Timeout=120";
            save = true;
            if(sqlSetting.credential==null)
            {
                sqlSetting.credential = new Credential();
            }
             sqlSetting.credential.server= txtServer.Text;
            sqlSetting.credential.userid= txtuser.Text  ;
            sqlSetting.credential.password = txtpassword.Text;
            sqlSetting.credential.typ=hopeRadioButtonWinAuth.Checked ? 1 :2;

            sqlSetting.credential.encrypt =isEncrypt.Checked  ;
            sqlSetting.credential.trustedConnection= TrustedConnection.Checked ;
            sqlSetting.connectionString = ConnectionString;

            this.Close();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string sqlAuth = "Integrated Security=True";
            if (hopeRadioButtonSqlAuth.Checked)
            {
                sqlAuth = $"User Id={txtuser.Text}; Password={txtpassword.Text}";
            }

             
           string ConnectionString = $"Server={txtServer.Text}; {sqlAuth};   Encrypt={isEncrypt.Checked}; MultipleActiveResultSets=true;Connect Timeout=120";


            SqlConnection oconn = new SqlConnection(ConnectionString);
            try
            {
                oconn.Open();
                MessageBox.Show("Connection String created Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Could not be established,please try again\r\n" + ex.Message);
            }
            finally { oconn.Close(); }




        }

        private void SqlConnForm_Load(object sender, EventArgs e)
        {
            if(sqlSetting==null)
            {
                sqlSetting=new SqlSetting();
            }
            txtServer.Text = sqlSetting.credential?.server;
            txtuser.Text = sqlSetting.credential?.userid;
            txtpassword.Text = sqlSetting.credential?.password;
            
            hopeRadioButtonWinAuth.Checked = sqlSetting.credential?.typ == 1;
            hopeRadioButtonSqlAuth.Checked = sqlSetting.credential?.typ == 2;
            isEncrypt.Checked = sqlSetting.credential?.encrypt ?? false;
            TrustedConnection.Checked=sqlSetting.credential?.trustedConnection ?? false;
        }
    }
}
