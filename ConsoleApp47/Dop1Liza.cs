using System;
using System.Text;

namespace ProjectForLaba4
{
    class Dop15Liza
    {
        public static void DopLizaFirst()
        {
            Console.WriteLine("Введіть рядок тексту:");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ви не ввели текст.");
                return;
            }

            string correctedOutput = Parentheses(input);
            Console.WriteLine("\nВиправлений текст:");
            Console.WriteLine(correctedOutput);

            Console.WriteLine("\nНатисніть Enter, щоб продовжити...");
            Console.ReadLine();
        }
        static string Parentheses(string text)
        {
            StringBuilder result = new StringBuilder();
            int count = 0;
            foreach (char c in text)
            {
                if (c == '(')
                {
                    result.Append(c);
                    count++;
                }
                else if (c == ')')
                {
                    if (count > 0)
                    {
                        result.Append(c);
                        count--;
                    }
                }
                else result.Append(c);
            }
            for (int i = 0; i < count; i++)
            {
                result.Append(')');
            }
            return result.ToString();
        }
    }
}