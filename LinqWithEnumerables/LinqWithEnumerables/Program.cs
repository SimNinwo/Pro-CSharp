using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithEnumerables
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine();
        }

        static void QueryStringWithOperators()
        {
            Console.WriteLine("***** Using Query Operators *****");

            string[] currentVideosGames = {"Marrowind", "Uncharted 2", "Fallout 3",
                "Daxter", "System Shock 2"};

            var subset = from game in currentVideosGames
                         where game.Contains(" ")
                         orderby game
                         select game;

            foreach (string s in subset)
                Console.WriteLine("Item: {0}", s);
        }

        static void QueryStringsWithEnumerableAndLambdas()
        {
            Console.WriteLine("***** Using Enumerable / Lambda Expressions *****");

            string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3", "Daxter",
                "System Shock 2"};

            // Build a query expression using extension methods
            var subset = currentVideoGames.Where(game => game.Contains(" "))
                                          .OrderBy(game => game)
                                          .Select(game => game);

            // Print results
            foreach (var game in subset)
                Console.WriteLine("Item: {0}", game);
            Console.WriteLine();
            
        }

        // broken down steps of QueryStringsWithEnumerableAndLambdas()
        static void QueryStringsWithEnumerableAndLambdas2()
        {
            string[] currentVideoGAmes = {"Morrowind", "Uncharted 2", "Fallout 3",
                "Daxter", "System Shock 2"};

            // Break it down!
            var gameWithSpaves = currentVideoGAmes.Where(game => game.Contains(" "));
            var orderedGames = gameWithSpaves.OrderBy(game => game);
            var subset = orderedGames.Select(game => game);

            foreach (var game in subset)
                Console.WriteLine("Item: {0}", game);
            Console.WriteLine();
        }

        // Query using anonymous methods
        static void QueryStringsWithAnonymousMethods()
        {
            Console.WriteLine("**** Using Anonymous Methods *****");

            string[] currentVideoGames = {"Morrowind", "Uncharted 2", "Fallout 3",
                "Daxter", "System Shock 2"};

            // Build necessary Func<> delegatees using anonymous method
            Func<string, bool> searchFilter = delegate (string game) { return game.Contains(" "); };
            Func<string, string> itemToProcess = delegate (string s) { return s; };

            // Pass the delegates into the methods of Enumerable.
            var subset = currentVideoGames.Where(searchFilter)
                                          .OrderBy(itemToProcess)
                                          .Select(itemToProcess);

            // Print out results.
            foreach (var game in subset)
                Console.WriteLine("Item: {0}", game);
            Console.WriteLine();
        }
    }
}
