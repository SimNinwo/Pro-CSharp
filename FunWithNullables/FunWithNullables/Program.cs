using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithNullables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun With Nullable Data ****");
            DatabaseReader dr = new DatabaseReader();

            // Get int from 'database'
            int? i = dr.GetIntFromDatabase();
            if (i.HasValue)
                Console.WriteLine("Value of 'i' is: {0}", i.Value);
            else
                Console.WriteLine("Value of 'i' is undefined.");

            // Get bool from 'database'.
            bool? b = dr.GetBoolFromDatabase();
            if (b != null)
                Console.WriteLine("Value of 'b' is: {0}", b.Value);
            else
                Console.WriteLine("value of 'b' is undefined.");

            Console.WriteLine();
            // If the value from GetIntFromDatabase() is null,
            // assign local variable to 100.
            int myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine("Value of myData: {0}", myData);
            // Long-hand notation not using ?? syntax
            int? moreData = dr.GetIntFromDatabase();
            if (!moreData.HasValue)
                moreData = 100;
            Console.WriteLine("Value of moreData: {0}", moreData);
            Console.ReadLine();
        }

        

    }

    class DatabaseReader
    {
        // Nullable data field.
        public int? numericValue = null;
        public bool? boolValue = true;

        // Note the nullable return type.
        public int? GetIntFromDatabase()
        { return numericValue; }

        public bool? GetBoolFromDatabase()
        { return boolValue; }
    }

}
