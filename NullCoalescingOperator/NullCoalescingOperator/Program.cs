using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullCoalescingOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            double? num1 = null;
            double? num2 = 5.44;
            double num3;
            num3 = num1 ?? 5.22;
            Console.WriteLine("Value of num3 is: {0}", num3);
            num3 = num2 ?? 5.66;
            Console.WriteLine("Value of num3 is : {0}", num3);
        }
    }
}
