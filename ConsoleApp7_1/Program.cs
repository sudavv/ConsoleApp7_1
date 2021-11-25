using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Console.WriteLine("Введите стороны треугольника A");
            string a1str = Console.ReadLine();
            string b1str = Console.ReadLine();
            string c1str = Console.ReadLine();
            double a1 = 0;
            double b1 = 0;
            double c1 = 0;
            Console.WriteLine("Введите стороны треугольника B");
            string a2str = Console.ReadLine();
            string b2str = Console.ReadLine();
            string c2str = Console.ReadLine();
            double a2 = 0;
            double b2 = 0;
            double c2 = 0;

            try
            {
                a1 = Convert.ToDouble(a1str);
                b1 = Convert.ToDouble(b1str);
                c1 = Convert.ToDouble(c1str);

                a2 = Convert.ToDouble(a2str);
                b2 = Convert.ToDouble(b2str);
                c2 = Convert.ToDouble(c2str);
            }
            catch
            {
                Console.WriteLine("Не число");
            }

            Program p = new Program();
            double halfperA = p.HalfPerimeter(a1, b1, c1);
            double halfperB = p.HalfPerimeter(a2, b2, c2);
            double squareA = p.CalcTriangle(halfperA, a1, b1, c1);
            double squareB = p.CalcTriangle(halfperB, a2, b2, c2);

            if (squareA > squareB)
            {
                Console.WriteLine("Площадь треугольника А больше, чем B: " + squareA + " против " + squareB);
            }
            else
            {
                Console.WriteLine("Площадь треугольника B больше, чем А: " + squareB + " против " + squareA);
            }
            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }

        double CalcTriangle(double p, double a, double b, double c)
        {
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        double HalfPerimeter(double a, double b, double c)
        {
            return (a+b+c)/2;
        }
    }
}