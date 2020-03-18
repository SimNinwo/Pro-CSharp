using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console I/O *****");
            GetUserData();
            Console.WriteLine();
            DisplayMessage();

            // Wait for user to press the Enter key before shutting down.
            Console.ReadLine();
        }

        private static void GetUserData()
        {
            // Get name and age.
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            string userAge = Console.ReadLine();

            // Change echo color, just for fun.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;

            // Echo to the console.
            Console.WriteLine("Hello {0}! You are {1} years old.",
                userName, userAge);

            // Restore  previous color.
            Console.ForegroundColor = prevColor;
        }

        static void DisplayMessage()
        {
            // Using string.Format() to format a string literal.
            string userMessage = string.Format("100000 in hex is {0:x}",
                100000);

            // You need to reference PresentationFrameworl.dll
            // in order to compile this line of code!
            System.Windows.MessageBox.Show(userMessage);
        }
    }
}
