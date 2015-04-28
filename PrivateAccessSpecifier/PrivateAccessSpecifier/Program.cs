using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateAccessSpecifier
{
    class Rectangle
    {
        private double length;
        private double width;

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter withd: ");
            width = Convert.ToDouble(Console.ReadLine());

        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("the Length of the rectangle is {0}", length);
            Console.WriteLine("the width of the rectangle is {0}", width);
            Console.WriteLine("the Area of the rectangle is {0}", GetArea());

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.AcceptDetails();
            rectangle.Display();
        }
    }
}
