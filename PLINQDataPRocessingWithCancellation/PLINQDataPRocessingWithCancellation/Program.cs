using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PLINQDataPRocessingWithCancellation
{
    class Program
    {
        static CancellationTokenSource cancelToken = new CancellationTokenSource();
        static void Main(string[] args)
        {
            /*Console.WriteLine("Start any key to start processing");
            Console.ReadKey();

            Console.WriteLine("Processing");
            Task.Factory.StartNew(() => ProcessIntData());
            */
            do
            {
                Console.WriteLine("Start any key to start processing");
                Console.ReadKey();

                Console.WriteLine("Processing");
                Task.Factory.StartNew(() => ProcessIntData());
                Console.Write("ENter Q to quit: ");
                string answer = Console.ReadLine();
                // Does user want to quit?
                if (answer.Equals("Q", StringComparison.OrdinalIgnoreCase))
                { 
                    cancelToken.Cancel(); 
                    break; 
                }
            } while (true);
            Console.ReadLine();
        }

        static void ProcessIntData()
        {
            // Get a very large array of integers.
            int[] source = Enumerable.Range(1, 10_000_000).ToArray();
            // find the numbers where num % 3 == 0
            // return in decending order.
            int[] modTHreeIsZero = null;
            try
            {
                modTHreeIsZero = (from num in source.AsParallel()
                                  where num % 3 == 0
                                  orderby num descending
                                  select num).ToArray();
                Console.WriteLine();
                Console.WriteLine($"Found {modTHreeIsZero.Count()} numbers that match query");
            }
            catch (OperationCanceledException ex)
            {

                Console.WriteLine(ex.Message);
            }
                
        }
    }
}
