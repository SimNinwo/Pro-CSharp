using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        // new member to represent the name of the driver.
        public string driverName;

        // Put back the default constructor, which will
        // set all data members to default values.
        
        public Motorcycle(int intensity = 0, string name = "")
        {
            if (intensity > 10)
                intensity = 10;
            driverIntensity = intensity;
            driverName = name;
        }
        
        /*
        // Constructor chaining.
        public Motorcycle() {
            Console.WriteLine("In default ctor");
        }
        public Motorcycle(int intensity)
            : this(intensity, "") {
            Console.WriteLine("In ctor raking an int");
        }
        public Motorcycle(string name)
            : this (0, name) {
            Console.WriteLine("in ctor taking a string");
        }
        
        // This is the 'master' constructor that does all the real work.
        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("In master ctor ");
            if (intensity > 10)
                intensity = 10;
            driverIntensity = intensity;
            driverName = name;
        }
        */
        /*
        // Our custom constructor.
        public Motorcycle(int intensity)
        {
            SetIntensity(intensity);
        }

        public Motorcycle(int intensity, string name)
        {
            SetIntensity(intensity);
            driverName = name;
        }

        public void SetIntensity(int intensity)
        {
            if (intensity > 10)
                intensity = 10;
            driverIntensity = intensity;
        }
        */


        public void PopAWheely()
        {
            for (int i = 0; i < driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaaeeeewww!");
            }

        }

        public void SetDriverName(string name)
        {
            this.driverName = name;
        }

    }

}

