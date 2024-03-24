using SQLBackupService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SQLBackupDesk
{
    public partial class MainForm : Form
    {
        Schema backupschema = new Schema();
        private Stopwatch stopwatch;
        private int totaltime=0;
        private int progress = 0;
        public MainForm()
        {
            InitializeComponent();
            lostBorderPanel1.BackColor = SystemColors.Control;
            lostBorderPanel2.BackColor = SystemColors.Control;
            lostBorderPanel3.BackColor = SystemColors.Control;
            lostBorderPanel4.BackColor = SystemColors.Control;
            lostBorderPanel5.BackColor = SystemColors.Control;
        }

        private void MailToggle_CheckedChanged(object sender, EventArgs e)
        {
            MailtextBox.Enabled = MailToggle.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm = new SqlConnForm();
            frm.sqlSetting = backupschema.sqlSetting;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.save)
            {
                backupschema.sqlSetting = frm.sqlSetting;

                textBoxServerName.Text = backupschema.sqlSetting.credential.server;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new DbForm();
            frm.selectedDb = backupschema.databases;
            frm.connectionstring = backupschema.sqlSetting?.connectionString;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.save)
            {
                textBoxDatabases.Text = string.Join(",", frm.list);
                backupschema.databases = textBoxDatabases.Text.Split(',');
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {

            var path = new FolderBrowserDialog();
            path.ShowDialog();
            textBoxDestination.Text = path.SelectedPath;


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string jsonString = File.ReadAllText("backupSettings.json");
            backupschema = JsonSerializer.Deserialize<Schema>(jsonString);
            if (backupschema?.sqlSetting != null)
            {
                textBoxServerName.Text = backupschema.sqlSetting.credential.server;
                textBoxDatabases.Text = string.Join(',', backupschema.databases);
                textBoxDestination.Text = backupschema.backupDestination;
                MailToggle.Checked = backupschema.isSendMail;
                MailtextBox.Text = backupschema.mailAdderess;
                foreverComboBox1.SelectedIndex = 0;
                setschValue();
                Refresh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frm = new ScheduleForm();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Backupmodes = backupschema.backupModes;

            frm.ShowDialog();
            if (frm.save)
            {
                backupschema.backupModes = frm.Backupmodes;
                setschValue();
            }

        }
        private void setschValue()
        {

            Fulltime.Value = new DateTime(1900, 1, 1, backupschema.backupModes.full.hour, backupschema.backupModes.full.minute, 0);
            if (backupschema.backupModes.diff.enabled)
            {
                diffTime.Value = new DateTime(1900, 1, 1, backupschema.backupModes.diff.hour, backupschema.backupModes.diff.minute, 0);

            }
            else
                DiffTimepanel.Visible = false;

            fullLabel.Text = getlabel(backupschema.backupModes.full.typ);
            diffLabel.Text = getlabel(backupschema.backupModes.diff.typ);

        }

        private void hopeButton1_Click(object sender, EventArgs e)
        {
            backupschema.backupDestination = textBoxDestination.Text;
            backupschema.isSendMail = MailToggle.Checked;
            backupschema.mailAdderess = MailtextBox.Text;

            var jsongstring = JsonSerializer.Serialize(backupschema);
            File.WriteAllText("backupSettings.json", jsongstring);

            Close();
        }

        private string getlabel(string typ)
        {
            switch (typ)
            {
                case "Hourly":
                    return "every hours";
                case "Weekly":
                    return "every Week";
                case "Daily":
                    return "every days";
                case "Monthly":
                    return "every month";
                default:
                    return "every days";

            }
        }

        private void hopeButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nightButton2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Visible = true;
            nightButton2.Enabled = false;
            progress = 0;
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            progressBar1.ValueNumber = 0;
            
            //string jsonString = File.ReadAllText("backupSettings.json");
            //Schema schema = JsonSerializer.Deserialize<Schema>(jsonString);
            string backtype = string.Empty;
            totaltime = 10000* backupschema.databases.Count();
            if (totaltime > 0)
            {
                stopwatch = Stopwatch.StartNew();


                // Use Invoke to access foreverComboBox1.SelectedIndex on the UI thread
                foreverComboBox1.Invoke(new Action(() =>
                {
                    backtype = foreverComboBox1.SelectedIndex == 0 ? "F" : foreverComboBox1.SelectedIndex == 1 ? "D" : "L";
                }));
                try
                {
                    // Perform backup procedure
                    var message = BackupSchedulde.BackupProcedure(backupschema, backtype);

                    // Report progress and pass message to RunWorkerCompleted event
                    backgroundWorker1.ReportProgress(100, message);

                    e.Result = "Backup completed successfully.";
                }
                catch (Exception ex)
                {

                    e.Result = ex.Message;
                }
                finally
                {
                    timer1.Enabled = false;
                     
                }
            }
            else
            {
                backgroundWorker1.ReportProgress(100);

                e.Result = "No Database Found....";
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.ValueNumber = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            nightButton2.Enabled = true;
            MessageBox.Show(e.Result?.ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (totaltime > 0)
            //{
            //    int progress = (int)((stopwatch.ElapsedMilliseconds / totaltime) *1000 );
            //    if (progress <= 90)
            //        backgroundWorker1.ReportProgress(progress);
            //    else
            //    {
            //        progress = 90;
            //        backgroundWorker1.ReportProgress(progress);
            //    }
            //}
            decimal a = Convert.ToDecimal( stopwatch.ElapsedMilliseconds) / Convert.ToDecimal( totaltime);
            var b = Convert.ToInt32( a * 100);

            progress += b;
            if (progress <= 90)
                backgroundWorker1.ReportProgress(progress);
            else
                backgroundWorker1.ReportProgress(90);
        }
    }
}
