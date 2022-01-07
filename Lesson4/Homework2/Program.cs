using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class StaticClass
    {
        private int[] arr = new int[20];

        public StaticClass(int[] arr)
        {
            this.arr = arr;
        }

        public int Pairs()
        {
            int j = 0;
            
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 3 == 0 && arr[i + 1] % 3 != 0) || (arr[i] % 3 != 0 && arr[i + 1] % 3 == 0))
                {
                    j++;
                }
            }

            return j;
        }
    }

    

    class Program
    {

        public static int[] LoadArrayFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {

                using (StreamReader reader = new StreamReader(fileName))
                {

                    int[] buf = new int[1000];

                    int counter = 0;


                    while (!reader.EndOfStream)
                    {
                        buf[counter] = int.Parse(reader.ReadLine());
                        counter++;
                    }

                    int[] arr = new int[counter];

                    Array.Copy(buf, arr, counter);

                    return arr;

                }

            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[20];
            int[] arr2 = LoadArrayFromFile(AppDomain.CurrentDomain.BaseDirectory + "MyArray.txt");

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-10000, 10001);

                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write($"{arr2[i]} ");
            }

            StaticClass staticClass1 = new StaticClass(arr);
            StaticClass staticClass2 = new StaticClass(arr2);

            int pairs = staticClass1.Pairs();
            int pairs2 = staticClass2.Pairs();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(pairs);
            Console.WriteLine();
            Console.WriteLine(pairs2);

            Console.ReadKey();
        }
    }
}
