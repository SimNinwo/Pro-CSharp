using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FunWithCSharpAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(" Fun With Async ===>");
            // This is to prompt Visual Studio to upgrade project to C# 7.1
            string message = await DoWOrkAsync();
            Console.WriteLine(message);
            Console.WriteLine(DoWork());
            Console.WriteLine("Completed");
            Console.ReadLine();
        }

        static string DoWork()
        {
            Thread.Sleep(5_000);
            return "Done with work!";
        }

        static async Task<string> DoWOrkAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5_000);
                return "Done with work!";
            });
        }
    }
}
