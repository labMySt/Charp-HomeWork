using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

/*
    1. Створити базовий абстрактний клас.Мінімум 2 властивості

    2. Створити два дочірніх класи. Мінімум 3 властивості і всі різних типів

    3. Створити масив (кількість єлементів вказує користувач)

    4. Дати користувачеві заповнити масив.Користувач має сам обрати який саме клас (з двох дочірніх) він зараз хоче створити.

    5. Користувач у будь-який момент заповнення масива може переглянути уже заповнені елементи
    */

namespace Abstruct
{
    class Program
    {
        static void Main(string[] args)
        {
             Bottle[] box = DrinkMaker.GetBox();
            //Bottle box = new Karavan();
            //box.Valume(0.5);
            //Console.WriteLine(box.ToString());
            Console.ReadKey();
        }

    }
}
