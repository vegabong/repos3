using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[20]; //{ 9, 6, -2, 3, -3, -4, 2, 9, -10, 3, 7, -6, 10, 0, 3, 9, -3, 5, -1, -3 };

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10000, 10001);

                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            int j = 0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if ((arr[i] % 3 == 0 && arr[i+1] % 3 != 0) || (arr[i] % 3 != 0 && arr[i + 1] % 3 == 0))
                {
                    j++;
                }
            }

            Console.WriteLine($"Amount of pairs: " + j);

            Console.ReadKey();
        }
    }
}
