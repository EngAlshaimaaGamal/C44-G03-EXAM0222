using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam0222.other_Answer
{
    internal class FinalExam : Exam
    {

        public Question[] questions;
        public Answer[] answers;

        public FinalExam(int noOfQuestions, int time) : base(noOfQuestions, time)
        {
            questions = new Question[noOfQuestions];
            answers = new Answer[noOfQuestions];
        }

        public override void ShowExam()
        {
            int score = 0;
            int marks = 0;

            foreach (Question question in questions)
            {
                marks += question.Mark;
            }
            DateTime startTime = DateTime.Now;
            for (int i = 0; i < NoOfQuestions; i++)
            {

                questions[i].ShowQuestion();

                int ans;
                do
                {
                    Console.WriteLine("Enter answer Id:");
                } while (!int.TryParse(Console.ReadLine(), out ans) ||
                         ans <= 0 || ans > questions[i].Answers.Length);

                answers[i] = new Answer(ans, questions[i].Answers[ans - 1].AnswerText);

                if (answers[i].AnswerId == questions[i].RightAnswer.AnswerId)
                    score += questions[i].Mark;


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
