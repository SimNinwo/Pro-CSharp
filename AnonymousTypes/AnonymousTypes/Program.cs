using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Anonymous Types *****\n");

            // Make an anonymous type representing a car.
            var myCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };

            // Now show the color and make.
            Console.WriteLine("My car is a {0} {1}.", myCar.Color, myCar.Make);

            // Now call our helper method to build anonymous types via args
            BuildAnonType("BMW", "Black", 90);

            Console.ReadLine();
        }

        static void BuildAnonType(string make, string color, int currSp)
        {
            // Build anon type using incoming args.
            var car = new { Make = make, Color = color, Speed = currSp };
            
            // Note you can use this type to get a property data.
            Console.WriteLine("You have a {0} {1} going {2} MPH", car.Color, car.Make, car.Speed);

            // Anon types have custom implementations of each virtual
            // method of System.Object.
            Console.WriteLine("ToString() == {0}", car.ToString());
        }
    }
}
