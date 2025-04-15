using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectForLaba4
{
    class Dop16Liza
    {
        public static void DopLizaSecond()
        {
            Console.WriteLine("Введіть звичайний рядок тексту:");
            string input = Console.ReadLine();

            Console.WriteLine("Введіть рядок тексту без пробілів:");
            string pattern = Console.ReadLine();

            string regexPattern = "";
            foreach (char c in pattern)
            {
                if (c == '?') regexPattern += '.';
                else if (c == '*') regexPattern += ".*";
                else regexPattern += Regex.Escape(c.ToString());
            }
            string[] words = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("\nСлова, що відповідають шаблону:");
            foreach (string word in words)
            {
                if (Regex.IsMatch(word, "^" + regexPattern + "$")) Console.WriteLine(word);
            }
            Console.WriteLine("\nНатисніть Enter, щоб продовжити...");
            Console.ReadLine();
        }
    }
}