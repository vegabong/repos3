using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {

        static long digitNum(long a)
        {
            long s = 0;

            while (a > 0)
            {
                s++;
                a = a / 10;
            }

            return s;
        }

        static void Main(string[] args)
        {   
            Console.WriteLine("Enter number ");

            long x = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Number contains " + digitNum(x) + " digits");

            Console.ReadLine();
        }
    }
}
