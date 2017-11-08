using System;

namespace Interaface
{
    public class Tomatoes : Appetizer
    {
        public int weignt { get; set; }
       

    
        public void BuyAppetizer()
        {
            Console.WriteLine("Weste no much money ");
        }

        public void UseAppetizer()
        {
            Console.WriteLine("I am not hungry but I still drunk!");
        }

        public override string ToString()
        {
            return " Tomatoes:" + "weignt - " + weignt;
        }
    }
}