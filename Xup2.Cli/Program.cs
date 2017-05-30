namespace Xup2.Cli
{
    using System;
    using System.Linq;
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
            
            var versioned = scanner.ScanForResources(path, "V", ".sql");
            var repeatable = scanner.ScanForResources(path, "R", ".sql");
            
            var resources = versioned.Concat(repeatable);

            foreach(var r in resources)
            {
                var fileName = Path.GetFileName(r.Path);
                var m = fileName.ParseMigration();
                Console.WriteLine(m);
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
