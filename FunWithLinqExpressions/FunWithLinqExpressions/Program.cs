using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Fun with Query Expressions ******\n");

            // This array wil be the basis of our testing...
            ProductInfo[] itemsInStock =
                new[]
                {
                    new ProductInfo{Name = "Mac's Coffee", Description = "Coffee with TEETH", NumberInStock = 24},
                    new ProductInfo{Name = "Milk Maid Milk", Description = "Milk cow's love", NumberInStock = 100},
                    new ProductInfo{Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberInStock = 120},
                    new ProductInfo{Name = "Crunchy Pops", Description = "Cheezy, peppery goodness", NumberInStock = 2},
                    new ProductInfo{Name = "RipOff Water", Description = "From the tap to your wallet", NumberInStock = 100},
                    new ProductInfo{Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!", NumberInStock = 73}
                };


            // We will call various methods here!

            Array objs = GetProjectedSubset(itemsInStock);
            foreach (object o in objs)
                Console.WriteLine(o); // Calls ToString() on each anonymous object
            Console.WriteLine();

            DisplayIntersection();
            Console.WriteLine();

            DisplayUnion();
            Console.WriteLine();

            Console.ReadLine();
        }

        // Use aggregate
        static void AggregateOps()
        {
            double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };

            // Various aggregation examples.
            Console.WriteLine("Max temp: {0}", (from t in winterTemps select t).Max());

            Console.WriteLine("Min temp: {0}", (from t in winterTemps select t).Min());

            Console.WriteLine("Average temp: {0}", (from t in winterTemps select t).Average());

            Console.WriteLine("Sum of all temps: {0}", (from t in winterTemps select t).Sum());

        }

        // Removing duplicates caused by concat() method using Distinct().
        static void DisplayConcatNoDups()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carConcat = (from c in myCars select c).Concat(from c2 in yourCars select c2);

            // Prints: Yugo Aztec BMW Saab.
            foreach (string s in carConcat.Distinct())
                Console.WriteLine(s);
        }

        // using Concat() method in linq query
        static void DisplayConcat()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carConcat = (from c in myCars select c).Concat(from c2 in yourCars select c2);

            // Prints: Yugo Aztec BMW BMW Saab Aztec.
            foreach (string s in carConcat)
                Console.WriteLine(s);
        }

        // using Union() method in linq query.
        static void DisplayUnion()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            // Get Union of these characters.
            var carUnion = (from c in myCars select c).Union(from c2 in yourCars select c2);

            Console.WriteLine("Here is everything:");
            foreach (string s in carUnion)
                Console.WriteLine(s); // Prints all common members
        }

        // using Intersect() method in linq query.
        static void DisplayIntersection()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            // Get the common members.
            var carIntersect = (from c in myCars select c)
                               .Intersect(from c2 in yourCars select c2);

            Console.WriteLine("Here's what we have in common:");
            foreach(string s in carIntersect)
                Console.WriteLine(s); // Prints Aztec and BMW.
        }

        // using Except() method in linq query
        static void DisplayDiff()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carDiff = (from c in myCars select c).Except(from c2 in yourCars select c2);

            Console.WriteLine("Here is what you dont have, but I do:");
            foreach (string s in carDiff)
                Console.WriteLine(s); // prints Yugo.
        }

        static void AlphabetizeProductNames(ProductInfo[] product)
        {
            // Get names of products, alphabetized.
            var subset = from p in product orderby p.Name select p;

            Console.WriteLine("Ordered by Name:");
            foreach (var p in subset)
                Console.WriteLine(p.ToString());
        }

        static void ReverseEverything(ProductInfo[] products)
        {
            Console.WriteLine("Product in Reverse:");
            var allProducts = from p in products select p;

            foreach(var prod in allProducts.Reverse())
                Console.WriteLine(prod.ToString());
        }

        // get string objects with characters greater than 6
        static void GetCountFromQuery()
        {
            string[] currentVideoGames = { "Marrowind", "Uncharted 2", "Fallout 3", 
                "Daxter", "System Shock 2" };

            // Get count from query.
            int numb = (from g in currentVideoGames where g.Length > 6 select g).Count();

            // Print out the number of items.
            Console.WriteLine("{0} items honor the LINQ query", numb);
        }

        static Array GetProjectedSubset(ProductInfo[] products)
        {
            var nameDesc = from p in products select new { p.Name, p.Description };

            // Map anonymous objects to an array
            return nameDesc.ToArray();
        }

        static void GetNamesAndDescriptions(ProductInfo[] products)
        {
            Console.WriteLine("Names and Descriptions:");
            var nameDesc = from p in products select new { p.Name, p.Description };

            // Display
            foreach (var item in nameDesc)
                Console.WriteLine(item.ToString());
        }

        static void GetOverStock(ProductInfo[] products)
        {
            Console.WriteLine("The Overstock Items");

            // Get items where we have over 25 in stock.
            var overstock = from p in products where p.NumberInStock > 25 select p;

            // Display overstock items
            foreach(var os in overstock)
                Console.WriteLine(os.ToString());
        }

        static void ListPRoductNames(ProductInfo[] product)
        {
            Console.WriteLine("Only Product Names");
            var names = from p in product select p.Name;

            foreach( var n in names)
                Console.WriteLine("Name: {0}", n);
        }

        static  void SelectEverything(ProductInfo[] product)
        {
            Console.WriteLine("All PRoduct details:");
            var allProducts = from p in product select p;

            foreach (var prod in allProducts)
                Console.WriteLine(prod.ToString());
        }
    }
}
