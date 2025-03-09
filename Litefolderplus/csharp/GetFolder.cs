using System;
using System.IO;
using System.Windows.Forms;

namespace Litefolderplus.csharp
{
    internal class GetFolder
    {
        internal static void Get(ListView list, string dir)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(dir);
                foreach (var d in di.GetDirectories())
                {
                    Listitemadd.Add(list, d.Name, "", "Folder", $"{Directory.GetLastWriteTime(d.FullName)}", d.FullName);
                }
            }
            catch (Exception ex)
            {
                Exceptionwriter.write(ex);
            }
        }
    }
}
