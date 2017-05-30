namespace Xup2.Cli
{
    using System;
    using System.IO;
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
            var path = @"D:\tmp\xup";
            var scanner = new FileSystemScanner();
            var resources = scanner.ScanForResources(path, "V", ".sql");
            foreach(var r in resources)
            {
                var fileName = Path.GetFileName(r.Path);
                // var (parts, description) = fileName.ParseVersionAndDescription();
                // var migrationVersion = new MigrationVersion(description, parts);
                // Console.WriteLine(migrationVersion);
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
