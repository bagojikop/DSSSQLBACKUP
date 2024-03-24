using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLBackupService
{



    public class Schema
    {
        public SqlSetting? sqlSetting { get; set; }
        public string[] databases { get; set; } = new string[0];
        public string? backupDestination { get; set; }
        public Backupmodes backupModes { get; set; } = null!;
        public bool isSendMail { get; set; }
        public string? mailAdderess { get; set; }
        public Deleteoldbackups? deleteOldBackups { get; set; }
    }

    public class SqlSetting
    {
        public Credential? credential { get; set; }
        public string? connectionString { get; set; }
    }

    public class Credential
    {
        public string server { get; set; } = null!;
        public int typ { get; set; }
        public string? userid { get; set; }
        public string? password { get; set; }
        public bool encrypt { get; set; }
        public bool trustedConnection { get; set; }
    }

    public class Backupmodes
    {
        public backupType full { get; set; } = null!;
        public backupType diff { get; set; } = null!;
        public backupType log { get; set; } = null!;
        public Deleteoldbackups deleteOldBackups { get; set; } = null!;
    }

    public class backupType
    {
        public string typ { get; set; } = null!;
        public int weekOfDay { get; set; }
        public int day { get; set; }
        public int month { get; set; }
        public int hour { get; set; }
        public int minute { get; set; }
        public bool enabled { get; set; }
    }


    public class Deleteoldbackups
    {
        public bool isDelete { get; set; }
        public int beforeDays { get; set; }
    }


}
