using System.IO;

namespace Litefolderplus.csharp
{
    internal class FileSizeCalc
    {
        internal static string CalcFileSize(FileInfo file)
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
