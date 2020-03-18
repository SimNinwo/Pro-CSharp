using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point (int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }
        public override string ToString() => $"[{this.X}, {this.Y}]";

        #region addition and subtraction overloading.
        // Overloaded operator +.
        public static Point operator + (Point p1, Point p2) => new Point(p1.X + p2.X, p1.Y + p2.Y);
        
        // Overloaded operator -.
        public static Point operator -(Point p1, Point p2) => new Point(p1.X - p2.X, p1.Y - p2.Y);

        // Overloaded for change adjustment.
        public static Point operator +(Point p1, int change) => new Point(p1.X + change, p1.Y + change);
        public static Point operator +(int change, Point p1) => new Point(p1.X + change, p1.Y + change);
        #endregion

        #region Unary (++ , --) overloading
        // Add 1 to the X/Y values for the incoming point.
        public static Point operator ++(Point p1) => new Point(p1.X + 1, p1.Y + 1);
        // subtract 1 from the X/Y values from the incoming point.
        public static Point operator --(Point p1) => new Point(p1.X - 1, p1.Y - 1);
        #endregion

        #region Overloads == and != operators
        public override bool Equals(object obj) => obj.ToString() == this.ToString();
        public override int GetHashCode() => this.ToString().GetHashCode();

        // lets overload == and != operators
        public static bool operator ==(Point p1, Point p2) => p1.Equals(p2);
        public static bool operator !=(Point p1, Point p2) => !p1.Equals(p2);

        #endregion

        #region overloading comparison operators
        public int CompareTo(Point other)
        {
            if (this.X > other.X && this.Y > other.Y)
                return 1;
            if (this.X < other.X && this.Y < other.Y)
                return -1;
            else
                return 0;
        }

        public static bool operator <(Point p1, Point p2) => p1.CompareTo(p2) < 0;
        public static bool operator >(Point p1, Point p2) => p1.CompareTo(p2) > 0;
        public static bool operator <=(Point p1, Point p2) => p1.CompareTo(p2) <= 0;
        public static bool operator >=(Point p1, Point p2) => p1.CompareTo(p2) >= 0;

        #endregion
    }
}
