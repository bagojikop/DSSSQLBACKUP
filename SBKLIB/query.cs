using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBKLIB
{
    public class query
    {
        public string getScript(Credential credential, string databaseName, string backupType, string destination)
        {
            string Auth = "-E";
            if (credential.typ == 2)
            {
                Auth = $"-U {credential.userid} -P {credential.password}";
            }
            var dateString = DateTime.Now.ToString("ddMMyyy_hhmmss");
            string backupFile = destination + "\\" + databaseName + "_" + (backupType == "F" ? "FULL" : backupType == "D" ? "DIFF" : "LOG") + "_" + dateString + (backupType == "L" ? ".TRN" : ".BAK");

            string backupname = databaseName + " " + (backupType == "F" ? "FULL" : backupType == "D" ? "DIFF" : "LOG") + " backup for " + dateString;

            string initString = backupType == "D" ? "WITH DIFFERENTIAL, INIT" : "WITH INIT";
            string backupfor = backupType == "L" ? "LOG" : "DATABASE";

            string cmdtext = $"BACKUP {backupfor} [{databaseName}] TO DISK ='{backupFile}' {initString}, NAME='{backupname}', NOSKIP, NOFORMAT";

            string arguments = $@"-S {credential.server}   {Auth} -Q ""{cmdtext}""";

            return arguments;
        }


        static void ExecuteSqlCommand(string arguments)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "sqlcmd",
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process())
            {
                process.StartInfo = psi;
                process.OutputDataReceived += (sender, e) => Console.WriteLine(e.Data);
                process.ErrorDataReceived += (sender, e) => Console.WriteLine(e.Data);

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                process.WaitForExit();
            }
        }
    }
}
