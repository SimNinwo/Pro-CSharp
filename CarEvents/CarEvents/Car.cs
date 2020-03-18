using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    public class Car
    {
        // this delegate works in conjunction with Car's events.
        public delegate void CarEngineHandler(string msg);

        // This car can send this events
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;

        // internal state data
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        // Is the car alive or dead?
        private bool carIsDead;

        // Class constructors.
        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }      
        
        // implement the accelerate() method to invoke the delegate.
        public void Accelerate(int delta)
        {
            // if this car is "dead",  send dead message
            if (carIsDead)
            {
                Exploded?.Invoke("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += delta;

                // Is this car "almost dead"?
                if (10 == MaxSpeed - CurrentSpeed)
                {
                    AboutToBlow?.Invoke("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
