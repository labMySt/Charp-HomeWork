using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            battleFild FirstFild = new battleFild();
            FirstFild.CreateList();
            FirstFild.Attack();
            FirstFild.Statistics();
            Console.ReadKey();
        }
    }
}
