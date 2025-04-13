using System;
using System.Text;

namespace ConsoleApp47
{
    partial class Methods
    {
        public static void Block2Nastia()
        {
            Console.Write("Введіть рядок символів: ");
            string input = Console.ReadLine();

            Console.WriteLine("\nОберіть метод виконання:");
            Console.WriteLine("1. Без використання StringBuilder (string)");
            Console.WriteLine("2. З використанням StringBuilder");
            Console.Write("Ваш вибір: ");
            string choice = Console.ReadLine();

            string result = choice switch
            {
                "1" => UsingString(input),
                "2" => UsingStringBuilder(input),
                _ => "Некоректний вибір"
            };

            Console.WriteLine("\nРезультат перетворення: " + result);
        }

        private static string UsingString(string input)
        {
            string digits = "";
            string letters = "";

            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    digits += ch;
                }
                else if (char.IsLetter(ch) && ch <= 127)
                {
                    letters = ch + letters;
                }
            }

            return digits + letters;
        }

        private static string UsingStringBuilder(string input)
        {
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();

            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    digits.Append(ch);
                }
                else if (char.IsLetter(ch) && ch <= 127)
                {
                    letters.Insert(0, ch);
                }
            }

            return digits.ToString() + letters.ToString();
        }
    }
}