using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {

        static bool CheckLogin(string a)
        {
            return a == "root";
        }

        static bool CheckPass(string a)
        {
            return a == "GeekBrains";
        }

        static void Main(string[] args)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter login: ");
                string login = Console.ReadLine();
                Console.WriteLine("Enter password: ");
                string password = Console.ReadLine();

                if (CheckLogin(login) == true && CheckPass(password) == true)
                {
                    Console.WriteLine("You are logged in");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong login or password. Try again.");
                }
            }

            

            Console.ReadLine();
        }
    }
}
