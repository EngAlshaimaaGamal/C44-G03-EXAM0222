using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam0222.other_Answer
{
    abstract internal class Exam
    {
        public int Time { get; set; }
        public int NoOfQuestions { get; set; }

        public Exam(int numOfQuestions, int time)
        {
            this.Time = time;
            this.NoOfQuestions = numOfQuestions;
        }
        abstract public void ShowExam();
    }
}
