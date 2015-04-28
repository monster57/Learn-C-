using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApplication
{
    class Rectangle
    {
        double length;
        double width;

        public Rectangle(double length , double width)
        {
            this.length = length;
            this.width = width;
        }
        public double GetArea()
        {
            return length * width;

        }
        public void Display()
        {
            Console.WriteLine("Length: {0} ", length);
            Console.WriteLine("width: {0} ", width);
            Console.WriteLine("getArea: {0} ", GetArea());

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(4.5,4.6);
            rectangle.Display();

        }
    }
}
