using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam0222
{
    internal class final : question
    {
        public int type { get; set; }
        public int counter = 0;

        public final()
        {
            string temp;
            do
            {
                Console.WriteLine("Please Enter type of the question (1 for MCQ | 2 for true of false)");
                temp = Console.ReadLine();
            }
            while (temp.Replace(" ", string.Empty) != "1" && temp.Replace(" ", string.Empty) != "2");

            type = Int32.Parse(temp);
        }

        public void convert()
        {
            if (type == 1)
                _ = new MCQ();
            else
                _ = new trueORfalse(counter);
            counter++;
        }
    }
}
