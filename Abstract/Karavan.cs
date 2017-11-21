using System;

namespace Abstruct
{
    public class Karavan : Bottle
    {
        public override float Valume
        {
            get
            {
                if (Valume == 1) return (float)0.5;
                else if (Valume == 2) return (float) 1.5;


                return 0;
            } 


            set
            {
                if (value == 0.5 || value == 1.5) Valume = value;
            }
        }



        protected string isLavel = "yes";

        protected string Type = "plastic";

        public override string ToString()
        {
            return $"Karavan: {Valume}, {Type},Labal: {isLavel}";
        }
    }
    
}
