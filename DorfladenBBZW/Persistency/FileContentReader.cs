using System;
using System.IO;

namespace DorfladenBBZW.Persistency
{
    public class FileContentReader
    {
        public string ReadFromAppData(string fileName)
        {
            var appDir = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
            var path = Path.Combine(appDir, fileName);

            return File.ReadAllText(path);
        }
    }
}