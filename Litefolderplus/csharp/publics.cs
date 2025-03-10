using System.Runtime.InteropServices;

namespace Litefolderplus.csharp
{
    internal class publics
    {
        [DllImport("user32.dll")]
        public static extern int MessageBeep(uint n);
        public static MainWindow mainw = new MainWindow();
    }
}
