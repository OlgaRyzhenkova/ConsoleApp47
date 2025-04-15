using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjectForLaba4
{
    class Dop16Liza
    {
        // --- Метод 1: Використання регулярних виразів 
        private static List<string> FindMatchesRegex(string input, string pattern)
        {
            List<string> matches = new List<string>();
            StringBuilder regexBuilder = new StringBuilder("^");
            foreach (char c in pattern)
            {
                switch (c)
                {
                    case '?': regexBuilder.Append('.'); break;
                    case '*': regexBuilder.Append(".*"); break;
                    default: regexBuilder.Append(Regex.Escape(c.ToString())); break;
                }
            }
            regexBuilder.Append('$');
            string regexPattern = regexBuilder.ToString();

            string[] words = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                if (Regex.IsMatch(word, regexPattern)) matches.Add(word);
            }
            return matches;
        }

        // --- Метод 2: Ручна реалізація (рекурсивна)
        private static bool MatchRecursive(string word, int wordIdx, string pattern, int patternIdx)
        {
            while (patternIdx < pattern.Length)
            {
                if (pattern[patternIdx] == '*')
                {
                    patternIdx++;
                    if (patternIdx == pattern.Length) return true;

                    for (int i = wordIdx; i <= word.Length; i++)
                    {
                        if (MatchRecursive(word, i, pattern, patternIdx)) return true;
                    }
                    return false;
                }

                if (wordIdx == word.Length) return false;

                if (pattern[patternIdx] == '?' || pattern[patternIdx] == word[wordIdx])
                {
                    patternIdx++;
                    wordIdx++;
                }
                else return false;
            }
            return wordIdx == word.Length;
        }

        private static List<string> FindMatchesManual(string input, string pattern)
        {
            List<string> matches = new List<string>();
            string[] words = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                if (MatchRecursive(word, 0, pattern, 0))
                {
                    matches.Add(word);
                }
            }
            return matches;
        }
        public static void DopLizaSecond()
        {
            Console.WriteLine("Введіть рядок тексту:");
            string input = Console.ReadLine();
            Console.WriteLine("Введіть шаблон (без пробілів, '*' - будь-яка послідовність, '?' - будь-який один символ):");
            string pattern = Console.ReadLine();

            Console.WriteLine("\nРезультат за допомогою регулярних виразів");
            List<string> regexMatches = FindMatchesRegex(input, pattern);
            if (regexMatches.Count > 0)
            {
                foreach (string match in regexMatches) Console.WriteLine(match);
            }
            else Console.WriteLine("(не знайдено відповідних слів)");

            Console.WriteLine("\nРезультат за допомогою ручного методу");
            List<string> manualMatches = FindMatchesManual(input, pattern);
            if (manualMatches.Count > 0)
            {
                foreach (string match in manualMatches) Console.WriteLine(match);
            }
            else Console.WriteLine("(не знайдено відповідних слів)");
            bool resultsMatch = regexMatches.Count == manualMatches.Count &&
                                new HashSet<string>(regexMatches).SetEquals(manualMatches);
            Console.WriteLine($"\nРезультати обох методів збігаються: {resultsMatch}");
            Console.WriteLine("\nНатисніть Enter, щоб продовжити...");
            Console.ReadLine();
        }
    }
}