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
            int studentsNumber;
            string studentName = null;

            studentsNumber = random.Next(1, 11);

            switch (studentsNumber)
            {
                case 1:
                    studentName = "Ivanov";
                    break;
                case 2:
                    studentName = "Petrov";
                    break;
                case 3:
                    studentName = "Sidorov";
                    break;
                case 4:
                    studentName = "Vasilev";
                    break;
                case 5:
                    studentName = "Koltsov";
                    break;
                case 6:
                    studentName = "Makarova";
                    break;
                case 7:
                    studentName = "Zubkov";
                    break;
                case 8:
                    studentName = "Ignatov";
                    break;
                case 9:
                    studentName = "Kolobkova";
                    break;
                case 10:
                    studentName = "Kanatnikov";
                    break;
            }
            return studentName;
        }

        public static string GetRandomSubject(Random random)
        {
            int subjectNumber;
            string subject = null;

            subjectNumber = random.Next(1, 21);

            switch (subjectNumber)
            {
                case 1:
                    subject = "Mathematics";
                    break;
                case 2:
                    subject = "Geometry";
                    break;
                case 3:
                    subject = "Russian";
                    break;
                case 4:
                    subject = "English";
                    break;
                case 5:
                    subject = "Physical Education";
                    break;
                case 6:
                    subject = "Music";
                    break;
                case 7:
                    subject = "History";
                    break;
                case 8:
                    subject = "Geography";
                    break;
                case 9:
                    subject = "Social Studies";
                    break;
                case 10:
                    subject = "Physics";
                    break;
                case 11:
                    subject = "Literature";
                    break;
                case 12:
                    subject = "Chemistry";
                    break;
                case 13:
                    subject = "Philosophy";
                    break;
                case 14:
                    subject = "Computer science";
                    break;
                case 15:
                    subject = "Biology";
                    break;
                case 16:
                    subject = "Nature study";
                    break;
                case 17:
                    subject = "Economy";
                    break;
                case 18:
                    subject = "Oratory";
                    break;
                case 19:
                    subject = "Painting";
                    break;
                case 20:
                    subject = "Life Safety Fundamentals";
                    break;
            }
            return subject;
        }

        public static int GetRandomMark(Random random)
        {
            int markNumber;
            int mark = 0;

            markNumber = random.Next(2, 6);

            switch (markNumber)
            {
                case 2:
                    mark = 2;
                    break;
                case 3:
                    mark = 3;
                    break;
                case 4:
                    mark = 4;
                    break;
                case 5:
                    mark = 5;
                    break;
            }
            return mark;
        }
    }
}
