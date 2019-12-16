using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double StartX = 10.3;
            const double dX = 0.7;
            double x = StartX;
            double sum = 0;
            double[] arr = new double [10];
            for(int i=0; i < 10; ++i)
            {
                arr[i] = Function(x);
                x += dX;
            }
            double aMin,aMax,aAvg;
            Sort(arr);
            aMin = arr[0];
            aMax = arr[9];
            int num=0;
            int numMax=0;
            foreach(double i in arr)
            {
                if(i<aMax*1.1 && i > aMax * 0.9)
                {
                    numMax++;
                }
                sum +=i;
                Console.WriteLine("Елемент массива ["+num+"] = "+i);
                num++;
            }
            aAvg = sum / 10;
            Console.WriteLine("\nMax " + aMin + "\nMin " + aMax + "\nAvg " + aAvg+"\nR "+numMax);
            Console.ReadKey();
        }
        static double Function(double x)
        {
            double z = 0.651 * Math.Pow(x,8);
            double y = 23 * Math.Cos(z) + 5.52 * x;
            return y;
        }
        static double[] Sort(double[] array)
        {
            double temp;
            for(int i = 0; i<array.Length; i++)
            {
                for(int j = 0; j<array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

    }   
}
