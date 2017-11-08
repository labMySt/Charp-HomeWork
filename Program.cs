using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. Create composition from 3 classes (1 parent - abstract, 2 - child). Parent class must have one or more field and one or more method
2. Fill array (min. 3 items) type of abstract class using simple initialization (set element count)
3. Display array to console using "for"
4. Create interface and implement it in 2 child classes
5. Fill array type of interface using object initializer
6. Display array to console using "foreach"

Read book: 333-355, 416-423*/
namespace Interaface
{
    class Program
    {
        static void Main(string[] args)
        {
            Alco[] minibar = new Alco[3];
            minibar[0] = new Hennessy(0.7, 10);
            minibar[1] = new Hennessy(1, 15);
            minibar[2] = new Zakarpatski(0.5, 4);



        foreach (var VARIABLE in minibar)
            {
                VARIABLE.ToString();
                VARIABLE.BuyAlco();
                VARIABLE.Drink();
            }


            Appetizer[] zacus = new Appetizer[2];
            zacus[0] = new Tomatoes{weignt = 1};
            zacus[1] = new DriedMeat{count = 1};

            Console.WriteLine();
            for (int i = 0; i < zacus.Length; i++)
            {
               
                Console.WriteLine( zacus[i].ToString());
                zacus[i].BuyAppetizer();
                zacus[i].UseAppetizer();
            }
            Console.ReadKey();
        }
    }
    
    
}
