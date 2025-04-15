using System;
using System.Collections.Generic;

namespace ProjectForLaba4
{
    class MenyBondBlockSecond
    {
        public static bool MenyForBondarenkoSecondBlock()
        {
            bool stayInSubMenu2 = true;
            while (stayInSubMenu2)
            {
                Console.Clear();
                Console.WriteLine("Меню Завдань Лізи (Блок 2):");
                Console.WriteLine("1. Виконати методу з простою заміною ");
                Console.WriteLine("2. Виконати метод з бібліотечною заміною ");
                Console.WriteLine("3. Повернутись до головного меню");
                Console.Write("Виберіть опцію (1-3): ");

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
                            stayInSubMenu2 = false;
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