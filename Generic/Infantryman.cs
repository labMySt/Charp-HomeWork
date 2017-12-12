using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Infantryman : ACharacter
    {
        private int _life;

        private string _kindOfTool;

        public Infantryman(string Race, string Name, int life, string tool)
        {
            name = Name;
            race = Race;
            if (life > 100 || life <= 0) _life = 100;
            else _life = life;
            _kindOfTool = tool;
        }

        public void Attack()
        {
            Console.Write($"Infantryman: {name} attackes!");
            _life--;
        }
        public override void Show()
        {
            Console.Write($"Infatryman:\n"+
                          $"race: {race}\n"+                 
                          $"name: {name}\n" +
                          $"life:{_life}"+
                          $"tool:{_kindOfTool}\n");
        }
    }
}
