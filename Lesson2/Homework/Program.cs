using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {

        static int maxNum(int a, int b, int c)
        {
            int max = 0;

            if (a > b && a > c)
            {
                max = a;
            } 
            else if (b > a && b > c)
            {
                max = b;
            }
            else if (c > a && c > b)
            {
                max = c;
            }

            return max;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number");
            int c = int.Parse(Console.ReadLine());


            Console.WriteLine("Biggest number is " + maxNum(a, b, c));

            Console.ReadLine();
        }
    }
}
