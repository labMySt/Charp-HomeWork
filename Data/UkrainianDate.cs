using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDate
{
    class UkrainianDate
    {
        public Date sourse = new Date();
        char delimiter = '.';

        public void PrintDate()
        {
            Console.WriteLine($"{sourse.day}{delimiter}{sourse.month}{delimiter}{sourse.year}");
        }
    }
}
