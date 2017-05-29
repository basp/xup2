using System.Text;

namespace Xup2
{
    public interface IResource
    {
        string Path { get; }

        byte[] ReadAllBytes();

        string ReadAllText(Encoding encoding);
    }
}