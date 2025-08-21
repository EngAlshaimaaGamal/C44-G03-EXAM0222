using Exam0222.Answer_one;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam0222.other_Answer
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public Exam exam;

        public Subject() { }
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }
        public Exam CreateExam()
        {

            int time;
            do
            {
                Console.WriteLine("Enter exam duration (minutes):");
            } while (!int.TryParse(Console.ReadLine(), out time) || time <= 0);

            int n;
            do
            {
                Console.WriteLine("Enter number of questions:");
            } while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            int choice;
            do
            {
                Console.WriteLine("Choose Exam Type: 1) Practical  2) Final");
            } while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2));

            if (choice == 1)
            {
                exam = new PracticalExam(n, time);

                PracticalExam practicalExam = (PracticalExam)exam;

                for (int i = 0; i < n; i++)
                {
                    practicalExam.questions[i] = new MCQ_Question();
                }
            }
            else
            {
                exam = new FinalExam(n, time);

                FinalExam finalExam = (FinalExam)exam;

                for (int i = 0; i < n; i++)
                {
                    int qType;
                    do
                    {
                        Console.WriteLine("Choose Question Type: 1) MCQ  2) True/False");
                    } while (!int.TryParse(Console.ReadLine(), out qType) || (qType != 1 && qType != 2));


                    finalExam.questions[i] = (qType == 1) ? new MCQ_Question() : new TF_Question();
                }
            }

            return exam;

        }
    }
}
