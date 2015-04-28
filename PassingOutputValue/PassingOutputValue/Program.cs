using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingOutputValue
{
    class NumberManipulator
    {
        public void Swap(out int number)
        {
            int temp = 6;
            number = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            Console.WriteLine("the number value before swapping is : {0}", number);
            NumberManipulator nm = new NumberManipulator();
            nm.Swap(out number);
            Console.WriteLine("the number value after swapping is : {0}", number);
        }
    }
}
