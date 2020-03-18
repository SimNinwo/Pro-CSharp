using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenericMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Generic Methods *****\n");

            // Swap 2 ints.
            int a = 10, b = 90;
            Console.WriteLine("Before swap: {0}, {1}", a,b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After swap: {0}, {1}", a, b);
            Console.WriteLine();

            // Swap two strings.
            string s1 = "Hello", s2 = "There";
            Console.WriteLine("Before swap: {0} {1}!", s1, s2);
            Swap<string>(ref s1, ref s2);
            Console.WriteLine("After swap: {0} {1}!", s1, s2);

            Console.ReadLine();
        }

        // Swap two integers
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Swap two person objects.
        static void Swap(ref Person a, ref Person b)
        {
            Person temp = a;
            a = b;
            b = temp;
        }

        // THis method will swap any two items, as specified by type parameter <T>
        static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the swap() method a {0}", typeof(T));
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
