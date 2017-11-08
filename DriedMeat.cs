using System;

namespace Interaface
{
    public class DriedMeat : Appetizer
    {
        public int count {get; set;}

       

        public void BuyAppetizer()
        {
            Console.WriteLine("Weste all money ");
        }

        public void UseAppetizer()
        {
            Console.WriteLine("Oh!!!! It was deliсious");
        }

        public override string ToString()
        {
            return "DriedMeat: " + "count - " + count;
        }
    }
}