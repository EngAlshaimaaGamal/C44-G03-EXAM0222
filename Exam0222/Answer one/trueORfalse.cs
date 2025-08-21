using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam0222
{
    internal class trueORfalse : question
    {
        public static List<trueORfalse> Alls = new List<trueORfalse>();

        public trueORfalse(int counter)
        {
            Console.WriteLine("True or False Question");
            mark = funmark();
            Console.WriteLine("Please enter question body");
            body = Console.ReadLine();
            Alls.Add(this);
            Console.WriteLine("Please enter the right answer id (1 for true | 2 for false");

            answers o = new answers(counter, "TF");

        }

        public trueORfalse()
        {
            int objIndex = 0;
            foreach (var mcq in Alls)
            {
                Console.WriteLine($"\nMCQ Object {++objIndex}:");
                Console.WriteLine($"  Q{objIndex}: {mcq.body} Mark: {mcq.mark}");
                answers ty = new answers(1, mcq.mark);

            }
        }
    }
}
