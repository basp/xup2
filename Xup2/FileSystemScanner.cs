namespace Xup2
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class FileSystemScanner : IScanner
    {
        public IEnumerable<IResource> ScanForResources(
            string path,
            string prefix,
            string suffix)
        {
            var files = Directory.EnumerateFiles(
                path,
                $"{prefix}*{suffix}",
                SearchOption.AllDirectories);

            return files
                .Select(x => new FileSystemResource(x))
                .OrderBy(x => Path.GetFileName(x.Path));
        }
    }
}