using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Arrays ****");
            SimpleArrays();
            Console.ReadLine();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            // Create and fill an array of 3 Integers
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            // Create a 100 item string array, indexed 0 - 99
            string[] booksOnDotNet = new string[100];

            // Now print each value.
            foreach (int i in myInts)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }

        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialisation.");
            string[] stringArray = new string[]
                {"one", "two", "three"};
            Console.WriteLine("stringArray has {0} elements",
                stringArray.Length);

            // Array initialisation syntax without using new keyword.
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements",
                boolArray.Length);

            // Array initialisation with new keyword and size.
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements",
                intArray.Length);
            Console.WriteLine();
        }

        static void declareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialisation");

            // a is really int[]
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            // b is really double[]
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());

            // c is really string[]
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
        }

        static void ArrayOfObjects()
        {
            // An array of objects can be anything at all.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";

            foreach (object obj in myObjects)
            {
                // Print the type and value for each item in array.
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            // A rectangle MD array.
            int[,] myMatrix;
            myMatrix = new int[3, 4];

            // populate (3 * 4) array.
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;

            // Print (3 * 4) array.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.WriteLine(myMatrix[i, j] + "\t");

                Console.WriteLine();
            }
            Console.WriteLine();

        }

        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");
            // A jagged MD array (i.e., an array of arrays).
            // Have we have an array of % different arrays.
            int[][] myJagArray = new int[5][];

            // Create the Jagged array.
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            // Print each row (remember, each element is defaulted to zero!).
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.WriteLine(myJagArray[i][j] + " ");

                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
