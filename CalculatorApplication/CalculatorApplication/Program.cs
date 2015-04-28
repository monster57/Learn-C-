using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public int FindMax(int number1 , int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            return number2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 100;
            int number2 = 200;
            int max;
            NumberManipulator nm = new NumberManipulator();
            max = nm.FindMax(number1, number2);
            Console.WriteLine("the max variable is {0}", max);
        }
    }
}
