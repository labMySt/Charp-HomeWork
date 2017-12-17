using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class battleFild
    {
       private Barracks _barracks = new Barracks();
       private OwnList<ACharacter> _list = new OwnList<ACharacter>();
  
        public void CreateList()
        {
           
            Console.Write("Hello\n");
            string answer = "1";
            while (answer =="1")
            {
                Console.Write("Do you want to create someone? yes(1) no(0)\n");
                answer = Console.ReadLine();
                if (answer == "1") _list.Add(_barracks.GetCharacter());
            }
            Console.Write("you created:\n");
            foreach(ACharacter soldier in _list)
            {
                soldier.Show();
            }
  
        }

        public void Attack()
        {
            foreach (ACharacter soldier in _list)
            {
                if (soldier is Archer) ((Archer)(soldier)).Shoot();
                if (soldier is Infantryman) ((Infantryman)soldier).Attack();
            }
        }
        public void Attack(string race)
        {
            foreach (ACharacter soldier in _list)
            {
                if (soldier.race == race)
                {
                    if (soldier is Archer) ((Archer)soldier).Shoot();
                    if (soldier is Infantryman) ((Infantryman)soldier).Attack();
                }
            }
        }

        public void Statistics()
        {
            foreach (ACharacter soldier in _list)
            {
                soldier.Show();
            }
        }
    }
}
