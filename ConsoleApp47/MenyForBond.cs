using System;
using System.Text;

namespace ConsoleApp47
{
    class MenyBond
    {
        public static bool MenyForBondarenkoFirstBlock()
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool stayInSubMenu = true;
            Student studentTester = new Student();

            while (stayInSubMenu)
            {
                Console.Clear();
                Console.WriteLine("Меню Завдань Лізи (Блок 1):");
                Console.WriteLine("1. Виконати метод 1 (string, += кінець)");
                Console.WriteLine("2. Виконати метод 2 (string, + початок)");
                Console.WriteLine("3. Виконати метод 3 (StringBuilder, Append кінець)");
                Console.WriteLine("4. Виконати метод 4 (StringBuilder, Insert початок)");
                Console.WriteLine("5. Запустити повний тест продуктивності");
                Console.WriteLine("6. Вийти З УСІЄЇ ПРОГРАМИ");
                Console.WriteLine("7. Повернутись до головного меню");
                Console.Write("Виберіть опцію (1-7): ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Некоректне введення.");
                }
                else
                {
                    int n = 0;
                    if (choice >= 1 && choice <= 4)
                    {
                        Console.Write($"Введіть значення n для демонстрації методу {choice}: ");
                        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                        {
                            Console.WriteLine("Некоректне значення n.");
                            n = 0;
                        }
                    }

                    Console.Clear();

                    switch (choice)
                    {
                        case 1:
                            if (n > 0)
                            {
                                string result = Input.Inputs1(n);
                                Console.WriteLine("Результат методу 1:");
                                Console.WriteLine(result);
                            }
                            else Console.WriteLine("Значення n не введено або некоректне.");
                            break;
                        case 2:
                            if (n > 0)
                            {
                                string result = Input.Inputs2(n);
                                Console.WriteLine("Результат методу 2:");
                                Console.WriteLine(result);
                            }
                            else Console.WriteLine("Значення n не введено або некоректне.");
                            break;
                        case 3:
                            if (n > 0)
                            {
                                string result = Input.Inputs3(n);
                                Console.WriteLine("Результат методу 3:");
                                Console.WriteLine(result);
                            }
                            else Console.WriteLine("Значення n не введено або некоректне.");
                            break;
                        case 4:
                            if (n > 0)
                            {
                                string result = Input.Inputs4(n);
                                Console.WriteLine("Результат методу 4:");
                                Console.WriteLine(result);
                            }
                            else Console.WriteLine("Значення n не введено або некоректне.");
                            break;
                        case 5:
                            studentTester.Test();
                            break;
                        case 6:
                            stayInSubMenu = false;
                            Console.WriteLine("Вихід з програми...");
                            return false;
                        case 9:
                            stayInSubMenu = false;
                            Console.WriteLine("Повернення до головного меню...");
                            return true;
                        default:
                            Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                            break;
                    }
                }
                if (stayInSubMenu)
                {
                    Console.WriteLine("\nНатисніть Enter для повернення в меню завдань Лізи...");
                    Console.ReadLine();
                }
            }
            return true;
        }
    }
}