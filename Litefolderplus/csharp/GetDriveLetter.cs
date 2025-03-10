using System.IO;
using System.Windows.Forms;

namespace Litefolderplus.csharp
{
    internal class GetDriveLetter
    {
        internal static void Get(ListView list, ToolStripMenuItem item)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            item.DropDownItems.Clear();
            foreach (DriveInfo s in drives)
            {
                string drivename = s.Name;
                DriveType dr = s.DriveType;
                if (s.IsReady)
                {
                    string Volumelabel = s.VolumeLabel;
                    string format = s.DriveFormat;
                    long total = s.TotalSize;
                    Listitemadd.Add(list, drivename, $"{total / (1024 * 1024 * 1024)}GB", $"{format}", $"{dr}");
                    ToolStripMenuItem drivess = new ToolStripMenuItem(drivename);
                    drivess.Tag = drivename;
                    item.DropDownItems.Add(drivess);
                }
                else
                {
                    Listitemadd.Add(list, drivename, "", "", $"{dr}");
                }
            }
        }
    }
}
