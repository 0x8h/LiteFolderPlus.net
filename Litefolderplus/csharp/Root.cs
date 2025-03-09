using System.IO;

namespace Litefolderplus.csharp
{
    public class Root
    {
        public static bool IsDrive(string path) {
            string root = Path.GetPathRoot(path);
            return root.Length == 3 && root[1] == ':' && Directory.Exists(root);
        }
    }
}
