using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Barracks : IBarracks
    {
      
       
        public ACharacter GetCharacter()
        {
            Console.Write("Archer(0) or Infantryman(1):");

            if (Int32.Parse(Console.ReadLine()) == 0)
            {
                return  new Archer(_getRace(), _getName(), _getPower(), _getArrows());
            }
            else return new Infantryman(_getRace(), _getName(), _getLife(), _getTool());

        }

        private string _getName()
        {
            Console.Write("Enter the name:");
            return Console.ReadLine();
        }

        private string _getRace()
        {
            Console.Write("Enter the race:");
            return Console.ReadLine();
        }

        private int _getPower()
        {
            Console.Write("Enter power:");
            return Int32.Parse(Console.ReadLine());
        }

        private int _getArrows()
        {
            Console.Write("Enter arrows:");
            return Int32.Parse(Console.ReadLine());
        }
        private int _getLife()
        {
            Console.Write("Enter life:");
            return Int32.Parse(Console.ReadLine());
        }

        private string _getTool()
        {
            Console.Write("Enter the tool:");
            return Console.ReadLine();
        }

        
    }
}
