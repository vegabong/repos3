using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        static void Task1()
        {
            Console.WriteLine("Task1 ...");
        }

        static void Task2()
        {
            Console.WriteLine("Task2 ...");
        }

        static void Task3()
        {
            Console.WriteLine("Task3 ...");
        }

        static void Main(string[] args)
        {

            Console.WriteLine("1 - Task1");
            Console.WriteLine("2 - Task2");
            Console.WriteLine("3 - Task3");
            Console.WriteLine("0 - Quit application");
            Console.WriteLine("===============");

            //int taskNumber = 0;

            //do
            //{
            //    Console.Write("Enter task number: ");
            //    taskNumber = int.Parse(Console.ReadLine());

            //    switch (taskNumber)
            //    {
            //        case 0:
            //            Console.WriteLine("Quitting application on user request");
            //            break;
            //        case 1:
            //            Task1();
            //            break;
            //        case 2:
            //            Task2();
            //            break;
            //        case 3:
            //            Task3();
            //            break;
            //        default:
            //            Console.WriteLine("Wrong task number. Repeat entry.");
            //            break;

            //    }
            //}
            //while (taskNumber != 0);

            while(true)
            {
                Console.Write("Enter task number: ");
                int taskNumber = int.Parse(Console.ReadLine());

                switch (taskNumber)
                {
                    case 0:
                        Console.WriteLine("Quitting application on user request");
                        Console.ReadLine();
                        return;
                        break;
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    default:
                        Console.WriteLine("Wrong task number. Repeat entry.");
                        break;

                }
            }





            Console.ReadLine();
            
        }

    }
}
