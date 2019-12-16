using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Planet> Planets = new List<Planet>(3);
            string sanswer = "";
            int answer=2;
            int i=0;
            while (sanswer != "Q")
            {
                Console.Write("New base of best film!\n");
                Console.Write("What you want to do?\n");
                Console.Write("[1]Add new Film\n");
                Console.Write("[2]Status base\n");
                sanswer = Console.ReadLine();
                answer = int.Parse(sanswer);
                if (answer == 1)
                {
                    Planets = AddPlanet(Planets);
                   // Action Action<List> action = new Action<List> (Status);
                }
                if (answer == 2)
                {
                    Status(Planets);
                    // Action Action<List> action = new Action<List> (Status);
                }
            }
        }
        static public List<Planet> AddPlanet(List<Planet> Planets) 
        {
            Planet p = new Planet();
            Console.WriteLine("Введите в формате: Название планети, количество лет, радиус" +
                ", номер в солнечной системе, можно ли там жить True/False\n Пример: Сатурн,50000,6000,5,True");
            string[] temp = new string[100];
            temp = Console.ReadLine().Split(',');
            p.name = temp[0];
            p.year = Convert.ToInt32(temp[1]);
            p.radius = Convert.ToInt32(temp[2]);
            p.numberOnSun = Convert.ToInt32(temp[3]);
            p.live = Convert.ToBoolean(temp[4]);
            Planets.Add(p);
            return Planets;
        }
        static public void Status(List<Planet> Planets)
        {
            int i = Planets.Count;
            for(int j=0; j<i;j++)
            {
                Console.WriteLine(" Название "+ Planets[j].name + " Года "+ Planets[j].year+ " Радиус "
                    + Planets[j].radius + " Номер в системе "+ 
                    Planets[j].numberOnSun + " Можно жить " +Planets[j].live) ;
            }
        }
    }
}
