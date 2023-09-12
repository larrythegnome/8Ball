using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Ball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Magic Eight ball: Ask a question...");
            Console.ReadLine();

            Random random = new Random();
            int randomNumber = random.Next(1, 9);

            string answer = "";

            switch (randomNumber)
            {
                case 1:
                    answer = "It is certain.";
                    break;
                case 2:
                    answer = "Reply hazy, try again.";
                    break;
                case 3:
                    answer = "Dont count on it.";
                    break;
                case 4:
                    answer = "Yes, definitely.";
                    break;
                case 5:
                    answer = "You may relt on it.";
                    break;
                case 6:
                    answer = "As I see it, yes.";
                    break;
                case 7:
                    answer = "Most likely.";
                    break;
                case 8:
                    answer = "Outlook not so good.";
                    break;
            }

            Console.WriteLine($"Magic Eight Ball says: {answer}");

            bool keepPlaying = true;

            while (keepPlaying)
            {
                Console.WriteLine("\nMagic Eight Ball: Ask a question (or type 'exit' to quit)...");
                string question = Console.ReadLine();

                if (question.ToLower() == "exit")
                {
                    keepPlaying = false;
                    break;
                }

                int randomNumber = random.Next(1, 9);

                Console.WriteLine($"Magic Eight Ball says: {answer}");
            }
        }

    }
}
