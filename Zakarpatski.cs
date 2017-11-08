using System;

namespace Interaface
{
    public class Zakarpatski : Alco
    {
        private int _stars;


        public Zakarpatski(double volumes, int stars)
        {
            _stars = stars;
            _volumes = volumes;
 
        }

        public override void Drink()
        {
           Console.WriteLine("make me drunk");
        }

        public void Stars()
        {
            Console.WriteLine(_stars);
        }

        public void Volumes()
        {
            Console.WriteLine(_volumes);
        }

        public override string ToString()
        {
            Console.WriteLine("Zakarpatski:" + "stars - " + _stars + "volumes - " + _volumes+ ".");
            return "Zakarpatski:" + "stars - " + _stars + "volumes - " + _volumes + ".";
        }
    }
}