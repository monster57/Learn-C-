using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalAccessSpecifier
{
    class Rectangle
    {
        internal double length;
        internal double width;

        double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("the Length of the rectangle is {0}", length);
            Console.WriteLine("the width of the rectangle is {0}", width);
            Console.WriteLine("the area of the rectangle is {0}", GetArea());

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.length = 5.4;
            rectangle.width = 5.2;
            rectangle.Display();
        }
    }
}
