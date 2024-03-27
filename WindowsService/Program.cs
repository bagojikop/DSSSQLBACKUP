using SQLBackupService;



IHost host = Host.CreateDefaultBuilder(args).UseWindowsService()
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();


public class MyService : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Service is starting.");
            // Your service logic goes here.
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Service is stopping.");
            // Cleanup logic goes here.
            return Task.CompletedTask;
        }
    }
