using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with LINQ to Objects *****\n");
            //QueryOverStrings();
            QueryOverInts();
            ImmediateExecution();

            Console.ReadLine();
        }

        static void ImmediateExecution()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 4, 8 };

            // Get data RIGHT NOW as int[].
            int[] subsetAsIntArray = (from i in numbers where i < 10 select i).ToArray<int>();

            // Get data RIGHT NOW as List<int>.
            List<int> subsetAsListOfInts = (from i in numbers where i < 10 select i).ToList<int>();

            Console.WriteLine(subsetAsIntArray);
            foreach (var i in subsetAsIntArray)
                Console.WriteLine("Item: {0}", i);
            
            Console.WriteLine();

            Console.WriteLine(subsetAsListOfInts);
            foreach (var i in subsetAsListOfInts)
                Console.WriteLine("Item: {0}", i);
        }

        static void QueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

            // Print only items less than 10.
            IEnumerable<int> subset = from i in numbers where i < 10 select i;
            
            #region implicit typing LINQ query
            
            // Use implicit typing here...
            var subsets = from i in numbers where i < 10 select i;
            
            // ...and here.
            foreach (var i in subsets)
                Console.WriteLine("Item: {0}", i);
            Console.WriteLine();
            #endregion

            foreach (int i in subset)
                Console.WriteLine("Item: {0}", i);
        }
        static void QueryOverStringsWithExtensionMethods()
        {
            // Assume we have an array of strings.
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3",
                "Daxter", "System Shock 2"};

            // Build a query expression to find the items in the array
            // that have an embedded space.
            IEnumerable<string> subset = 
                currentVideoGames.Where(games => games.Contains(" ")).OrderBy(games => games).Select(games => games);

            // Print out the results.
            foreach (string s in subset)
                Console.WriteLine("Item: {0}", s);
        }
        static void QueryOverStrings()
        {
            // Assume we have an array of strings.
            string[] currentVideoGames =
            { "Morrowind", "Uncharted 2", "Fallout 3",
                "Daxter", "System Shock 2"
            };

            // Build a query expression to find the items in the array
            IEnumerable<string> subset = from g in currentVideoGames
                                         where g.Contains(" ")
                                         orderby g
                                         select g;

            // Print out the results.
            foreach(string s in subset)
                Console.WriteLine("Item: {0}", s);
        }
    }
}
