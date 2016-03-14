using System.Diagnostics;
using System.IO;
using System.Linq;

namespace JsonGenerator
{
    class ProgramInitialization
    {
        /// <summary>
        /// Program initialization: checking directory path, index.html file transfer, delete the old json file, open index.html by "iexplore" process
        /// </summary>
        public static void Initialize()
        {
            if (!Directory.Exists(@"C:\JsonGenerator"))
                Directory.CreateDirectory(@"C:\JsonGenerator");

            if (!File.Exists(@"C:\JsonGenerator\index.html"))
            {
                File.WriteAllText(@"C:\JsonGenerator\index.html", Properties.Resources.index);
            }

            try
            {
                File.Delete(@"C:\JsonGenerator\students.json");
            }
            catch { }

            if (!Process.GetProcessesByName("iexplore").Any())
                Process.Start("iexplore.exe", @"C:\JsonGenerator\index.html");
        }
    }
}
