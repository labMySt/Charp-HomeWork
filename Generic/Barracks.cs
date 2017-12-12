using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Barracks : IBarracks
    {
       private List<Object> _data =new List<object>();
        public void GetData()
        {
            Console.Write("Hello. Archer(0) or Infantryman(1):");
            _data.Clear();
           

            int Race = Int32.Parse(Console.ReadLine());
            _data.Add(Race);

            if (Race == 0 )
            {
                _data.Add(_getRace());
                _data.Add(_getName());
                _data.Add(_getPower());
                _data.Add(_getArrows());

            }
            else if(Race == 1)
            {
                _data.Add(_getRace());
                _data.Add(_getName());
                _data.Add(_getLife());
                _data.Add(_getTool());

            }
        }
        public ACharacter GetCharacter()
        {
           
            if (_data[0] == (object)0)
            {
                return  new Archer((string)_data[1], (string)_data[2], (int)_data[3], (int)_data[4]);
            }
            else return new Infantryman((string)_data[1], (string)_data[2], (int)_data[3], (string)_data[4]);

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
