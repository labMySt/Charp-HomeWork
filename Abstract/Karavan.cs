using System;
using System.ComponentModel;

namespace Abstruct
{
    public class Karavan : Bottle
    {

        public override double Valume(double value)
        {
            if (value == _valume || value == 0) return _valume;

            if (value == 0.5 || value == 1.5) _valume = value;
            return _valume;
        }
       

        protected string Type = "plastic";

        public override string ToString()
        {
            return $"Karavan: {Valume(_valume)}, {Type},Labal: Yes";
        }
    }
    
}
