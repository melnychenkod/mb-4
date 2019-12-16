using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите початкове xmin: ");
            string sxMin = Console.ReadLine();
            double xMin = double.Parse(sxMin);

            Console.Write("Введите кінцеве Xmax: ");
            string sxMax = Console.ReadLine();
            double xMax = double.Parse(sxMax);

            Console.Write("Введите приріст dx: ");
            sxMax = Console.ReadLine();
            double dx = double.Parse(sxMax);

            double x = xMin;
            double y;

            double cos;
            double cos2;
            double cosSum = 1;
            while (x <= xMax)
            {
                cos = Math.Cos(Math.Pow(x, 3));
                cos2 = Math.Cos(3*x);
                cosSum += cos+cos2;
                y = (cos+45+3*x)/(Math.Pow(x,13)+cos2);
                Console.WriteLine("x = {0:##.00000}\t\t y = {1}\t\t", x, y);

                
                x += dx;
            }
            Console.WriteLine("cos = {0}", cosSum);
            Console.ReadKey();
        }
    }
}

