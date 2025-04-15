using System;
using System.Collections.Generic;

namespace ProjectForLaba4
{
    class MenyBondDodatkovi
    {
        public static bool MenyForBondarenkoDodatkovi()
        {
            bool stayInSubMenu = true;
            while (stayInSubMenu)
            {
                Console.Clear();
                Console.WriteLine("Меню Завдань Лізи (Додаткові завдання):");
                Console.WriteLine("1. Виконати додаткове завдання 15 ");
                Console.WriteLine("2. Виконати додаткове завдання 16 ");
                Console.WriteLine("3. Виконати додаткове завдання 17");
                Console.WriteLine("4. Вийти З УСІЄЇ ПРОГРАМИ");
                Console.WriteLine("5. Повернутись до головного меню");
                Console.Write("Виберіть опцію (1-7): ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Некоректне введення.");
                }
                else
                {
                    Console.Clear();

                    switch (choice)
                    {
                        case 1:
                            Dop15Liza.DopLizaFirst();
                            break;
                        case 2:
                            Dop16Liza.DopLizaSecond();
                            break;
                        case 3:
                            //NotSimpleCode.NotVayBlock();
                            break;
                        case 4:
                            stayInSubMenu = false;
                            Console.WriteLine("Вихід з програми...");
                            return false;
                        case 5:
                            stayInSubMenu = false;
                            Console.WriteLine("Повернення до головного меню...");
                            return true;
                        default:
                            Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                            break;
                    }
                }
            }
            return true;
        }
    }
}