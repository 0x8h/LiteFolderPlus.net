using System;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace Litefolderplus.csharp
{
    internal class RightClickMenuFunc
    {
        internal static void Copy(ListView list, TextBox dirname)
        {
            try
            {
                if (list.SelectedItems.Count > 0)
                {
                    StringCollection strings = new StringCollection();
                    if (list.SelectedItems.Count > 1)
                    {
                        for (int i = 0; i < list.SelectedItems.Count; i++)
                        {
                            string temp1 = $@"{dirname.Text}{list.SelectedItems[i].Text}";
                            strings.Add(temp1);
                        }
                        Clipboard.SetFileDropList(strings);
                    }
                    string temp2 = $@"{dirname.Text}{list.SelectedItems[0].Text}";
                    strings.Add(temp2);
                    Clipboard.SetFileDropList(strings);
                }
            }
            catch(Exception ex)
            {
                Exceptionwriter.write(ex);
            }
        }
    }
}