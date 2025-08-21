using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam0222
{
    internal class question : exam
    {
        public int size;
        public string header;
        public string body;
        public double mark;
        public int counter = 0;
        public question()
        {
            size = (int)numofques;
        }


        public double funmark()
        {
            string temp;
            double m = 0;

            do
            {
                Console.WriteLine("Enter Question Mark");
                temp = Console.ReadLine();
                temp.Replace(" ", string.Empty);

            }
            while (double.TryParse(temp, out m) == false || m <= 0);
            return m;
        }




        public void fun(int type)
        {
            for (int i = 0; i < size; i++, counter++)
            {
                if (type == 1)
                {
                    practical pp = new practical();
                    pp.convert();
                }
                else
                {
                    final ff = new final();
                    ff.convert();
                }
            }
        }

    }
}
