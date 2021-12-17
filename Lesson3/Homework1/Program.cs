using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{

    class Complex //complex number
    {
        #region Private Fields

        //real part
        private double re;

        //imaginary part
        private double im; //no modificator means private

        #endregion

        #region Public Properties

        public double Re
        {
            get
            {
                return re;
            }

            set
            {
                if (value == 0)
                {
                    throw new Exception("Can't divide by 0!");
                }
                re = value;
            }
        }

        #endregion

        #region Constructor

        public Complex()
        {

        }

        public Complex(double re, double im)
        {
            if (im == 0)
            {
                throw new Exception("Can't divide by 0!");
            }

            this.re = re;
            this.im = im;
        }

        #endregion

        public void SetIm(double im)
        {
            this.im = im;
        }

        public double GetIm()
        {
            return im;
        }

        public Complex Plus(Complex x)
        {
            Complex y = new Complex(re + x.re, im + x.im);
            return y;
        }

        public Complex Minus(Complex x)
        {
            return new Complex(re - x.re, im - x.im);
        }

        public Complex Multiply(Complex x)
        {
            return new Complex(re * x.re, im * x.im);
        }

        public override string ToString()
        {
            //return base.ToString();

            return $"{re} + {im}i";

        }

    }

    class Program
    {

        static Complex Input1()
        {
            Console.Write("Enter real part of first complex number: ");
            int re = int.Parse(Console.ReadLine());
            Console.Write("Enter imaginary part of first complex number: ");
            int im = int.Parse(Console.ReadLine());
            Complex res = new Complex(re, im);
            return res;
        }

        static Complex Input2()
        {
            Console.Write("Enter real part of second complex number: ");
            int re = int.Parse(Console.ReadLine());
            Console.Write("Enter imaginary part of second complex number: ");
            int im = int.Parse(Console.ReadLine());
            Complex res = new Complex(re, im);
            return res;
        }

        static Complex Sum(Complex a, Complex b)
        {
            Complex res = a.Plus(b);
            return res;
        }

        static Complex Minus(Complex a, Complex b)
        {
            Complex res = a.Minus(b);
            return res;
        }

        static Complex Multi(Complex a, Complex b)
        {
            Complex res = a.Multiply(b);
            return res;
        }

        static void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("Press 1 to add your complex numbers.");
            Console.WriteLine("Press 2 to subtract your complex numbers.");
            Console.WriteLine("Press 3 to multiply your complex numbers.");
            Console.WriteLine("Press 0 to quit application.");
            Console.WriteLine("");
        }

        static void Task1(Complex a, Complex b)
        {
            Console.WriteLine(Sum(a, b));
            Console.ReadLine();
        }

        static void Task2(Complex a, Complex b)
        {
            Console.WriteLine(Minus(a, b));
            Console.ReadLine();
        }

        static void Task3(Complex a, Complex b)
        {
            Console.WriteLine(Multi(a, b));
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            
            Complex complex01 = Input1();
            Complex complex02 = Input2();

            Menu();

            while (true)
            {
                Console.Write("Enter task number: ");
                int taskNumber = int.Parse(Console.ReadLine());

                switch (taskNumber)
                {
                    case 0:
                        Console.WriteLine("Quitting application on user request");
                        Console.ReadLine();
                        return;
                    //break;
                    case 1:
                        Task1(complex01, complex02);
                        break;
                    case 2:
                        Task2(complex01, complex02);
                        break;
                    case 3:
                        Task3(complex01, complex02);
                        break;
                    default:
                        Console.WriteLine("Wrong task number. Repeat entry.");
                        Console.ReadLine();
                        break;

                }

            }

            Console.ReadLine();
        }

    }

}
