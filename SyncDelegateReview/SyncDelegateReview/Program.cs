using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SyncDelegateReview
{
    public delegate int BinaryOps(int x, int y);

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("***** Synch Delegate Review *****");

            // Print out the ID of the executing thread
            Console.WriteLine("Main() invoked on thread {0}.",
                Thread.CurrentThread.ManagedThreadId);

            // Invoke Add() in a synchronous manner.
            BinaryOps b = new BinaryOps(Add);

            // Could also write b.Invoke(10,10);
            int answer = b(10, 10);

            // These lines will not execute until
            // the Add() method has completed.
            Console.WriteLine("Doing more work in Main()!");
            Console.WriteLine("10 + 10 is {0}.", answer);

            Console.WriteLine();
            Console.WriteLine("***** Async Delegate Invocation******");

            // Print out the ID of the executing thread.
            Console.WriteLine("Main() invoked on thread {0}.",
                Thread.CurrentThread.ManagedThreadId);

            // Invoke Add() on a secondary thread.
            //BinaryOps b = new BinaryOps(Add);
            IAsyncResult ar = b.BeginInvoke(10, 10, null, null);

            // Do other work on primary thread...
            while (!ar.IsCompleted)
            {
                Console.WriteLine("Doing more work in Main()!");
                Thread.Sleep(1000);
            }
            
            // Obtain the result of the Add()
            // method when ready.
            int ans = b.EndInvoke(ar);
            Console.WriteLine("10 + 10 is {0}.", ans);



            Console.ReadLine();
        }

        static int Add(int x, int y)
        {

            Console.WriteLine("Add() invoked on thread {0}",
                Thread.CurrentThread.ManagedThreadId);

            // Pause to simulate a lengthy operation.
            Thread.Sleep(5000);
            return x + y;
        }
    }
}
