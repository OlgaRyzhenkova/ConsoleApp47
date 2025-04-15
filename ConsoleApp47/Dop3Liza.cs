using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectForLaba4
{
    class Dop17Liza
    {
        public static void DopLizaTherd()
        {
            Console.WriteLine("Введіть текст з числами:");
            string input = Console.ReadLine();
            string result = ConvertNumbersToWords(input);
            Console.WriteLine("Результат:");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        static string ConvertNumbersToWords(string input)
        {
            return Regex.Replace(input, @"(\d+)\s+(м|грн)", ReplaceMatch);
        }
        static string ReplaceMatch(Match match)
        {
            int number = int.Parse(match.Groups[1].Value);
            string unit = match.Groups[2].Value;

            string words = NumberToWords(number);
            string unitWord = "";

            if (unit == "м")
                unitWord = number == 1 ? "метр" : (number >= 2 && number <= 4 ? "метри" : "метрів");
            else if (unit == "грн")
                unitWord = number == 1 ? "гривня" : (number >= 2 && number <= 4 ? "гривні" : "гривень");
            return $"{words} {unitWord}";
        }
        static string NumberToWords(int number)
        {
            string[] words = { "нуль", "один", "два", "три", "чотири", "п’ять", "шість", "сім", "вісім", "дев’ять", "десять" };
            if (number >= 0 && number <= 10)
                return words[number];
            else
                return number.ToString();
        }
    }
}
