using Exam0222.Answer_one;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam0222.other_Answer
{
    internal class PracticalExam : Exam
    {

        public MCQ_Question[] questions;
        public Answer[] answers;

        public PracticalExam(int noOfQuestions, int time) : base(noOfQuestions, time)
        {

            questions = new MCQ_Question[noOfQuestions];
            answers = new Answer[noOfQuestions];
        }
        public override void ShowExam()
        {
            int score = 0;
            int marks = 0;
            DateTime startTime = DateTime.Now;
            for (int i = 0; i < NoOfQuestions; i++)
            {

                questions[i].ShowQuestion();
                int answerId;
                do
                {
                    Console.WriteLine("Enter answer Id:");
                } while (!int.TryParse(Console.ReadLine(), out answerId) ||
                         answerId <= 0 || answerId > questions[i].Answers.Length);

                answers[i] = new Answer(answerId, questions[i].Answers[answerId - 1].AnswerText);

                if (answers[i].AnswerId == questions[i].RightAnswer.AnswerId)
                    score += questions[i].Mark;

                marks += questions[i].Mark;
            }
            DateTime endTime = DateTime.Now;
            Console.Clear();

            Console.WriteLine($"Your score is {score} out of {marks}");
            Console.WriteLine($"Time taken: {Helper.CalcTimeTaken((int)(endTime - startTime).TotalSeconds)} ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("The Right Answers:");
            Console.WriteLine("-----------------------------");
            for (int j = 0; j < NoOfQuestions; j++)
            {
                Console.WriteLine(questions[j].Body);
                Console.WriteLine($"Answer: {questions[j].RightAnswer.AnswerText}");
            }
        }
    }
}
