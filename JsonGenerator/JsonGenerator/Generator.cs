using System;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace JsonGenerator
{
    class Generator
    {
        public void Execute()
        {
            ProgramInitialization.Initialize();
            GenerateJson();
            ConvertJsonToJs(@"C:\JsonGenerator\students.json", @"C:\JsonGenerator\students.js");
        }
        /// <summary>
        /// Generates json file with random number of objects and random data: students.json file and index.html are located in C:\JsonGenerator\
        /// </summary>
        private void GenerateJson()
        {
            Random random = new Random((int)DateTime.Now.Ticks);

            Students student = new Students(Randomizer.GetRandomeName(random), Randomizer.GetRandomSubject(random), Randomizer.GetRandomMark(random));
            Students[] students = new Students[] { student };

            for (int i = 1; i <= 100; i++)
            {
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = new Students(Randomizer.GetRandomeName(random), Randomizer.GetRandomSubject(random), Randomizer.GetRandomMark(random));
            }

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Students[]));
            using (FileStream stream = new FileStream(@"C:\JsonGenerator\students.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(stream, students);
            }
        }

        private void ConvertJsonToJs(string jsonFile, string jsFile)
        {
            string json = File.ReadAllText(jsonFile);
            string js = "var data = " + json;
            File.WriteAllText(jsFile, js);
        }
    }

    [DataContract]
    public class Students
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public int Mark { get; set; }

        public Students(string name, string subject, int mark)
        {
            Name = name;
            Subject = subject;
            Mark = mark;
        }
    }
}
