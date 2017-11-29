using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDate
{
    class Program
    {
        static void Main(string[] args)
        {
            UkrainianDate date = new UkrainianDate();
            date.sourse.day = 14;
            date.sourse.year = 2017;
            date.sourse.month = 11;

            date.ToString();

            EvroDate date1 = new EvroDate();

            date1.sourse = date.sourse;

            date1.ToString();
            АmericanData date2 = new АmericanData();
            date2.sourse = date.sourse;

            date2.ToString();
         



            Console.ReadKey();
        }
    }
}
