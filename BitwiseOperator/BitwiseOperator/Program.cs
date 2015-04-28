using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 8;
            int value = 0;
            value = number << 2;
            Console.WriteLine("this is the result of the use of bitwise operator {0}", value);

        }
    }
}
