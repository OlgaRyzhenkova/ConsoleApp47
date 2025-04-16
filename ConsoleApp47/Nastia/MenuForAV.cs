using System;

namespace ConsoleApp47
{
    class MenuNastia
    {
        public static bool MenuForAVFirstBlock()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool stayInSubMenu = true;
            PerformanceTester tester = new PerformanceTester();

            while (stayInSubMenu)
            {
                Console.Clear();
                Console.WriteLine("Меню Завдань Насті");
                Console.WriteLine("1. ➤ Завдання 1");
                Console.WriteLine("2. ➤ Завдання 2");
                Console.WriteLine("3. ➤ Завдання 3");
                Console.WriteLine("4. ➤ Завдання 4");
                Console.WriteLine("5. Тест продуктивності");
                Console.WriteLine("6. Вихід з програми");
                Console.WriteLine("7. ⬅ Повернення до головного меню");
                Console.Write("Ваш вибір (1-7): ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("⚠ Некоректне введення.");
                }
                else
                {
                    int n = 0;
                    if (choice is >= 1 and <= 4)
                    {
                        Console.Write($"Введіть значення n для завдання {choice}: ");
                        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
                        {
                            Console.WriteLine("⚠ Некоректне значення n.");
                            n = 0;
                        }
                    }

                    Console.Clear();

                    switch (choice)
                    {
                        case 1:
                            ShowResult("Завдання 1", () => SequenceBuilder.Input1(n), n);
                            break;
                        case 2:
                            ShowResult("Завдання 2", () => SequenceBuilder.Input2(n), n);
                            break;
                        case 3:
                            ShowResult("Завдання 3", () => SequenceBuilder.Input3(n), n);
                            break;
                        case 4:
                            ShowResult("Завдання 4", () => SequenceBuilder.Input4(n), n);
                            break;
                        case 5:
                            tester.Test();
                            break;
                        case 6:
                            Console.WriteLine("Вихід з програми");
                            return false;
                        case 7:
                            Console.WriteLine("🔙 Повернення до головного меню");
                            return true;
                        default:
                            Console.WriteLine("⚠ Невірний вибір.");
                            break;
                    }
                }

                if (stayInSubMenu)
                {
                    Console.WriteLine("\nНатисніть Enter для повернення до меню");
                    Console.ReadLine();
                }
            }

            return true;
        }

        private static void ShowResult(string title, Func<string> method, int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"{title} — результат:");
                Console.WriteLine(method());
            }
            else
            {
                Console.WriteLine("⚠ Значення n некоректне.");
            }
        }
    }
}
