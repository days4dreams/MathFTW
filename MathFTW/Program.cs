using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFTW
{
    class Program
    {
        static void Say(string words)
        {
            Console.WriteLine(words);
        }

        static string Ask(string questions)
        {
            Console.WriteLine(questions);
            string response = Console.ReadLine();

            return response;
        }

        static void WaitForUser()
        {
            Console.ReadKey();
        }


        static void Main(string[] args)
        {

            Say("Let's do some maths");

            string numOne = Ask("Give me the first number you want to use:");
            string numTwo = Ask("Thank you. And give me the second number:");
            string operate = Ask("And finally, the operator ( + - / * ):");

            int one = Int32.Parse(numOne);
            int two = Int32.Parse(numTwo);

            Say(String.Format("Calculating {0} {1} {2}...", numOne, operate, numTwo));

            Console.ReadKey();
        }
    }
}
