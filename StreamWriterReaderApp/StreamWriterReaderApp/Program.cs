using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterReaderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with StreamWriter / StreamReader ****");
            #region StreamWriter...
            // Get a StreamWriter and write string data.
            using (StreamWriter writer = File.CreateText("reminder.txt"))
            {
                writer.WriteLine("Don't forget Mother's Day this year...");
                writer.WriteLine("Don't forget Father's Day this year...");
                writer.WriteLine("Don't forget these numbers:");
                for (int i = 0; i < 10; i++)
                    writer.Write(i + " ");

                // Insert a new line.
                writer.Write(writer.NewLine);
            }
            
            Console.WriteLine("Created file and wrote some thoughts...");
            #endregion

            #region Stream Reader...
            // Now read data from file.
            Console.WriteLine("Here are your thoughts:\n");
            using (StreamReader sr = File.OpenText("reminder.txt"))
            {
                string input = null;
                while ((input = sr.ReadLine()) != null)
                    Console.WriteLine(input);
            }
            #endregion

            Console.ReadLine();
        }
    }
}
