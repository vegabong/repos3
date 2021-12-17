using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"{res:f}");

            Console.ReadLine();
        }
    }
}
