using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums
{
    /*
    // Begin with 102.
    enum EmpType
    {
        Manager = 102,        
        Grunt,          // = 103
        Contractor,     // = 104
        VicePresident   // = 105
    }
    */

    // This time, EmpType maps to an underlying byte.
    enum EmpType : byte
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VicePresident = 9
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun With Enums ****");
            // Make an EmpType variable.
            EmpType emp = EmpType.Contractor;
            EmpType e2 = EmpType.Contractor;
            AskForBonus(emp);

            // Print storage for the enum.
            Console.WriteLine("EmpType uses a {0} for storage",
                Enum.GetUnderlyingType(emp.GetType()));

            // Prints out "emp is a Contractor".
            Console.WriteLine("emp is a {0}.", emp.ToString());

            // These types are enums in the System namespace.
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;

            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);

            Console.ReadLine();
        }

        // This method will print out the details of any enum.
        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType(). Name);

            Console.WriteLine("Underlying storage type: {0}",
                Enum.GetUnderlyingType(e.GetType()));

            // Get all nume-value pairs for incoming parameter.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);

            // Now show the string name and associated value, using the 0 format
            // flag
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}",
                    enumData.GetValue(i));
            }
            Console.WriteLine();
        }

        // Enums as parameters.
        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You aleady get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }
    }
}
