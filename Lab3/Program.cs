using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Program
    {
        public delegate double Func1Delegate(double x);

        public static double Function(double x)
        {
            return Math.Sqrt(0.2*x*Math.Sin(5*x)*Math.Cos(4*x*x)+550*x*x);
        }

        public static double Integral(double a, double b, double n, Func1Delegate func)
        {
            double dx = (b - a) / n;
            double y1, y2;
            double x1, x2;
            double res;
            double IntgrlRes = 0;
            for (int i = 0; i < n; i++)
            {
                x1 = a + i * dx;
                x2 = x1 + dx;
                y1 = func(x1);
                y2 = func(x2);
                res = (y1 + y2) / 2 * (x2 - x1);
                IntgrlRes += res;
            }
            return IntgrlRes;
        }

        static void Menu()
        {
            Console.Write("Введiть початок вiдрiзку iнтегрування a:");
            string sa = Console.ReadLine();
            double a = double.Parse(sa);
            Console.Write("Введiть кiнець вiдрiзку iнтегрування b: ");
            string sb = Console.ReadLine();
            double b = double.Parse(sb);
            Console.Write("Введiть кiлькiсть дiлянок n:");
            string sn = Console.ReadLine();
            double n = double.Parse(sn);
            double IntgrlRes;
            Func1Delegate func = Function;
            IntgrlRes = Integral(a, b, n, func);
            Console.WriteLine("Іntegral [{0},{1}] = {2:0.000000}", a, b, IntgrlRes);
            Console.Write("Reload? (y - YES) ");
            ConsoleKeyInfo pressedKey = Console.ReadKey();
            Console.WriteLine();
            while (true)
            {
                if (pressedKey.Key != ConsoleKey.Y)
                {
                    pressedKey = Console.ReadKey();
                }
                else
                {
                    Menu();
                }

            }

        }
        static void Main(string[] args)
        {
            Menu();



        }
    }
}
