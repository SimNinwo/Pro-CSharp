using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegate
{
    class Program
    {
        /// Generic delegate can represent any method returning void
        /// and taking a single parameter.
        public delegate void MyGenericDelegate<T>(T args);

        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Generic Delegates");

            // generate generic delegate of type string.
            MyGenericDelegate<string> strTarget = new MyGenericDelegate<string>(StringTarget);
            strTarget("Some String data");

            // register delegates
            MyGenericDelegate<int> intTarget = new MyGenericDelegate<int>(IntTarget);
            intTarget(9);

            Console.ReadLine();
        }

        static void StringTarget(string msg)
        {
            Console.WriteLine("arg is in uppercase: {0}", msg.ToUpper());
        }

        static void IntTarget(int args)
        {
            Console.WriteLine("++args is: {0}", ++args);
        }
    }
}
