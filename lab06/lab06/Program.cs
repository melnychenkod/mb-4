using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab06lib;
namespace lab06
{
    class Program
    { 
        static void Main(string[] args)
        {
            Tablet[] arrTablets;
            Console.Write("Введiть кiлькiсть планшетiв: ");
            int cntTablets = int.Parse(Console.ReadLine());
            arrTablets = new Tablet[cntTablets];
            for (int i = 0; i < cntTablets; i++)
            {
                Console.Write("Введiть назву планшету: ");
                string sName = Console.ReadLine();

                Console.Write("Введiть  iм'я виробника: ");
                string sManufacturer = Console.ReadLine();

                Console.Write("Введiть колiр планшету: ");
                string sColour = Console.ReadLine();

                Console.Write("Введiть обсяг пам'ятi: ");
                string sMemory = Console.ReadLine();

                Console.Write("Введiть кiлькiсть користувачiв: ");
                string sUsers = Console.ReadLine();

                Console.Write("Введiть цiну: ");
                string sCost = Console.ReadLine();

                Console.Write("Чи є у вас чехол? (y-так, n-нi): ");
                ConsoleKeyInfo keyHasCase = Console.ReadKey();

                Console.Write("Чи встановлювали ви оновлення? (y-так, n-нi): ");
                ConsoleKeyInfo keyHasUpdate = Console.ReadKey();

                Tablet TheTablet = new Tablet();
                TheTablet.Name = sName;
                TheTablet.Manufacturer = sManufacturer;
                TheTablet.Colour = sColour;
                TheTablet.Cost = double.Parse(sCost);
                TheTablet.Users = int.Parse(sUsers);
                TheTablet.HasCase = keyHasCase.Key == ConsoleKey.Y ? true : false;
                TheTablet.HasUpdate = keyHasUpdate.Key == ConsoleKey.Y ? true : false;


                arrTablets[i] = TheTablet;
            }
            foreach (Tablet t in arrTablets)
            {

                Console.WriteLine("------------------------------------------------");

                Console.WriteLine("Данi про планшет: ");

                Console.WriteLine("------------------------------------------------");

                Console.WriteLine("Назва: " + t.Name);
                Console.WriteLine("Виробник: " + t.Manufacturer);
                Console.WriteLine("Колір: " + t.Colour);
                Console.WriteLine("Обсяг пам'ятi: " + t.Memory.ToString());
                Console.WriteLine("Кiлькiсть користувачiв: " + t.Users.ToString());
                Console.WriteLine("Рiчний дохiд: " + t.YearInCome.ToString("0.00"));
                Console.WriteLine(t.HasCase ? "У користувача є чехол" : "У користувача нема чохла ");
                Console.WriteLine(t.HasUpdate ? "Користувач установив оновлення" : "Користувач не встановлював оновлення ");
                Console.WriteLine();
                Console.WriteLine("Середнiй рiчний дохiд компанії: " + t.GetYearIncomePerInhabitant().ToString("0.00"));
                Console.ReadKey();
            }
        }
    }
}
