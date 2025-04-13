using System;

namespace ConsoleApp47
{
    class MenyNastia
    {
        public static bool MenyForAVFirstBlock()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool stayInSubMenu = true;
            PerformanceTester tester = new PerformanceTester();

            while (stayInSubMenu)
            {
                Console.Clear();
                Console.WriteLine("Меню Завдань Насті (SequenceBuilder):");
                Console.WriteLine("1. Виконати завдання 1");
                Console.WriteLine("2. Виконати завдання 2");
                Console.WriteLine("3. Виконати завдання 3");
                Console.WriteLine("4. Виконати завдання 4");
                Console.WriteLine("5. Запустити тест продуктивності");
                Console.WriteLine("6. Закрити програму");
                Console.WriteLine("7. Повернутись до головного меню");
                Console.Write("Ваш вибір (1-7): ");

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
                                string result = SequenceBuilder.Input1(n);
                                Console.WriteLine("Результат завдання №1:");
                                Console.WriteLine(result);
                            }
                            else Console.WriteLine("Значення n не введено або некоректне.");
                            break;
                        case 2:
                            if (n > 0)
                            {
                                string result = SequenceBuilder.Input2(n);
                                Console.WriteLine("Результат завдання №2:");
                                Console.WriteLine(result);
                            }
                            else Console.WriteLine("Значення n не введено або некоректне.");
                            break;
                        case 3:
                            if (n > 0)
                            {
                                string result = SequenceBuilder.Input3(n);
                                Console.WriteLine("Результат завдання №3:");
                                Console.WriteLine(result);
                            }
                            else Console.WriteLine("Значення n не введено або некоректне.");
                            break;
                        case 4:
                            if (n > 0)
                            {
                                string result = SequenceBuilder.Input4(n);
                                Console.WriteLine("Результат завдання №4:");
                                Console.WriteLine(result);
                            }
                            else Console.WriteLine("Значення n не введено або некоректне.");
                            break;
                        case 5:
                            tester.Test();
                            break;
                        case 6:
                            stayInSubMenu = false;
                            Console.WriteLine("Вихід з програми");
                            return false;
                        case 7:
                            stayInSubMenu = false;
                            Console.WriteLine("Повернення до головного меню");
                            return true;
                        default:
                            Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                            break;
                    }
                }

                if (stayInSubMenu)
                {
                    Console.WriteLine("\nНатисніть Enter для повернення в меню");
                    Console.ReadLine();
                }
            }

            return true;
        }
    }
}
