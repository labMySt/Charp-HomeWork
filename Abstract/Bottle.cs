namespace Abstruct
{
    public abstract class Bottle
    {
        protected  double _valume;
        public abstract double Valume(double valuve);
            
       
        private string _type;
        public string Type
        {
            set
            {
                if (value == "plastic" || value == "glasses")
                    _type = value;
            }
            get => _type; 
        }
        private int _isLabel;

        public string isLabel
        {
            set
            {
                if (value == "yes")
                    _isLabel = 1;
                else if (value == "no")
                    _isLabel = 0;
            }
            get
            {
                if (_isLabel == 1) return "yes";
                if (_isLabel == 0) return "no";
                return null;
            }
        }

    }
}