using System;
using System.IO;
using System.Windows.Forms;

namespace Litefolderplus.csharp
{
    internal class Exist
    {
        internal static int Survey(string Dir)
        {
            try
            {
                if (Directory.Exists(Dir))
                {
                    return 1;
                }
                else if(File.Exists(Dir))
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
