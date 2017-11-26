using System;
using System.CodeDom;

namespace Abstruct
{
    public class CocaColaBottle: Bottle
    {

        public override double Valume (double value)
        {
            if(value == _valume || value == 0) return _valume;

            if (value == 0.5 || value == 1 || value == 2) _valume = value;
            return _valume;
            
        }

        private int _typeOfCoca;

        public string TypeOfCoca
        {
            get
            {
                if (_typeOfCoca > 0) return "Classic";
                else return "Zero";
            }
            set
            {
                if (value == "Classic") _typeOfCoca = 25;
                else _typeOfCoca = 0;
            }
        }

        public void SetLabel(string label)
        {
            if (label == "no" && Type == "glasses") isLabel = label;
            else isLabel = "Yes";
        }

        public override string ToString()
        {
            return $"CocaCola: {Valume(_valume)}, {Type}, {TypeOfCoca}, Label: {isLabel}";
        }
    }
}