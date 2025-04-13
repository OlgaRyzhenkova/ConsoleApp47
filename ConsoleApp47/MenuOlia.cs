using System;
using System.Text;

namespace ConsoleApp47
{
    class MenuOlia
    {
        public static void DisplayMainMenu()
        {
            bool stayInSubMenu = true;

            while (stayInSubMenu)
            {
                Console.Clear();
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Меню завдань Олі (Блок 1):");
                Console.WriteLine("1. Виконати задачу");
                Console.WriteLine("2. Перевірити час виконання різних версій"); // Тільки тут доступна перевірка часу
                Console.WriteLine("3. Повернутися до головного меню");
                Console.Write("Ваш вибір: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Некоректне введення. Натисніть Enter для повтору...");
                    Console.ReadLine();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        ExecuteTask();
                        break;
                    case 2:
                        TimeBlock1Olia.TestPerformance(); // Виклик перевірки часу
                        break;
                    case 3:
                        stayInSubMenu = false;
                        Console.WriteLine("Повернення до головного меню...");
                        break;
                    default:
                        Console.WriteLine("Некоректний вибір. Натисніть Enter для повтору...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private static void ExecuteTask()
        {
            Console.Clear();
            Console.WriteLine("Введіть число n для виконання завдання:");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                string result = Methods.Block1Olia(n);
                Console.WriteLine("Результати обчислень:");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Некоректне число. Натисніть Enter для повернення в меню...");
            }

            Console.WriteLine("\nНатисніть Enter для повернення в меню завдань Олі...");
            Console.ReadLine();
        }
    }
}