using System.Windows.Forms;

namespace Litefolderplus.csharp
{
    internal class Listitemadd
    {
        internal static void Add(ListView target, string itemlabel, string itemsizes, string itemtyps, string date, string opt = null)
        {
            if (opt == null)
            {
                opt = itemlabel;
            }
            var Item = new ListViewItem(itemlabel)
            {
                Tag = opt
            };
            Item.SubItems.Add(itemsizes);
            Item.SubItems.Add(itemtyps);
            Item.SubItems.Add(date);
            target.Items.Add(Item);
        }
    }
}
