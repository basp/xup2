using System;

namespace Xup2.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"D:\temp\xup";
            var scanner = new FileSystemScanner();
            var resources = scanner.ScanForResources(path, "V", ".sql");

            foreach(var r in resources)
            {
                Console.WriteLine(r.Path);
            }
        }
    }
}
