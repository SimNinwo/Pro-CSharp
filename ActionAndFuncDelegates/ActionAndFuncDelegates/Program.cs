using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionAndFuncDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Action and Func *****");

            Action<string, ConsoleColor, int> actionTarget = new Action<string, ConsoleColor, int>(DisplayMessage);
            actionTarget("Action Message", ConsoleColor.Yellow, 5);
            Console.WriteLine();

            Func<int, int, int> funcTarget = Add;
            int result = funcTarget.Invoke(40, 40);
            Console.WriteLine("40 + 40 = {0}", result);
            Console.WriteLine();

            Func<int, int, string> funcTarget2 = SumToString;
            string sum = funcTarget2.Invoke(90, 300);
            Console.WriteLine(sum);

            Console.ReadLine();
        }

        // target for func delegate
        static int Add(int x, int y)
        {
            return (x + y);
        }

        static string SumToString(int x, int y)
        {
            return (x + y).ToString();
        }

        static void DisplayMessage(string msg, ConsoleColor txtColor, int printCount)
        {
            // set console color text.
            ConsoleColor previous = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;

            for (int i = 0; i < printCount; i++)
            {
                Console.WriteLine(msg);
            }

            // restore color.
            Console.ForegroundColor = previous;
        }
    }
}
