using System;
using System.CodeDom;

namespace Abstruct
{
    public class CocaColaBottle: Bottle
    {
        public override float Valume
        {
            get { return Valume; }
            set
            {
                if (value == 0.5 || value == 1 || value == 2) Valume = value;

            }

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
            return $"CocaCola: {Valume}, {Type}, {TypeOfCoca}, Label: {isLabel}";
        }
    }
}