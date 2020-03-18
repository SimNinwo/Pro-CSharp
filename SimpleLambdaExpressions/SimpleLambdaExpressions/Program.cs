using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Lambda Expressions ****");
            TraditionalDelegateSyntax();
            Console.WriteLine();
            LambdaExpressionSyntax();
            Console.ReadLine();
        }

        static void LambdaExpressionSyntax()
        {
            // Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            // Now, use a C# lambda expression.
            //List<int> evenNumbers = list.FindAll(i => (i % 2) == 0);
            
            //lamba process in multiple statement.
            List<int> evenNumbers = list.FindAll((i) =>
            {
                Console.WriteLine("Value of i is currently {0}", i);
                bool isEven = ((i % 2) == 0);
                return isEven;
            });

            Console.WriteLine("Here are your even numbers");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }

        static void TraditionalDelegateSyntax()
        {
            // Make a list of integers.
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 1, 4, 8, 9, 44 });

            // Call FindAll() using  traditional delegate syntax
            //    Predicate<int> callBack = IsEvenNumber;
            //    List<int> evenNumbers = list.FindAll(callBack);

            // Now, use an anonymous method.
            List<int> evenNumbers = list.FindAll(delegate (int i)
            { return (i % 2) == 0; } );

            Console.WriteLine("Here are your even numbers");
            foreach (int evenNumber in evenNumbers)
            {
                Console.Write("{0}\t", evenNumber);
            }
            Console.WriteLine();
        }

        // Target for the Predicate<> delegate
        //static bool IsEvenNumber(int i)
       // {
            // Is it an even integer?
         //   return (i % 2) == 0;
        //}
    }
}
