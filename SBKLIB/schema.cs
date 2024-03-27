namespace SBKLIB
{

    public class Schema
    {
        public SqlSetting? sqlSetting { get; set; }
        public string[] databases { get; set; } = new string[0];
        public string? backupDestination { get; set; }
        public Backupmodes backupModes { get; set; } = null!;
        public bool isSendMail { get; set; }
        public string? mailAdderess { get; set; }
        
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
        public backupType full { get; set; } =  new backupType();
        public backupType diff { get; set; } = new backupType();
        public backupType log { get; set; } = new backupType();
        public Deleteoldbackups deleteOldBackups { get; set; } = new Deleteoldbackups();
    }

    public class backupType
    {
        public string typ { get; set; } = "Weekly";
        public int weekOfDay { get; set; }
        public int day { get; set; }
        public int month { get; set; }
        public int hour { get; set; } = 23;
        public int minute { get; set; } = 0;
        public bool enabled { get; set; }
    }


    public class Deleteoldbackups
    {
        public bool isDelete { get; set; }=false;
        public int beforeDays { get; set; } = 0;
    }
}
