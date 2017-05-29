namespace Xup2
{
    using System;
    using System.Text;

    public class FileSystemResource : IResource
    {
        public FileSystemResource(string path)
        {
            this.Path = path;
        }

        public string Path
        {
            get;
        }

        public byte[] ReadAllBytes()
        {
            throw new NotImplementedException();
        }

        public string ReadAllText(Encoding encoding)
        {
            throw new NotImplementedException();
        }
    }
}