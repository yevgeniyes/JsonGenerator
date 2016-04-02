using System.IO;
using System.Diagnostics;
using System.Linq;

namespace JsonGenerator
{
    abstract class GeneratorBase
    {
        public void Execute()
        {
            Initialize();
            GenerateJson();
            ConvertJsonToJs(@"C:\JsonGenerator\students.json", @"C:\JsonGenerator\students.js");
        }

        virtual public void Initialize()
        {
            if (!Directory.Exists(@"C:\JsonGenerator"))
                Directory.CreateDirectory(@"C:\JsonGenerator");

            if (!File.Exists(@"C:\JsonGenerator\index.html") || !File.Exists(@"C:\JsonGenerator\index1.html"))
            {
                File.WriteAllText(@"C:\JsonGenerator\index.html", Properties.Resources.index);
                File.WriteAllText(@"C:\JsonGenerator\index1.html", Properties.Resources.index1);
            }

            try
            {
                File.Delete(@"C:\JsonGenerator\students.json");
                File.Delete(@"C:\JsonGenerator\students.js");
            }
            catch { }

            if (!Process.GetProcessesByName("iexplore").Any())
                Process.Start("iexplore.exe", @"C:\JsonGenerator\index.html");
        }

        abstract public void GenerateJson();

        virtual public void ConvertJsonToJs(string jsonFile, string jsFile)
        {
            string json = File.ReadAllText(jsonFile);
            string js = "var data = " + json;
            File.WriteAllText(jsFile, js);
        }
    }
}
