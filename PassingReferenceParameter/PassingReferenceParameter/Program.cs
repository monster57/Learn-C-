using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingReferenceParameter
{
    class NumberManipulator
    {
        public void Swap(ref int number1 , ref int number2)
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
            Console.WriteLine("this is the value of numnber1 before swapping : {0}", number1);
            Console.WriteLine("this is the value of numnber2 before swapping : {0}", number2);
            NumberManipulator nm = new NumberManipulator();
            nm.Swap(ref number1, ref number2);
            Console.WriteLine("this is the value of numnber1 after swapping : {0}", number1);
            Console.WriteLine("this is the value of numnber2 after swapping : {0}", number2);
        }
    }
}
