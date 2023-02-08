using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Tortiki
{
    internal class Menu
    {
        Positions one;
        Positions two;
        Positions three;
        public Positions Show(int pos)
        {
            int funcpos = 0;
            Console.Clear();
            int price = 0;
            if (pos == 0)
            {
                one = new Positions("Круглый", 1000);
                two = new Positions("Квадратный", 9000);
                three = new Positions("Прямоугольный", 1100);
            }
            else if (pos == 1)
            {
                one = new Positions("Маленький", 500);
                two = new Positions("Средний", 900);
                three = new Positions("Большой", 1000);
            }
            else if (pos == 2)
            {
                one = new Positions("Клубничный корж", 700);
                two = new Positions("Шоколадный корж", 900);
                three = new Positions("Ванильный корж", 1000);
            }
            else if (pos == 3)
            {
                one = new Positions("Два коржа", 500);
                two = new Positions("Три коржа", 900);
                three = new Positions("Четыре коржа", 1000);
            }
            else if (pos == 4)
            {
                one = new Positions("Шоколадная глазурь", 500);
                two = new Positions("Ягодная глазурь", 900);
                three = new Positions("Глазурь-безе", 1000);
            }
            else if (pos == 5)
            {
                one = new Positions("Шоколадный декор", 500);
                two = new Positions("Ягодный декор", 900);
                three = new Positions("Декор - микс", 1200);
            }

            while (true)
            {
                if (funcpos < 2) { funcpos = 2; }
                if (funcpos > 4) { funcpos = 4; }
                Func(one, two, three);
                Console.SetCursorPosition(0, funcpos);
                Console.WriteLine("->");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape) { break; }

                if (key.Key == ConsoleKey.UpArrow)
                {
                    funcpos--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    funcpos++;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    if (funcpos == 2)
                    {
                        price += one.Price;
                        return one;
                    }
                    else if (funcpos == 3)
                    {
                        price += two.Price;
                        return two;
                    }
                    else if (funcpos == 4)
                    {
                        price += three.Price;
                        return three;
                    }
                    break;
                }
                Console.Clear();
            }
            return one = new Positions("", 0);
        }
        private void Func(Positions one, Positions second, Positions third)
        {
            Console.WriteLine("Выберите один из параметров: ");
            Console.WriteLine("----------------------------------------------");
            Console.SetCursorPosition(2, 2);
            Console.WriteLine($"1. {one.Name}");
            Console.SetCursorPosition(2, 3);
            Console.WriteLine($"2. {second.Name}");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine($"3. {third.Name}");
            Console.WriteLine("----------------------------------------------");
        }

    }
}
