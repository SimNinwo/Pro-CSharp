using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUtilityClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is just fine
            TimeUtilClass.PrintDate();
            TimeUtilClass.PrintTime();

            // Complier error! Can't create instance of static classes!
            TimeUtilClass u = new TimeUtilClass();

            Console.ReadLine();
        }
    }
}
