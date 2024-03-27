using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBKLIB
{
    public class schedulde
    {
        public static string BackupProcedure(Schema schema, string backType)
        {
            string datetime = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");

            // Create a temporary directory for recovery
            string tempDirectory = Path.Combine(schema.backupDestination, $"TempRecovery_{datetime}");

            // Run the SQL command
            try
            {

                int exitCode;




                var backypScript = new query();

                foreach (var db in schema.databases)
                {
                    string? errorOutput = null;
                    string argument = backypScript.getScript(schema.sqlSetting.credential, db, backType, schema.backupDestination);
                    using (Process process = new Process())
                    {
                        //  ProcessStartInfo info = new ProcessStartInfo("sqlcmd", $"{Auth} -S {schema.sqlSetting.credential.server} -Q \"EXEC sp_BackupDatabases @backupLocation='{schema.backupDestination}\\', @databaseName='{db}', @backupType='{backType}'\"");

                        ProcessStartInfo info = new ProcessStartInfo("../sqlcmd", argument);

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
                    string backTypeName = backType == "F" ? "Full" : backType == "D" ? "Diff" : "Log";
                    if (exitCode == 0)
                    {
                        // SQL command executed successfully, cleanup temporary files
                        if (Directory.Exists(tempDirectory))
                            Directory.Delete(tempDirectory, true);

                        return $"{backTypeName} Backup Suceesfully Created";
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

    }
}
