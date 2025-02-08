using System.Runtime.InteropServices;

namespace Litefolderplus.csharp
{
    public class win32
    {
        [DllImport("user32.dll")]
        public static extern int MessageBeep(uint n);
    }
}
