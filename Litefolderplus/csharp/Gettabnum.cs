using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
