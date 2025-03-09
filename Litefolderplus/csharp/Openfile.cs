using System;
using System.Diagnostics;

namespace Litefolderplus.csharp
{
    public class Openfile
    {
        public static void openfileindefaultapplication(string sPath)
        {
            try
            {
                var start = new ProcessStartInfo()
                {
                    FileName = sPath,
                    UseShellExecute = true,
                    CreateNoWindow = true,
                };
                Process.Start(start);
            }
            catch (Exception e)
            {
                Exceptionwriter.write(e);
            }
        }
    }
}
