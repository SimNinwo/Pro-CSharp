using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Class Types ****\n");

            MakeSomeBikes();

            Motorcycle mc = new Motorcycle(5);
            mc.SetDriverName("Tiny");
            mc.PopAWheely();
            Console.WriteLine("Rider name is {0}", mc.driverName );
            Console.WriteLine();

            // Allocate and configure a Car object.
            Car myCar = new Car();

            // Make a Car called Chuck going 10 MPH.
            Car chuck = new Car();
            chuck.PrintState();
            Console.WriteLine();

            // Make a Car called Mary going 0 MPH.
            Car mary = new Car("Mary");
            mary.PrintState();
            Console.WriteLine();

            // Make a car called Daisy going 75 MPH.
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();
            Console.WriteLine();


            myCar.petName = "Henry";
            myCar.currSpeed = 10;

            // Speed up the car a few times and print out new state.
            for (int i = 0; i < 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            Console.WriteLine();

            Console.ReadLine();
        }

        static void MakeSomeBikes()
        {
            // driveName = "", driverIntensity = 0
            Motorcycle m1 = new Motorcycle();
            Console.WriteLine("Name = {0}, Intensity = {1}",
                m1.driverName, m1.driverIntensity);

            // driveName = "Tiny", driverIntensity = 0
            Motorcycle m2 = new Motorcycle(name: "Tiny");
            Console.WriteLine("Name = {0}, Intensity = {1}",
                m2.driverName, m2.driverIntensity);

            // driveName = "", driverIntensity = 7
            Motorcycle m3 = new Motorcycle(7);
            Console.WriteLine("Name = {0}, Intensity = {1}",
                m3.driverName, m3.driverIntensity);
        }
    }
}
