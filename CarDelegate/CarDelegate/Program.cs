using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Delegates as event enablers *****");

            /// first, make a car object
            Car c1 = new Car("SlugBug", 100, 10);

            /// Now, tell the car which method to call
            /// when it wants to send us messages.
            c1.RegisterWithaCarEngine(CallMeHere);

            // speed up
            Console.WriteLine("**** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
                Console.ReadLine();
            }
        }


        // This is the  target for incoming events.
        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message from Car Object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("*******************************");
        }

        static void CallMeHere(string msg)
        {
            Console.WriteLine("=> Message from Car: {0}", msg);
        }
    }
}
