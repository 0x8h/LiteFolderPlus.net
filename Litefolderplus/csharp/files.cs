using System.Diagnostics;
using System.IO;

namespace Litefolderplus.csharp
{
    public class files
    {
        public static string GetFilesize(FileInfo file)
        {
            long a = file.Length;
            if(a < 1024)
            {
                return $"{a}B";
            }
            else if (a > 1024 && a < 1024 * 1024)
            {
                return $"{a / 1024}KB";
            }
            else if (a > 1024 * 1024 && a < 1024 * 1024 * 1024)
            {
                return $"{a / (1024 * 1024)}MB";
            }
            else if (a > 1024 * 1024 * 1024)
            {
                return $"{a / (1024 * 1024 * 1024)}GB";
            }
            else
            {
                return $"{a}";
            }
        } 
    }
}
