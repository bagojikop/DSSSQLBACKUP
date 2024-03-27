
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBKLIB;
namespace SQLBackupDesk
{
    public partial class ScheduleForm : Form
    {
        public Backupmodes Backupmodes = new Backupmodes();
        public bool save;
        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void FullBackUpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Backupmodes.full.typ = FullBackUpType.Text;
            setValue();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Backupmodes.full.enabled = true;
            Backupmodes.full.typ = FullBackUpType.Text;
            Backupmodes.full.hour = FullBackUpAMPM.Text == "PM" ? 12 + Convert.ToInt32(FullBackUpHrs.Value) : Convert.ToInt32(FullBackUpHrs.Value);
            Backupmodes.full.minute = Convert.ToInt32(FullBackUpMinutes.Value);
            Backupmodes.full.weekOfDay = FullWeekOfDayComboBox.SelectedIndex ;
            Backupmodes.full.day = Convert.ToInt32(FullMonthOfDayNumericBox.Value );


            Backupmodes.diff.enabled = DiffCheckBox.Checked;
            Backupmodes.diff.typ = DiffBackUpType.Text;
            Backupmodes.diff.hour = DiffBackUpAMPM.Text == "PM" ? 12 + Convert.ToInt32(DiffBackUpHrs.Value) : Convert.ToInt32(DiffBackUpHrs.Value);
            Backupmodes.diff.minute = Convert.ToInt32(DiffBackUpMinutes.Value);
            Backupmodes.diff.weekOfDay = DiffWeekOfDayComboBox.SelectedIndex ;
            Backupmodes.diff.day = Convert.ToInt32(DiffMonthOfDayNumericBox.Value);

            Backupmodes.log.enabled = TLogCheckBox.Checked;
            Backupmodes.log.typ = TLogBackUpType.Text;
            Backupmodes.log.hour = TLogBackUpAMPM.Text == "PM" ? 12 + Convert.ToInt32(TLogBackUpHrs.Value) : Convert.ToInt32(TLogBackUpHrs.Value);
            Backupmodes.log.minute = Convert.ToInt32(TLogBackUpMinutes.Value);
            Backupmodes.log.weekOfDay = TLogWeekOfDayComboBox.SelectedIndex;
            Backupmodes.log.day = Convert.ToInt32(TLogMonthOfDayNumericBox.Value);

            Backupmodes.deleteOldBackups.isDelete = isDelete.Checked;
            Backupmodes.deleteOldBackups.beforeDays = Convert.ToInt32(beforeDays.Value);
            save = true;
            this.Close();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            if (Backupmodes == null)
            {
                Backupmodes = new Backupmodes();
                Backupmodes.full = new backupType();
                Backupmodes.diff = new backupType();
                Backupmodes.log = new backupType();
                Backupmodes.deleteOldBackups = new Deleteoldbackups();
            }
            else
            {
                FullCheckBox.Checked = true;
                FullBackUpType.Text = Backupmodes.full.typ;
                FullBackUpHrs.Value = (Backupmodes.full.hour > 12 ? Backupmodes.full.hour - 12 : Backupmodes.full.hour);
                FullBackUpMinutes.Value = Backupmodes.full.minute;
                FullBackUpAMPM.Text = Backupmodes.full.hour > 12 ? "PM" : "AM";



                DiffCheckBox.Checked = Backupmodes.diff.enabled;
                DiffBackUpType.Text = Backupmodes.diff.typ;
                DiffBackUpHrs.Value = (Backupmodes.diff.hour > 12 ? Backupmodes.diff.hour - 12 : Backupmodes.diff.hour);
                DiffBackUpMinutes.Value = Backupmodes.diff.minute;
                DiffBackUpAMPM.Text = Backupmodes.diff.hour > 12 ? "PM" : "AM";


                TLogCheckBox.Checked = Backupmodes.log.enabled;
                TLogBackUpType.Text = Backupmodes.log.typ;
                TLogBackUpHrs.Value = (Backupmodes.log.hour > 12 ? Backupmodes.log.hour - 12 : Backupmodes.log.hour);
                TLogBackUpMinutes.Value = Backupmodes.log.minute;
                TLogBackUpAMPM.Text = Backupmodes.log.hour > 12 ? "PM" : "AM";

                isDelete.Checked = Backupmodes.deleteOldBackups.isDelete;
                beforeDays.Value = Backupmodes.deleteOldBackups.beforeDays;

                setValue();
            }
        }

        public void setValue()
        {


            if (Backupmodes.full.typ == "Weekly" || Backupmodes.full.typ == "Monthly")
                FullPanelSch.Visible = true;
            else
                FullPanelSch.Visible = false;

            if (Backupmodes.diff.typ == "Weekly" || Backupmodes.diff.typ == "Monthly")
                DiffPanelSch.Visible = true;
            else
                DiffPanelSch.Visible = false;

            if (Backupmodes.log.typ == "Weekly" || Backupmodes.log.typ == "Monthly")
                TLogPanelSch.Visible = true;
            else
                TLogPanelSch.Visible = false;


            if (Backupmodes.full.typ == "Weekly")
            {
                FullWeekOfDayPanel.Visible = true;
                FullWeekOfDayComboBox.SelectedIndex = Backupmodes.full.weekOfDay;
                FullMonthPanel.Visible = false;

            }
            else if (Backupmodes.full.typ == "Monthly")
            {
                FullMonthPanel.Visible = true;
                FullMonthOfDayNumericBox.Text = Backupmodes.full.day.ToString();
                FullWeekOfDayPanel.Visible = false;
            }


            if (Backupmodes.diff.typ == "Weekly")
            {
                DiffWeekOfDayPanel.Visible = true;
                DiffWeekOfDayComboBox.SelectedIndex = Backupmodes.diff.weekOfDay;
                DiffMonthPanel.Visible = false;

            }
            else if (Backupmodes.diff.typ == "Monthly")
            {
                DiffMonthPanel.Visible = true;
                DiffMonthOfDayNumericBox.Text = Backupmodes.diff.day.ToString();
                DiffWeekOfDayPanel.Visible = false;
            }

            if (Backupmodes.log.typ == "Weekly")
            {
                TLogWeekOfDayPanel.Visible = true;
                TLogWeekOfDayComboBox.SelectedIndex = Backupmodes.diff.weekOfDay;
                TLogMonthPanel.Visible = false;

            }
            else if (Backupmodes.log.typ == "Monthly")
            {
                TLogMonthPanel.Visible = true;
                TLogMonthOfDayNumericBox.Text = Backupmodes.log.day.ToString();
                TLogWeekOfDayPanel.Visible = false;
            }

            FullLabel.Text = getlabel(FullBackUpType.Text);
        }
        private string getlabel(string typ)
        {
            switch (typ)
            {
                case "Hourly":
                    return "hours";
                case "Weekly":
                    return "Weeks";
                case "Daily":
                    return "Days";
                case "Monthly":
                    return "Month";
                default:
                    return "Days";

            }
        }

        private void DiffBackUpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Backupmodes.diff.typ = DiffBackUpType.Text;
            setValue();
        }

        private void TLogBackUpType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Backupmodes.log.typ =TLogBackUpType.Text;
            setValue();
        }
    }
}
