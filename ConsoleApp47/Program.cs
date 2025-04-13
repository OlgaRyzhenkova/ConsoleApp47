using ConsoleApp47;
using System;

namespace ProjectForLaba4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool isTrue = true;

            while (isTrue)
            {
                Console.Clear();
                Console.WriteLine("\nГоловне Меню:");
                Console.WriteLine("1. Перший блок");
                Console.WriteLine("2. Другий блок");
                Console.WriteLine("3. Додаткові завдання");
                Console.WriteLine("0. Вихід");
                Console.Write("Оберіть дію: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Некоректний ввід!");
                    Console.WriteLine("Натисніть Enter...");
                    Console.ReadLine();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("--- Перший блок ---");
                        Console.WriteLine("Оберіть студента:");
                        Console.WriteLine("1. Оля");
                        Console.WriteLine("2. Ліза");
                        Console.WriteLine("3. Настя");
                        Console.WriteLine("4. Повернутись до головного меню");
                        Console.Write("Ваш вибір: ");

                        if (!int.TryParse(Console.ReadLine(), out int studentChoice1))
                        {
                            Console.WriteLine("Некоректний вибір!");
                            break;
                        }

                        switch (studentChoice1)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Перехід до меню завдань Олі...");
                                MenuOlia.DisplayMainMenu(); 
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Перехід до меню завдань Лізи...");
                                isTrue = MenyBond.MenyForBondarenkoFirstBlock();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Перехід до меню завдань Насті...");
                                isTrue = MenuNastia.MenuForAVFirstBlock();
                                break;
                            case 4:
                                Console.WriteLine("Повернення до головного меню...");
                                break;
                            default:
                                Console.WriteLine("Некоректний вибір студента!");
                                break;
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("--- Другий блок ---");
                        Console.WriteLine("Оберіть студента");
                        Console.WriteLine("1. Оля - 8 варіант");
                        Console.WriteLine("2. Ліза - 13 варіант");
                        Console.WriteLine("3. Настя - 10 варіант");
                        Console.WriteLine("4. Повернутись до головного меню");
                        Console.Write("Ваш вибір: ");

                        if (!int.TryParse(Console.ReadLine(), out int studentChoice2))
                        {
                            Console.WriteLine("Некоректний вибір!");
                            break;
                        }

                        switch (studentChoice2)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Виконую завдання Олі...");
                                Methods.Block2Olia();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Виконую завдання Лізи...");
                                Methods.Block2Lisa();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Виконую завдання Насті...");
                                Methods.Block2Nastia();
                                break;
                            case 4:
                                Console.WriteLine("Повернення до головного меню...");
                                break;
                            default:
                                Console.WriteLine("Некоректний вибір студента!");
                                break;
                        }
                        if (studentChoice2 != 4)
                        {
                            Console.WriteLine("\nНатисніть Enter для продовження...");
                            Console.ReadLine();
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("--- Додаткові завдання ---");
                        Console.WriteLine("\nНатисніть Enter для продовження...");
                        Console.ReadLine();
                        break;

                    case 0:
                        Console.WriteLine("Вихід із програми...");
                        isTrue = false;
                        break;

                    default:
                        Console.WriteLine("Некоректний вибір! Спробуйте ще раз.");
                        break;
                }

                // Пауза в головному меню, тільки якщо не виходимо з програми
                if (isTrue && choice != 1 && choice != 2 && choice != 3) // Уникаємо подвійної паузи
                {
                    Console.WriteLine("\nНатисніть Enter для продовження...");
                    Console.ReadLine();
                }
            }
        }
    }
}