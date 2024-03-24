using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

  namespace SQLBackupService
{
    public static class BackupSchedulde
    {

        public static void executeBackup(Schema schema, ILogger<Worker> logger)
        {

            if (schema.backupModes != null)
            {

                if (schema.backupModes.full.enabled)
                    backup(schema.backupModes.full, schema, logger, 1);

                if (schema.backupModes.diff.enabled)
                    backup(schema.backupModes.diff, schema, logger, 2);

                if (schema.backupModes.log.enabled)
                    backup(schema.backupModes.log, schema, logger, 3);

            }

        }

        public static void BackupProcedure(Schema schema, ILogger<Worker> logger,DateTime TargetDate ,byte typeId,bool isDeleteOld)
        {
            string datetime = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");

            // Create a temporary directory for recovery
            string tempDirectory = Path.Combine(schema.backupDestination, $"TempRecovery_{datetime}");
            if ( typeId==1 && isDeleteOld)
            {
                Directory.CreateDirectory(tempDirectory);
                string[] files = Directory.GetFiles(schema.backupDestination);
                foreach (string file in files)
                {
                    if (File.GetCreationTime(file).Date < TargetDate)
                    {
                        string fileName = Path.GetFileName(file);
                        string destinationPath = Path.Combine(tempDirectory, fileName);
                        File.Move(file, destinationPath);
                    }
                }
            }
            // Run the SQL command
            try
            {
                
                int exitCode;
                

                string backType = typeId == 1 ? "F" : typeId == 2 ? "D" : "L";

                var backypScript = new BackupScript();
                
                foreach (var db in schema.databases)
                {
                    string argument = backypScript.getScript(schema.sqlSetting.credential, db, backType, schema.backupDestination);
                    using (Process process = new Process())
                    {
                      //  ProcessStartInfo info = new ProcessStartInfo("sqlcmd", $"{Auth} -S {schema.sqlSetting.credential.server} -Q \"EXEC sp_BackupDatabases @backupLocation='{schema.backupDestination}\\', @databaseName='{db}', @backupType='{backType}'\"");
                        
                        ProcessStartInfo info = new ProcessStartInfo("sqlcmd", argument);

                        info.UseShellExecute = false;
                        info.CreateNoWindow = true;
                        info.RedirectStandardOutput = true;
                        info.RedirectStandardError = true;
                        process.StartInfo = info;
                        process.Start();
                        process.WaitForExit();
                        exitCode = process.ExitCode;
                    }
                    string backTypeName = typeId == 1 ? "Full" : typeId == 2 ? "Differential" : "Transaction Log";
                    if (exitCode == 0)
                    {
                        // SQL command executed successfully, cleanup temporary files
                        if (Directory.Exists(tempDirectory))
                            Directory.Delete(tempDirectory, true);
                         
                        logger.LogInformation($"{backTypeName} Backup Suceesfully Created");
                    }
                    else
                    {
                        if (typeId == 1 && isDeleteOld)
                        {
                            // Move files back from temporary directory
                            string[] files = Directory.GetFiles(tempDirectory);
                            foreach (string file in files)
                            {
                                string fileName = Path.GetFileName(file);
                                string destinationPath = Path.Combine(schema.backupDestination, fileName);
                                File.Move(file, destinationPath);
                            }

                            // Cleanup temporary directory
                            if (Directory.Exists(tempDirectory))
                                Directory.Delete(tempDirectory, true);
                        }
                        logger.LogInformation($"{backTypeName} Backup Faild ");

                    }
                }

            }
            catch (Exception ex)
            {
                
                if (typeId== 1 && isDeleteOld)
                {
                    // Move files back from temporary directory
                    string[] files = Directory.GetFiles(tempDirectory);
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileName(file);
                        string destinationPath = Path.Combine(schema.backupDestination, fileName);
                        File.Move(file, destinationPath);
                    }

                    // Cleanup temporary directory
                    if (Directory.Exists(tempDirectory))
                        Directory.Delete(tempDirectory, true);
                }
                logger.LogInformation("Backup Failed :"+ex.Message);
            }
        }

        public static string BackupProcedure(Schema schema, string  backType)
        {
            string datetime = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");

            // Create a temporary directory for recovery
            string tempDirectory = Path.Combine(schema.backupDestination, $"TempRecovery_{datetime}");
            
            // Run the SQL command
            try
            {

                int exitCode;


                

                var backypScript = new BackupScript();

                foreach (var db in schema.databases)
                {
                    string? errorOutput = null;
                    string argument = backypScript.getScript(schema.sqlSetting.credential, db, backType, schema.backupDestination);
                    using (Process process = new Process())
                    {
                        //  ProcessStartInfo info = new ProcessStartInfo("sqlcmd", $"{Auth} -S {schema.sqlSetting.credential.server} -Q \"EXEC sp_BackupDatabases @backupLocation='{schema.backupDestination}\\', @databaseName='{db}', @backupType='{backType}'\"");

                        ProcessStartInfo info = new ProcessStartInfo("sqlcmd", argument);
                         
                        info.UseShellExecute = false;
                        info.CreateNoWindow = true;
                        info.RedirectStandardOutput = true;
                        info.RedirectStandardError = true;
                       
                         
                        process.StartInfo = info;
                        process.Start();
                       
                        process.WaitForExit();

                        exitCode = process.ExitCode;
                        errorOutput = process.StandardError.ReadToEnd();
                    }
                    string backTypeName = backType=="F" ? "Full" :backType=="D" ?"Diff": "Log";
                    if (exitCode == 0)
                    {
                        // SQL command executed successfully, cleanup temporary files
                        if (Directory.Exists(tempDirectory))
                            Directory.Delete(tempDirectory, true);

                       return  $"{backTypeName} Backup Suceesfully Created";
                    }
                    else
                    {
                       
                        return $"{backTypeName} Backup Faild ";

                    }
                }

            }
            catch (Exception ex)
            {

                 
                return "Backup Failed :" + ex.Message;
            }
            return "Backup Failed";
        }

        private static  void backup(backupType backuptype, Schema schema ,ILogger<Worker> logger,byte  typeId)
        {
            DateTime targetDate = DateTime.Now;
            int? delBefore = schema.backupModes.deleteOldBackups.isDelete ? schema.backupModes.deleteOldBackups.beforeDays : null;
            switch (backuptype.typ)
            {

                case "Hourly":

                    if (delBefore != null)
                        targetDate = DateTime.Now.AddHours(-delBefore ?? 0);
                    BackupProcedure(schema, logger, targetDate, typeId, schema.backupModes.deleteOldBackups.isDelete);

                    break;
                case "Daily":

                    if (DateTime.Now.Hour == backuptype.hour && DateTime.Now.Minute == backuptype.minute)
                    {
                        if (delBefore != null)
                            targetDate = DateTime.Now.AddDays(-delBefore ?? 0);
                        BackupProcedure(schema, logger, targetDate, typeId, schema.backupModes.deleteOldBackups.isDelete);
                    }

                    break;
                case "Weekly":

                    if ((int)DateTime.Now.DayOfWeek == backuptype.weekOfDay && DateTime.Now.Hour == backuptype.hour && DateTime.Now.Minute == backuptype.minute)
                    {

                        targetDate = DateTime.Now.AddDays(-(delBefore * 7) ?? 0);
                        BackupProcedure(schema, logger, targetDate, typeId, schema.backupModes.deleteOldBackups.isDelete);
                    }

                    break;
                case "Monthly":
                    var sourceDate=DateTime.Now;
                    if (backuptype.day == 0)
                    {
                        var dt = DateTime.Now.AddMonths(1);
                         sourceDate = new DateTime(dt.Year, dt.Month, 1).AddDays(-1);
                    }
                    if (DateTime.Now.Day == sourceDate.Day && DateTime.Now.Hour == backuptype.hour && DateTime.Now.Minute == backuptype.minute)
                    {
                       

                        targetDate = DateTime.Now.AddMonths(-delBefore ?? 0);
                        BackupProcedure(schema, logger, targetDate, typeId, schema.backupModes.deleteOldBackups.isDelete);
                    }

                    break;
                case "Yearly":

                    if (DateTime.Now.Month == backuptype.month && DateTime.Now.Day == backuptype.day && DateTime.Now.Hour == backuptype.hour && DateTime.Now.Minute == backuptype.minute)
                    {

                        targetDate = DateTime.Now.AddYears(-delBefore ?? 0);
                        BackupProcedure(schema, logger, targetDate, typeId, schema.backupModes.deleteOldBackups.isDelete);
                    }

                    break;
            }

            
        }
    }
}
