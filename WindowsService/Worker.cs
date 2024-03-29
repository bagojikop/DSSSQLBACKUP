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

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            string serviceDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string parentDirectory = Path.Combine(serviceDirectory, "..");
            string filePath = Path.Combine(parentDirectory, "backupSettings.json");

            string jsonString = File.ReadAllText(filePath);
            Schema schema = JsonSerializer.Deserialize<Schema>(jsonString);

            if (schema != null && schema.backupModes != null)
            {
                List<Task> backupTasks = new List<Task>();

                // Task for full backup
                if (schema.backupModes.full != null && schema.backupModes.full.enabled)
                {
                    Task task1 = Task.Run(async () =>
                    {
                        while (!stoppingToken.IsCancellationRequested)
                        {
                            TimeSpan interval = BackupSchedule.backup(schema.backupModes.full, schema, _logger, 1);
                            await Task.Delay(interval);
                        }
                    });
                    backupTasks.Add(task1);
                }

                // Task for differential backup
                if (schema.backupModes.diff != null && schema.backupModes.diff.enabled)
                {
                    Task task2 = Task.Run(async () =>
                    {
                        while (!stoppingToken.IsCancellationRequested)
                        {
                            TimeSpan interval = BackupSchedule.backup(schema.backupModes.diff, schema, _logger, 2);
                            await Task.Delay(interval);
                        }
                    });
                    backupTasks.Add(task2);
                }

                // Task for log backup
                if (schema.backupModes.log != null && schema.backupModes.log.enabled)
                {
                    Task task3 = Task.Run(async () =>
                    {
                        while (!stoppingToken.IsCancellationRequested)
                        {
                            TimeSpan interval = BackupSchedule.backup(schema.backupModes.log, schema, _logger, 3);
                            await Task.Delay(interval);
                        }
                    });
                    backupTasks.Add(task3);
                }

                // Wait for all backup tasks to complete
                await Task.WhenAll(backupTasks);
            }
            else
            {
                _logger.LogWarning("Backup modes are not specified in the schema. Skipping backup execution.");
                await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
            }
        }


    }
}

 
