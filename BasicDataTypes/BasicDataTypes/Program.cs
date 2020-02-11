using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalVarDeclarations();

            DefaultDeclarations();

            NewingdataTypes();

            DigitSeparators();

            StringInterpolation();
            // Wait for user to press the Enter key before shutting down.
            Console.ReadLine();
        }

        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            // Local variables are declared as so:
            // dataTypes varName = initialvalue;
            int myInt = 0;

            // You can also declare and assign on two lines
            string myString;
            myString = "This is my character data";

            // Declare 3 bools on a single line.
            bool b1 = true, b2 = false, b3 = b1;

            // Use System.Boolean data type to declare a bool.
            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
                myInt, myString, b1, b2, b3, b4);

            Console.WriteLine();
        }

        static void DefaultDeclarations()
        {
            Console.WriteLine("=> Default Declarations:");
            int myInt = default;

            Console.WriteLine("default int: {0}", myInt);
        }

        static void NewingdataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");
            bool b = new bool();            // Set to false.
            int i = new int();              // Set to 0.
            double d = new double();        // Set to 0.
            DateTime dt = new DateTime();   // Set to 1/1/0001 12:00:00 AM
            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }

        static void DigitSeparators()
        {
            Console.WriteLine("=> Use Digit Separators:");
            Console.Write("Integer:");
            Console.WriteLine(123_456);
            Console.Write("Long:");
            Console.WriteLine(123_456_789L);
            Console.Write("Float:");
            Console.WriteLine(123_456.1234F);
            Console.Write("Double:");
            Console.WriteLine(123_456.12);
            Console.Write("Decimal:");
            Console.WriteLine(123_456.12M);

            Console.WriteLine();
        }

        static void StringInterpolation()
        {
            // Some local variables we will plug into our larger string
            int age = 4;
            string name = "Soren";

            // Using curly bracket syntax.
            string greeting = string.Format("Hello {0} you are {1} years old.",
                name.ToUpper(), age);

            // Using string interpolation
            string greeting2 = $"Hello {name} you are {age} years old.";
            Console.WriteLine(greeting);
            Console.WriteLine(greeting2);
            Console.WriteLine();
        }

        static void SwitchOnEnumExample()
        {
            Console.WriteLine("Enter your favourite day of the week: ");
            DayOfWeek favDay;

            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch(Exception)
            {
                Console.WriteLine("Bad input!");
                return;
            }

            switch (favDay)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it is not Monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day.");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday...");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed.");
                    break;

            }
            Console.WriteLine();
        }
    }


}
