using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithTuples
{
    class Program
    {


        static void Main(string[] args)
        {
            
            Console.WriteLine("=> Inferred Tuple Names");
            var foo = new { Prop1 = "first", Prop2 = "second" };
            var bar = (foo.Prop1, foo.Prop2);
            Console.WriteLine($"{bar.Prop1};{bar.Prop2}");
            Console.WriteLine();

            var samples = FillTheseValues();
            Console.WriteLine($"Int is: {samples.a}");
            Console.WriteLine($"String is: {samples.b}");
            Console.WriteLine($"Boolean is: {samples.c}");
            Console.WriteLine("Enter Fullname");

            var fullName = Console.ReadLine();
            

            var sample1 = SplitNames(fullName);

            Console.WriteLine($"First name is: {sample1.first}");
            Console.WriteLine($"Middle name is: {sample1.middle}");
            Console.WriteLine($"Last name is: {sample1.last}");
            Console.WriteLine();

            var (first, _, last) = SplitNames(fullName);
            Console.WriteLine($"{first} {last}");


            Console.ReadLine();
        }

        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string.";
            c = true;
        }
        
        static (int a, string b, bool c) FillTheseValues()
        {
            return (9, "Enjoy your string.", true);
        }
        
        // Collects full Name and returns first, middle and last names.
        static (string first, string middle, string last) SplitNames(string fullName)
        {
            // do what is needed to split the name apart
            var fullName1 = fullName.Split(' ');
            var first = fullName1[0];
            var sec = fullName1[1];
            var las = fullName1[2];
            
            return (first, sec, las);
        }

        
    }
}
