using System;
using System.IO;
using System.Windows.Forms;

namespace Litefolderplus.csharp
{
    internal class AddressBarFunc
    {
        internal static int AddressExistCheck(TextBox addressbarstatus)
        {
            string temp = addressbarstatus.Text;
            try
            {
                if (Directory.Exists(temp))
                {
                    return 1;
                }
                else if(File.Exists(temp))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Exceptionwriter.write(ex);
            }
            return 0;
        }
    }
}
