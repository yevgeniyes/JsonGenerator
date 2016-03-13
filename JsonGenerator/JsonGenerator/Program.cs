using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press any key to generate JSON:");
            while (true)
            {
                Console.ReadKey();
                GeneratorBase gb = new GeneratorBase();
                gb.GenerateJson();
                Console.WriteLine(@"C:\JsonGenerator\students.json was generated");
                Console.Write("\nPress any key to generate JSON:");
            }
        }
    }
}
