using Exam0222.other_Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam0222.Answer_one
{
    internal class MCQ_Question : Question
    {

        public MCQ_Question()
        {

            do
            {
                Console.WriteLine("Enter the header of the question");
                Header = Console.ReadLine();
            } while (string.IsNullOrEmpty(Header));


            do
            {
                Console.WriteLine("Enter the body of the question");
                Body = Console.ReadLine();
            } while (string.IsNullOrEmpty(Body));

            int mark;
            do
            {
                Console.WriteLine("Enter the mark for the question:");
            } while (!int.TryParse(Console.ReadLine(), out mark) || mark < 0);
            Mark = mark;

            int choices;
            do
            {
                Console.WriteLine("Enter the number of choices:");
            } while (!int.TryParse(Console.ReadLine(), out choices) || choices < 2);


            Answers = new Answer[choices];

            for (int k = 0; k < choices; k++)
            {
                string choice;
                do
                {
                    Console.WriteLine($"Enter the choice number {k + 1}");
                    choice = Console.ReadLine();
                } while (string.IsNullOrEmpty(choice));

                Answers[k] = new Answer(k + 1, choice);
            }

            int id;
            do
            {
                Console.WriteLine("Enter right answer Id:");
            } while (!int.TryParse(Console.ReadLine(), out id) || id < 1 || id > choices);


            RightAnswer = Answers[id - 1];
        }

        public override void ShowQuestion()
        {
            Console.WriteLine($"Header: {Header}");
            Console.WriteLine($"Body: {Body}");
            Console.WriteLine($"Mark: {Mark}");
            foreach (Answer ans in this.Answers)
            {
                Console.WriteLine($"Answer: {ans.ToString()}");
            }
        }


    }
}
