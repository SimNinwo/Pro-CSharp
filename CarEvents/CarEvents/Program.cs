using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Func with Events *****");

            Car bmw = new Car("Accord", 100, 10);

            bmw.AboutToBlow += CarIsAlmostDoomed;
            bmw.AboutToBlow += CarAboutToBlow;
            EventHandler<CarEventArgs> d = new EventHandler<CarEventArgs>(CarExploded);
            bmw.Exploded += d;

            Console.WriteLine("***** Speeding Up *****");
            for (int i = 0; i < 20; i++)
                bmw.Accelerate(10);
            
            bmw.Exploded -= CarExploded;

            Console.ReadLine();
                      
        }

        #region Event handlers
        public static void CarAboutToBlow(object sender, CarEventArgs e)
        { 
            if (sender is Car c)
            Console.WriteLine("{0} says: {1}", c.PetName, e.msg); }
        public static void CarIsAlmostDoomed(object sender, CarEventArgs e)
        { Console.WriteLine("=> Critical Message from {1}: {0}", e.msg, sender); }
        public static void CarExploded(object sender, CarEventArgs e)
        { Console.WriteLine("{0} says: {1}", sender, e.msg); }
        #endregion
               
    }
}
