using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam0222
{
    internal class MCQ : question
    {
        public static List<MCQ> AllMCQs = new List<MCQ>();

        public MCQ()
        {
            Console.WriteLine("MCQ Question");
            mark = funmark();
            Console.WriteLine("Please enter question body");
            body = Console.ReadLine();
            AllMCQs.Add(this);
            answers p = new answers(counter, "MCQ");
        }

        public MCQ(int u)
        {
            int objIndex = 0;
            foreach (var mcq in AllMCQs)
            {
                Console.WriteLine($"\nMCQ Object {++objIndex}:");
                Console.WriteLine($"  Q{objIndex}: {mcq.body} Mark: {mcq.mark}");
                answers ty = new answers(0, mcq.mark);


            }

        }
        //Mark: {mcq.mark[i]}


    }
}
