using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace JsonGenerator
{
    class GeneratorBase
    {
        public void GenerateJson()
        {
            if (!Directory.Exists(@"C:\JsonGenerator"))
                Directory.CreateDirectory(@"C:\JsonGenerator");

            if (Directory.Exists(@"C:\JsonGenerator"))
            {
                File.WriteAllText(@"C:\JsonGenerator\index.html", Properties.Resources.index);
                try
                {
                    File.Delete(@"C:\JsonGenerator\students.json");
                }
                catch { }
            }

            Random random = new Random((int)DateTime.Now.Ticks);

            Students student = new Students(Randomizer.GetRandomeName(random), Randomizer.GetRandomSubject(random), Randomizer.GetRandomMark(random));
            Students[] students = new Students[] { student };

            int randomNumber = random.Next(10, 25);
            for (int i = 1; i <= randomNumber; i++)
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
