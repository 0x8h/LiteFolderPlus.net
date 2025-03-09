using System.IO;
using System.Windows.Forms;

namespace Litefolderplus.csharp
{
    internal class GetDriveLetter
    {
        internal static void Get(ListView list)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
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
                }
                else
                {
                    Listitemadd.Add(list, drivename, "", "", $"{dr}");
                }
            }
        }
    }
}
