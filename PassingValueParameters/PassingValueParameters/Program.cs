using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingValueParameters
{
    class NumberManipulator
    {
        public void SwapNumber(int number1 , int number2)
        {
            int swapper;
            swapper = number1;
            number1 = number2;
            number2 = swapper;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 6;
            int number2 = 7;
            NumberManipulator nm = new NumberManipulator();
            Console.WriteLine("Number1 before Swapping : {0}", number1);
            Console.WriteLine("Number2 before Swapping : {0}", number2);

            nm.SwapNumber(number1 , number2);

            Console.WriteLine("Number1 after Swapping : {0}", number1);
            Console.WriteLine("Number2 after Swapping : {0}", number2);


        }
    }
}
