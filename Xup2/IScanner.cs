namespace Xup2
{
    using System.Collections.Generic;

    public interface IScanner
    {
        IEnumerable<IResource> ScanForResources(
            string path,
            string prefix,
            string suffix);
    }
}