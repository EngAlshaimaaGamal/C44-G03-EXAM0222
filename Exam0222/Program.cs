namespace Exam0222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string temp;
            long timee = 0;
            long NumOfQues = 0;



            do
            {
                Console.WriteLine("Please Enter type of the exam (1 for practical | 2 for final)");
                temp = Console.ReadLine();
            }
            while (temp.Replace(" ", string.Empty) != "1" && temp.Replace(" ", string.Empty) != "2");

            int type = Int32.Parse(temp);

            do
            {
                Console.WriteLine("Please Enter time of the exam ");
                temp = Console.ReadLine();
                temp.Replace(" ", string.Empty);
            }
            while (long.TryParse(temp, out timee) == false);

            do
            {
                Console.WriteLine("Please Enter number of questions");
                temp = Console.ReadLine();
                temp.Replace(" ", string.Empty);
            }
            while (long.TryParse(temp, out NumOfQues) == false || NumOfQues <= 0);

            question.numofques = NumOfQues;
            question q1 = new question();
            q1.fun(type);


            Console.WriteLine("Do You Want To Start Exam?  y|n");
            string cc = Console.ReadLine();
            if (cc == "y")
            {
                MCQ Eer = new MCQ((int)NumOfQues);
                trueORfalse tof = new trueORfalse();
                Console.WriteLine("your grade is: " + answers.k);
            }

        }
    }
}
