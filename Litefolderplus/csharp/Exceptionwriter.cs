using System;
using System.IO;

namespace Litefolderplus.csharp
{
    public class Exceptionwriter
    {
        public static void exceptionwrite(Exception exception)
        {
            DateTime doutei = DateTime.Now;
            string asf = $"{doutei.Hour}_{doutei.Minute}.txt";
            using (StreamWriter sr = new StreamWriter(asf))
            {
                sr.WriteLine("---LiteFolderPlus.net exception---");
                sr.WriteLine(exception.Message);
                sr.WriteLine("---Stack Trave information---");
                sr.WriteLine(exception.StackTrace);
                sr.Dispose();
            }
        }
    }
}
