using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Archer : ACharacter
    {
        private int _power;
        private int _arrows;

        public Archer ( string Race, string Name, int power, int arrows)
        {
            name = Name;
            race = Race;
            if (power > 100 || power <= 0) _power = 100;
            else _power = power;
            if (arrows > 100 || arrows <= 0) _arrows = 100;
            else _arrows = arrows;
        }

        public void Shoot()
        {
            if (_arrows > 0)
            {
                Console.Write($"Archer {name} shoot!");
                if (_power < 100) _power++;
                if (_arrows > 0) _arrows--;
            }
            else Console.Write($"Archer {name} has no any arrow!");
        }
        public override void Show()
        {
            Console.Write($"Archer:\n" +
                $"race: {race}\n" +
                $" name: {name}\n" +
                $" power:{_power}\n" +
                $" arrows:{_arrows}\n");
        }
    }
}
