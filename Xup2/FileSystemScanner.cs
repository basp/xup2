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
            string suffix) =>
                EnumerateFiles(path, prefix, suffix)
                    .Select(x => new FileSystemResource(x))
                    .OrderBy(x => Path.GetFileName(x.Path));

        private IEnumerable<string> EnumerateFiles(
            string path,
            string prefix,
            string suffix) =>
            Directory.EnumerateFiles(
                path,
                searchPattern: $"{prefix}*{suffix}",
                searchOption: SearchOption.AllDirectories);
    }
}