using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Litefolderplus.csharp
{
    public class Exceptionwriter
    {
        public static void exceptionwrite(Exception exception)
        {
            DateTime doutei = DateTime.Now;
            string asf = $"{doutei.Year}/{doutei.Month}/{doutei.Year}/{doutei.Date}/{doutei.Hour}:{doutei.Minute}";
            using (FileStream fs = File.Create(asf))
            {
                using (StreamWriter sr = new StreamWriter(asf))
                {
                    sr.WriteLine("---LiteFolderPlus.net exception---");
                    sr.WriteLine(exception.Message);
                    sr.Dispose();
                }
                fs.Dispose();
            }
        }
    }
}
