using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam0222
{
    internal class answers : question
    {
        string[] answerList;
        int answerid;
        public static int count = -1;
        public static double k = 0;
        public static List<answers> Allans = new List<answers>();

        public answers(int index, string check)
        {
            answerList = new string[6];

            //answerList[index] = new string[4];
            if (check == "MCQ")
            {
                Console.WriteLine("Enter Choices Question");
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Please Enter choice number " + (i + 1));
                    answerList[i] = Console.ReadLine();
                }
                Console.WriteLine("Please Enter The Right Answer ID");
                answerid = Int32.Parse(Console.ReadLine());
                answerList[3] = "e";
            }
            else
            {
                answerid = Int32.Parse(Console.ReadLine());
                answerList[0] = "TRUE";
                answerList[1] = "FALSE";
                answerList[3] = "h";
            }
            Allans.Add(this);
        }
        public answers(int cr, double mm)
        {
            int objIndex = 1;
            count++;
            int flag = 0;
            foreach (var mcq in Allans)
            {
                if (mcq.answerList[3] == "e" && mcq.answerList[5] != "1" && cr == 0)
                {
                    mcq.answerList[5] = "1";
                    Console.WriteLine($"\nMCQ Object {objIndex++}:");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine($"  Q{i + 1}: {mcq.answerList[i]}");
                    }
                    Console.WriteLine("Enter Your Answer ");
                    mcq.answerList[4] = Console.ReadLine();
                    if (Int32.Parse(mcq.answerList[4]) == mcq.answerid)
                        k += mm;
                    break;
                }

                else if (mcq.answerList[5] != "1" && mcq.answerList[3] == "h" && cr == 1)
                {
                    mcq.answerList[5] = "1";
                    Console.WriteLine($"\nMCQ Object {objIndex++}:");
                    for (int i = 0; i < 2; i++)
                    {
                        Console.WriteLine($"  Q{i + 1}: {mcq.answerList[i]}");
                    }
                    Console.WriteLine("Enter Your Answer ");
                    mcq.answerList[4] = Console.ReadLine();
                    if (Int32.Parse(mcq.answerList[4]) == mcq.answerid)
                        k += mm;
                    break;
                }
                flag++;




            }
        }


    }
}
