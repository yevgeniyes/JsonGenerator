using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonGenerator
{
    class Randomizer
    {
        public static string GetRandomeName(Random random)
        {
            string[] studentsNames = { "Ivanov", "Petrov", "Sidorov", "Vasilev", "Koltsov", "Makarova", "Zubkov", "Ignatov", "Kolobkova", "Kanatnikov" };
            string studentName = studentsNames[random.Next(10)];
            return studentName;
        }

        public static string GetRandomSubject(Random random)
        {
            string[] subjectList = { "Mathematics", "Geometry", "Russian", "English", "Physical Education", "Music", "History", "Geography", "Social Studies", "Physics",
                                    "Literature", "Chemistry", "Philosophy", "Computer science", "Biology", "Nature study", "Economy", "Oratory", "Painting", "Life Safety Fundamentals" };
            string subject = subjectList[random.Next(20)];
            return subject;
        }

        public static int GetRandomMark(Random random)
        {
            int mark = random.Next(2, 6);
            return mark;
        }
    }
}
