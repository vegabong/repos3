using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {

        static void Main(string[] args)
        {

            int num = 0;
            int sum = 0;
            int x = 0;
            int y = 2;
            bool flag;
            string s;

            Console.SetCursorPosition(0, 0);
            Console.Write("Sum of odds: ");
            Console.SetCursorPosition(0, y);
            Console.WriteLine("Enter number: ");


            do
            {
                y++;
                Console.SetCursorPosition(x, y);
                s = Console.ReadLine();
                flag = int.TryParse(s, out num);
                if (num % 2 != 0 && num > 0)
                {
                    sum = sum + num;
                }

                Console.SetCursorPosition(13, 0);
                Console.Write(sum);

            }
            while (flag == true && num > 0);
        }
    }
}
