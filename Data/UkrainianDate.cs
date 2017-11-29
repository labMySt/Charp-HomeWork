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
        protected char delimiter;

        public UkrainianDate()
        {
            delimiter = '.';
        }

        public override string ToString()
        {
            Console.WriteLine($"{sourse.day}{delimiter}{sourse.month}{delimiter}{sourse.year}");
            return $"{sourse.day}{delimiter}{sourse.month}{delimiter}{sourse.year}";
        }
    }
}
