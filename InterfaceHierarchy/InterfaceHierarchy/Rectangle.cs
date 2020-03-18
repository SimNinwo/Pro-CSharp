using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    class Rectangle : IShape
    {
        void IPrintable.Draw()
        {
            // Draw to printer ...
            Console.WriteLine("Drawing...");
        }

        void IDrawable.Draw()
        {
            // Draw to screen ...
            Console.WriteLine("Drawing...");
        }

        public int GetNumberOfSides()
        {
            return 4;
        }

        public void Print()
        {
            // Printing ...
            Console.WriteLine("Printing...");
        }
    }
}
