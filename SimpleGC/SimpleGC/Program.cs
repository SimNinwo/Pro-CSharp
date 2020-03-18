using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** GC Basics ******");

            // Create a new Car object on the managed heap.
            Car refToMyCar = new Car("Zippy", 50);

            // The C# dot operator(.) is used to invoked members on the object using out reference variable
            Console.WriteLine(refToMyCar.ToString());

            Console.ReadLine();
        }
    }
}
