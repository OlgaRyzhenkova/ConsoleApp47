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
                Console.WriteLine("2. Завдання 2");
                Console.WriteLine("0. Вихід");
                Console.Write("Ваш вибір: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
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
        static void Task2()
        {
            Console.WriteLine("Виконання завдання 2");
            Console.Write("Введіть рядок слів: ");
            string input = Console.ReadLine();
            Console.Write("Введіть шаблон:");
            string pattern = Console.ReadLine();
            string[] words = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string regexPattern = ConvertPatternToRegex(pattern);
            Console.WriteLine("Слова, що відповідають шаблону:");
            foreach (string word in words)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(word, regexPattern))
                {
                    Console.WriteLine(word);
                }
            }
        }
        static string ConvertPatternToRegex(string pattern)
        {
            StringBuilder regex = new StringBuilder();
            foreach (char ch in pattern)
            {
                if (ch == '*')
                {
                    regex.Append(".*");
                }
                else if (ch == '?')
                {
                    regex.Append(".");
                }
                else
                {
                    regex.Append(System.Text.RegularExpressions.Regex.Escape(ch.ToString()));
                }
            }
            return "^" + regex.ToString() + "$";
        }
    }
}
