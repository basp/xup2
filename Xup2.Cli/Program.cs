namespace Xup2.Cli
{
    using System;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    class Program
    {
        private readonly ILogger<Program> logger;

        public Program(ILogger<Program> logger)
        {
            this.logger = logger;
        }

        public void Run()
        {
            var path = @"D:\temp\xup";
            var scanner = new FileSystemScanner();
            var resources = scanner.ScanForResources(path, "V", ".sql");
            foreach(var r in resources)
            {
                Console.WriteLine(r.Path);
            }
        }

        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);
            
            var provider = services.BuildServiceProvider();
            var program = provider.GetService<Program>();
            program.Run();            
        }

        static void ConfigureServices(IServiceCollection services)
        {
            var loggerFactory = new LoggerFactory()
                .AddConsole();
            
            services.AddLogging();
            services.AddSingleton(loggerFactory);
            services.AddTransient<Program>();
        }
    }
}
