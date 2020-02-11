using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // set up Console UI (CUI)
            Console.Title = "My Rocking App";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("*******************************");
            Console.WriteLine("***Welcome to My Rocking App***");
            Console.WriteLine("*******************************");
            Console.BackgroundColor = ConsoleColor.Black;

            // Wait for Enter key to be preessed.
            Console.ReadLine();
            MessageBox.Show("All Done!");
        }
    }
}
