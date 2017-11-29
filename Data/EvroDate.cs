using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDate
{
    class EvroDate: UkrainianDate
    { 
    
        public EvroDate()
        {
            delimiter = ',';
        }


        public override string ToString()
 
        {
            Console.WriteLine($"{sourse.day}{delimiter}{sourse.month}{delimiter}{sourse.year}");
            return $"{sourse.day}{delimiter}{sourse.month}{delimiter}{sourse.year}";
        }

    }
     

}
