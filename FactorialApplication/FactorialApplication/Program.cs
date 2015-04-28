using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialApplication
{
    class NumberManipulator
    {
        public int Factorial(int number)
        {
            if (number == 1) return 1;
            else
                return Factorial(number - 1) * number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            NumberManipulator nm = new NumberManipulator();
            Console.WriteLine("the factorial of 8 is {0}", nm.Factorial(8));
            Console.WriteLine("the factorial of 7 is {0}", nm.Factorial(7));
            Console.WriteLine("the factorial of 6 is {0}", nm.Factorial(6));

        }
    }
}
