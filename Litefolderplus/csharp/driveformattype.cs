using System.IO;

namespace Litefolderplus.csharp
{
    public class driveformattype
    {
        public static string formattype(string sDrive)
        {
            DriveInfo d = new DriveInfo(sDrive);
            return d.DriveFormat;
        }
    }
}
