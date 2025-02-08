using System.IO;

namespace Litefolderplus.csharp
{
    public class GetFoldersize
    {
        public static long getsize(DirectoryInfo sDir) //Full path
        {
            long size = 0;
            foreach (FileInfo fi in sDir.GetFiles())
            {
                size += fi.Length;
            }
            foreach(DirectoryInfo d in sDir.GetDirectories())
            {
                size += getsize(d);
            }
            return size;
        }
    }
}
