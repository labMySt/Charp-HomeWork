using System;

namespace Interaface
{
    public class Hennessy: Alco
    {
       
        private int _old;


        public Hennessy(double volunes, int old)
        {
            
            _old = old;
            _volumes = volunes;
        }

        public override void Drink()
        {
           Console.WriteLine("make me happy!!!");
        }

        public void  Volumes()
        {
            Console.WriteLine(_volumes);
        }

        public void Old()
        {
            Console.WriteLine(_old);
        }
        public override string ToString()
        {
            Console.WriteLine("Hennessy:" + "old - " + _old + "volumes - " + _volumes + ".");
            return "Hennessy:" + "old - " + _old +  "volumes - " + _volumes + ".";
        }
    }
}