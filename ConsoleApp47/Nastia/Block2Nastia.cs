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

        static string UsingString(string input)
        {
            string result = "";

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    result += c;
                }
                else if (char.IsLetter(c))
                {
                    result = c + result; 
                }
            }

            return result;
        }

        static string UsingStringBuilder(string input)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    result.Append(c);
                }
                else if (char.IsLetter(c))
                {
                    result.Insert(result.Length - CountDigits(result), c);
                }
            }

            return result.ToString();
        }

        static int CountDigits(StringBuilder sb)
        {
            int count = 0;
            foreach (char c in sb.ToString())
            {
                if (char.IsDigit(c))
                    count++;
            }
            return count;
        }
    }
}