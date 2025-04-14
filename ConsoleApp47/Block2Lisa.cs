using System;
using System.Collections.Generic;

namespace ProjectForLaba4
{
    class MenyBondBlockSecond
    {
        public static bool MenyForBondarenkoSecondBlock()
        {
            bool stayInSubMenu = true;
            while (stayInSubMenu)
            {
                Console.Clear();
                Console.WriteLine("Меню Завдань Лізи (Блок 2):");
                Console.WriteLine("1. Виконати методу з простою заміною ");
                Console.WriteLine("2. Виконати метод з бібліотечною заміною ");
                Console.WriteLine("3. Вийти З УСІЄЇ ПРОГРАМИ");
                Console.WriteLine("4. Повернутись до головного меню");
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
                            SimpleCode.VayBlock();
                            break;
                        case 2:
                            NotSimpleCode.NotVayBlock();
                            break;
                        case 3:
                            stayInSubMenu = false;
                            Console.WriteLine("Вихід з програми...");
                            return false;
                        case 4:
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