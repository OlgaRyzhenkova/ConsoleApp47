using System;
using System.Text;

namespace ConsoleApp47
{
    class DodExerOlia
    {
        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Виберіть завдання, яке потрібно виконати:");
                Console.WriteLine("1. Завдання 1");
                Console.WriteLine("0. Вихід");
                Console.Write("Ваш вибір: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Task1();
                        break;
                    case "0":
                        Console.WriteLine("Вихід з програми");
                        return;
                    default:
                        Console.WriteLine("Некоректний вибір. Спробуйте ще раз.");
                        break;
                }
                Console.WriteLine();
            }
        }
        static void Task1()
        {
            Console.WriteLine("Виконання завдання 1");
            Console.Write("Введіть рядок для перевірки: ");
            string input = Console.ReadLine();
            if (Balanced(input))
            {
                Console.WriteLine("Круглі дужки розташовані правильно.");
            }
            else
            {
                Console.WriteLine("Круглі дужки розташовані неправильно.");
            }
        }
        static bool Balanced(string str)
        {
            int balance = 0;
            foreach (char ch in str)
            {
                if (ch == '(')
                {
                    balance++;
                }
                else if (ch == ')')
                {
                    balance--;
                    if (balance < 0)
                    {
                        return false;
                    }
                }
            }
            return balance == 0;
        }
    }
}
       
