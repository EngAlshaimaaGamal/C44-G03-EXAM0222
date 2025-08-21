using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam0222.other_Answer
{
    internal class Answer : IComparable<Answer>
    {
        public int AnswerId { get; set; }

        public string AnswerText { get; set; }

        public Answer()
        {

        }
        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public override string ToString()
        {
            return $"{AnswerId}){AnswerText}";
        }

        public int CompareTo(Answer? other)
        {
            return AnswerId.CompareTo(other.AnswerId);
        }
    }
}
