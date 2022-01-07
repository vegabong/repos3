using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {

        static bool isOdd(int n)
        {
            return n % 2 != 0;
        }

        static void Main(string[] args)
        {
            int a;
            int b = 0;

            do
            {
                Console.WriteLine("Enter number: ");
                a = int.Parse(Console.ReadLine());
                if (isOdd(a))
                {
                    b = b + a;
                }
                Console.Clear();
            }
            while (a > 0);

            Console.WriteLine($"Sum of odd numbers: {b}");
            Console.ReadLine();
        }
    }
}
