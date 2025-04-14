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
                Console.WriteLine("2. Виконати метод 2 ");
                Console.WriteLine("3. Виконати метод 3 ");
                Console.WriteLine("6. Вийти З УСІЄЇ ПРОГРАМИ");
                Console.WriteLine("7. Повернутись до головного меню");
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
                            Console.WriteLine("Результат методу з простою заміною:");
                            SimpleCode.VayBlock();
                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                        case 6:
                            stayInSubMenu = false;
                            Console.WriteLine("Вихід з програми...");
                            return false;
                        case 7:
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
