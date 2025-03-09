using System;
using System.IO;
using System.Windows.Forms;

namespace Litefolderplus.csharp
{
    internal class GetFiles
    {
        internal static void Get(ListView list, string dir)
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(dir);
                FileInfo[] fi = d.GetFiles("*");
                foreach (FileInfo fi2 in fi)
                {
                    Listitemadd.Add(list, fi2.Name, $"{FileSizeCalc.CalcFileSize(fi2)}", "file", $"{Directory.GetLastWriteTime(fi2.FullName)}", fi2.FullName);
                }
            }
            catch(Exception ex)
            {
                Exceptionwriter.write(ex);
            }
        }
    }
}