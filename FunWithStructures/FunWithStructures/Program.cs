using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** A First Look at Structures ****");

            // Create an initial Point.
            Point myPoint;
            myPoint.X = 349;
            myPoint.Y = 76;
            myPoint.Display();

            // Adjust the X and Y values.
            myPoint.Increment();
            myPoint.Display();

            Console.ReadLine();
        }

        struct Point
        {
            // Fields of the structure.
            public int X;
            public int Y;

            // Add 1 to the (X, Y) position.
            public void Increment()
            {
                X++; Y++;
            }

            // Subtract 1 from the (X, Y) position.
            public void Decrement()
            {
                X--; Y--;
            }

            // Display the current position.
            public void Display()
            {
                Console.WriteLine("X = {0}, Y = {1}", X, Y);
            }

        }
    }
}
