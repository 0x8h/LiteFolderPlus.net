using System.Windows.Forms;

namespace Litefolderplus.csharp
{
    internal class Gettabnum
    {
        internal static int Get(TabControl tab)
        {
            int f = tab.TabCount;
            if (f == 1)
            {
                return f;
            }
            return f + 1;
        }
        internal static int reload(TabControl tab)
        {
            int i = tab.TabCount;
            return i;
        }
    }
}
