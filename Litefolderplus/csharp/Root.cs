using System.IO;

namespace Litefolderplus.csharp
{
    internal class Root
    {
        internal static bool IsDrive(string path) {
            string root = Path.GetPathRoot(path);
            return root.Length == 3 && root[1] == ':' && Directory.Exists(root);
        }
    }
}
