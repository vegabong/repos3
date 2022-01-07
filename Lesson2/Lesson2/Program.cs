using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;

            if (number < 0)
            {
                Console.WriteLine($"{number} больше нуля");
            }
            else
            {
                Console.WriteLine($"{number} меньше или равен нулю");
            }

            double imt = 18;

            if (imt <= 19.5)
            {
                Console.WriteLine("You have to gain weight");
            }
            else if (imt > 19.5 && imt < 27)
            {
                Console.WriteLine("Your weight is normal");
            }
            else
            {
                Console.WriteLine("You have to lose weight");
            }

            Console.WriteLine("Enter two integers");

            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            int max;

            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b;
            }

            Console.WriteLine($"Maximal integer is {max}");


            max = a > b ? a : b;

            Console.WriteLine("Maximal integer is {0}", a > b ? a : b);
            Console.WriteLine("Maximal integer is {0}", a > b ? a : (a == 1 ? a : b));
            Console.WriteLine("Maximal integer is {0}", a > b ? a : GetNumber(b));

            Console.ReadLine();
        }

        static int GetNumber(int i)
        {
            return i * i;
        }

    }
}
