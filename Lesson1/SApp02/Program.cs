using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SApp02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tasks 1&2

            Console.Title = "Application Form";
            Console.Clear();

            Console.WriteLine("Your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Your surname:");
            string surname = Console.ReadLine();

            Console.WriteLine("Your age:");
            string age = Console.ReadLine();

            Console.WriteLine("Your height in meters:");
            double height = Double.Parse(Console.ReadLine());

            Console.WriteLine("Your weight in kg:");
            double weight = int.Parse(Console.ReadLine());

            double bmi = weight / (height*height);


            Console.WriteLine("Name: " + name + ", surname: " + surname + ", age: " + age + ", height: " + height + ", weight: " + weight);
            Console.WriteLine("Name: {0}, surname: {1}, age: {2}, height: {3}, weight: {4}", name, surname, age, height, weight);
            Console.WriteLine($"Name: {name}, surname: {surname}, age: {age}, height: {height}, weight: {weight}");
            Console.WriteLine($"Your bmi: {Math.Round(bmi, 5)}");


            #endregion



            Console.ReadLine();

        }
    }
}
