using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ExtensionMethods
{
    static class MyExtensions
    {
        // This method allows any object to display the assembly
        // its defined in.
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine("{0} lives here: => {1}\n",
                obj.GetType().Name,
                Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }

        // This method allows any integer to reverse its digits.
        public static int ReverseDigits(this int i)
        {
            // Translate int into string, then get all characters
            char[] digits = i.ToString().ToCharArray();

            // now reverse items in array.
            Array.Reverse(digits);

            // put back into string.
            string newDigits = new string(digits);

            // finally return the modified string back as int.
            return int.Parse(newDigits);
        }
    }
}
