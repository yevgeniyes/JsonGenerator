using System;

namespace JsonGenerator
{
    class Randomizer
    {
        /// <summary>
        /// Returns one of random Names
        /// </summary>
        public static string GetRandomeName(Random random)
        {
            string[] studentsNames = { "Ivanov", "Petrov", "Sidorov", "Vasilev", "Koltsov", "Makarova", "Zubkov", "Evseev", "Kolobkova", "Romanova", "Abramov", "Borisov" };
            string studentName = studentsNames[random.Next(studentsNames.Length)];
            return studentName;
        }

        /// <summary>
        /// Returns one of random Subjects
        /// </summary>
        public static string GetRandomSubject(Random random)
        {
            string[] subjectList = { "Mathematics", "Geometry", "Russian", "English", "Physical Education", "Music", "History", "Geography", "Social Studies", "Physics",
                                    "Literature", "Chemistry", "Philosophy", "Computer science", "Biology", "Nature study", "Economy", "Oratory", "Painting", "Life Safety Fundamentals" };
            string subject = subjectList[random.Next(subjectList.Length)];
            return subject;
        }

        /// <summary>
        /// Returns one of random Marks
        /// </summary>
        public static int GetRandomMark(Random random)
        {
            int mark = random.Next(2, 6);
            return mark;
        }
    }
}
