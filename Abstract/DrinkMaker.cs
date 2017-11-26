using System;
using System.Diagnostics;

namespace Abstruct
{
    public static class DrinkMaker
    {

        public static Bottle[] GetBox()
        {
            int countBottles = 0;
         
            
            Console.Write("Hello. I am your Drinkmaker! I can mix bottles in your box.\n" +
                          "Enter how many bottles do you want to have in your box:");

            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out countBottles))
                {
                    Console.Write("Try again:");
                }
            } while (countBottles == 0);
            Bottle[] box = new Bottle[countBottles];
            int BoxIn = -1;




            for (int bottle = 0; bottle< countBottles; bottle++)
            {
                Console.Write("\nThis bottle must be: Karavan(1) or Coca(2):");
                do
                {
                    if (!Int32.TryParse(Console.ReadLine(), out BoxIn))
                    {
                        Console.Write("Try again:");
                    }
                } while (BoxIn == 0);

                if (BoxIn == 1) box[bottle] = MakeRaravan();
                else if (BoxIn == 2) box[bottle] = MakeCocaCola();

            }
            Console.Write("\nYour box has:\n" + box.Length);

            foreach (Bottle i in box)
            {
                Console.WriteLine(i.ToString() + '\n');
            }
            return box;
        }
        //---------------------------------------------------------------------------------------------------
        public static Bottle MakeRaravan()
        {
           Bottle Bot = new Karavan();
            Console.Write("\nEnter the valume of bottle: 0.5L (1) or 1.5L (2)");
            int flag = 0;

            do
            {
                if (!int.TryParse(Console.ReadLine(), out flag))
                    
                {
                    Console.Write("Try again:");
                }
            } while (flag == 0);
            if (flag == 1) Bot.Valume(0.5);
            else Bot.Valume(1.5);

            return Bot;
        }
        //-----------------------------------------------------------------------------------------------------
        private static Bottle MakeCocaCola()
        {
            Bottle Bot = new CocaColaBottle();
            //------------------------------------------------ volume
            Console.Write("\nEnter the valume of bottle: 0.5L (1) or 1L (2) or 2L (3)");
            int flag = 0;

            do
            {
                if (!int.TryParse(Console.ReadLine(), out flag))
                {
                    Console.Write("Try again:");
                }
            } while (flag == 0);
            if (flag == 1) Bot.Valume(0.5);
            else if(flag == 2) Bot.Valume(1);
            else if(flag ==3) Bot.Valume(2);

            flag = 0;
            //---------------------------------------------------- type of bottle
            if (Bot.Valume(0) == 0.5)
            {
                Console.Write("\nType of Bottle: Glass(1) Plastic(2): ");
                do
                {
                    if (!int.TryParse(Console.ReadLine(), out flag))
                    {
                        Console.Write("Try again:");
                    }
                } while (flag == 0);
                if (flag == 1) ((CocaColaBottle)Bot).Type = "glasses";
            }
            //-------------------------------------------- label is
            if (((CocaColaBottle) Bot).Type == "glasses")
            {
                Console.Write("\nBottle with label?: yes(1) no(2)");
                flag = 0;
                do
                {
                    if (!int.TryParse(Console.ReadLine(), out flag))
                    {
                        Console.Write("Try again:");
                    }
                } while (flag == 0);
                if (flag == 2) ((CocaColaBottle)Bot).SetLabel("no");
                else ((CocaColaBottle)Bot).SetLabel("Yes");

            }
            
            //--------------------------------------------------------- type of cola
            Console.Write("\nEnter of : Zero(1) Classic(2)");
            flag = 0;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out flag))
                {
                    Console.Write("Try again:");
                }
            } while (flag == 0);
            if (flag == 2) ((CocaColaBottle)Bot).TypeOfCoca = "Classic";
            else ((CocaColaBottle)Bot).TypeOfCoca = "Zero";
            return Bot;
        }
        //-------------------------------------------------------------------------------------------
     
    }
}