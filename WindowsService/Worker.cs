using System.Diagnostics;

namespace SQLBackupService
{
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using SBKLIB;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using System.Text.Json;
    using System.Threading;
    using System.Threading.Tasks;
    

    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _config;
        public Worker(ILogger<Worker> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken )
        {
            string serviceDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

           
            string parentDirectory = Path.Combine(serviceDirectory, "..");
            string filePath = Path.Combine(parentDirectory, "backupSettings.json");

            while (!stoppingToken.IsCancellationRequested)
                {
                    
                        string jsonString = File.ReadAllText(filePath);


                        Schema schema = JsonSerializer.Deserialize<Schema>(jsonString);

                        TimeSpan intervalhrs = getintervaltime(schema);

                        if (schema != null)
                        {

                            BackupSchedulde.executeBackup(schema, _logger);
                        }

                        // Delay for one hour before checking again
                        await Task.Delay(intervalhrs, stoppingToken);
                    //}

                    //else
                    //{
                    //    // Log a message indicating that the file does not exist
                    //    _logger.LogWarning("Backup settings file 'backupSettings.json' not found.");

                    //    // Delay for a shorter interval before trying again
                    //    await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
                    //}
                }
            }
            
 

        private TimeSpan getintervaltime(Schema schema)
        {

            TimeSpan timeSpan = TimeSpan.FromHours(1);

            List<backupType> backupTypes = new List<backupType>();
            if (schema.backupModes != null)
            {
                backupTypes.Add(schema.backupModes.full);
                backupTypes.Add(schema.backupModes.diff);
                backupTypes.Add(schema.backupModes.log);

                var btype1 = backupTypes.Where(w => w.typ == "Hourly" && w.enabled == true).Select(s => new { s.hour, s.minute }).FirstOrDefault();

                if (btype1 != null)
                {
                    timeSpan = TimeSpan.FromHours(btype1.hour) + TimeSpan.FromMinutes(btype1.minute);
                    return timeSpan;
                }
                var btype2 = backupTypes.Where(w => w.typ == "Daily" && w.enabled == true).Select(s => new { s.hour, s.minute }).FirstOrDefault();

                if (btype2 != null)
                {
                    timeSpan = TimeSpan.FromHours(24);
                    return timeSpan;
                }
                var btype3 = backupTypes.Where(w => w.typ == "Weekly" && w.enabled == true).Select(s => new { s.hour, s.minute }).FirstOrDefault();

                if (btype3 != null)
                {
                    timeSpan = TimeSpan.FromHours(168);
                    return timeSpan;
                }
                var btype4 = backupTypes.Where(w => w.typ == "Monthly" && w.enabled == true).Select(s => new { s.hour, s.minute }).FirstOrDefault();
                if (btype4 != null)
                {
                    timeSpan = TimeSpan.FromHours(720);
                    return timeSpan;
                }
                var btype5 = backupTypes.Where(w => w.typ == "Yearly" && w.enabled == true).Select(s => new { s.hour, s.minute }).FirstOrDefault();
                if (btype5 != null)
                {
                    timeSpan = TimeSpan.FromHours(8760);
                    return timeSpan;
                }
            }
            return timeSpan;
        }
    }
}

 
