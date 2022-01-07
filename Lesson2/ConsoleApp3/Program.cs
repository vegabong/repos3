using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int counter = 0;

            do
            {
                Console.WriteLine("Enter number from 0 to 100 ");
                number = int.Parse(Console.ReadLine());
                counter++;
            }
            while (number >= 0 && number <= 100);

            Console.WriteLine($"You did {counter} entries");

            counter = 0;

            while(counter < 10)
            {
                Console.Write($"{counter}    ");
                counter++;
            }

            Console.WriteLine();
            Console.WriteLine();

            // for (инициализация, условия, итерации)
            //{
            //}


            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i}    ");
            }

            counter = 0;

            while(true)
            {
                counter++;
                if (counter > 10)
                {
                    break;
                }
            }

            counter = 0;

            for (; ; )
            {
                counter++;
                if (counter > 10)
                {
                    break;
                }
            }
            
            int a = 12;
            char c = 'H';
            string str = "Hello!";

            Console.WriteLine();

            counter = 0;

            foreach(char e in str)
            {
                Console.WriteLine(e + " - " + counter);
                counter++;
            }



            Console.ReadLine();


        }
    }
}
