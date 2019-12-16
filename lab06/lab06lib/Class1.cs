using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab06lib
{
        public class Tablet
        {
            public string Name;
            public string Manufacturer;
            public string Colour;
            public int Memory;
            public int Users;
            public double Cost;
            public double YearInCome;
            public bool HasCase;
            public bool HasUpdate;
            public double GetYearIncomePerInhabitant()
            {
                return Cost * Users;
            }
        }
}
