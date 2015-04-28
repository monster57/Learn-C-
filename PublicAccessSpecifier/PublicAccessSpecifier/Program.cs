using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicAccessSpecifier
{
    class Rectangle
    {
        public double length;
        public double width;

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("the length of the rectangle is {0}", length);
            Console.WriteLine("the width of the rectangle is {0}", width);
            Console.WriteLine("the area of the rectangle is {0}", GetArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.length = 5.5;
            rectangle.width = 5.3;
            rectangle.Display();

        }
    }
}
