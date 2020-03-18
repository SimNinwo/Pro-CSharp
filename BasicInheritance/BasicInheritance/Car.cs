using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Car
    {
        // Fields.
        private readonly int maxSpeed;
        private int currSpeed;

        // Constructors.
        public Car()
        {
            maxSpeed = 55;
        }
        public Car(int max)
        {
            maxSpeed = max;
        }

        public int Speed
        {
            get => speed;
            set
            {
                currSpeed = value;
                if (currSpeed > maxSpeed)
                    currSpeed = maxSpeed;
            }
        }

    }
}
