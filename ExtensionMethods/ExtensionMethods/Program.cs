﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Extension Methods****\n");

            // This int has assumed a new identity!
            int myInt = 12345678;
            myInt.DisplayDefiningAssembly();

            // so has the dataset!
            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDefiningAssembly();

            // And the SoundPlayer.
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.DisplayDefiningAssembly();
            Console.WriteLine();

            // Use new integer functionality.
            Console.WriteLine("Value of myInt: {0}", myInt);
            Console.WriteLine("Reversed Digits of myInt: {0}", myInt.ReverseDigits());

            Console.ReadLine();

        }
    }
}
