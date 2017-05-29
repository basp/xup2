namespace Xup2
{
    using System;
    using System.Collections.Generic;   
    using System.Linq;
    using System.IO;

    public static class Extensions
    {
        public static bool IsDirectory(this FileInfo fi) =>
            (fi.Attributes & FileAttributes.Directory) == FileAttributes.Directory;

        public static void AddRange<T>(this ISet<T> s, ISet<T> items) =>
            Array.ForEach(items.ToArray(), x => s.Add(x));
    }
}