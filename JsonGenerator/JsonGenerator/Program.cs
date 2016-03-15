using System;

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
                Generator generator = new Generator();
                generator.Execute();
                Console.WriteLine(@"C:\JsonGenerator\students.json was generated");
                Console.Write("\nPress any key to generate JSON:");
            }
        }
    }
}
