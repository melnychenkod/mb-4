using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x1 min: ");
            string sx1Min = Console.ReadLine();
            double x1Min = Double.Parse(sx1Min);

            Console.Write("Введите х1 max: ");
            string sx1Max = Console.ReadLine();
            double x1Max = Double.Parse(sx1Max);

            Console.Write("Ведите приріст dx1: ");
            string sdx1 = Console.ReadLine();
            double dx1 = Double.Parse(sdx1);

            Console.Write("Введите x2 min: ");
            string sx2Min = Console.ReadLine();
            double x2Min = Double.Parse(sx2Min);

            Console.Write("Введите х2 max: ");
            string sx2Max = Console.ReadLine();
            double x2Max = Double.Parse(sx2Max);

            Console.Write("Ведите приріст dx2: ");
            string sdx2 = Console.ReadLine();
            double dx2 = Double.Parse(sdx2);

            double y;
            double x1 = x1Min;
            double x2;
            double cosStat = 0;
            while (x1 <= x2Max)
            {
                x2 = x2Min;
                while (x2 <= x2Max)
                {
                    double z = x2/(x1+53*x2*x2);
                    if (z < 0)
                    {
                        Console.WriteLine("Корень меньше нуля");
                    }
                    y = Math.Pow(Math.Cos(x1-Math.Pow(z, 1.0 / 2)),4);
                    if (y > 0)
                    {
                        cosStat += y;
                    }
                    Console.WriteLine("x1 = {0:00.000e+00}\t\tx2 = {1:00.000e+00}\t\ty = {2:00.000e+00}", x1, x2, y);
                    x2 += dx2;
                }
                x1 += dx1;

            }
           
            Console.WriteLine("Додатні cos {0}", cosStat);
            Console.ReadKey();


        }
    }
}
