using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDate
{
    class АmericanData: EvroDate

    {
        public override string ToString()
        {
            Console.WriteLine($"{sourse.month}{delimiter}{sourse.day}{delimiter}{sourse.year}");
            return $"{sourse.month}{delimiter}{sourse.day}{delimiter}{sourse.year}";
        }


    }
}
