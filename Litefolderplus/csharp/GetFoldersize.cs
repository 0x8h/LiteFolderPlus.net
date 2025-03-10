using System.IO;

namespace Litefolderplus.csharp
{
    internal class GetFoldersize
    {
        internal static long Get(DirectoryInfo sDir) //Full path
        {
            long size = 0;
            foreach (FileInfo fi in sDir.GetFiles())
            {
                size += fi.Length;
            }
            foreach(DirectoryInfo d in sDir.GetDirectories())
            {
                size += Get(d);
            }
            return size;
        }
    }
}
