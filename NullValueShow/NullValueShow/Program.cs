using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValueShow
{
   
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int num2 = 25;
            double? num3 = new double?();
            double num4 = 4.5222;
            bool? boolean = new bool?();

            Console.WriteLine("The values are : {0}, {1}, {2}, {3} ", num1, num2, num3, num4);
            Console.WriteLine("The boolean null value is : {0}", boolean);
        }
    }
}
