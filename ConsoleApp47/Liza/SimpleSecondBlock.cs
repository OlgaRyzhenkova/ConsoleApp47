using System;

namespace ProjectForLaba4
{
    class SimpleCode
    {
        public static void VayBlock()
        {
            Console.WriteLine("Введіть рядок тексту:");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Ви не ввели текст.");
                return;
            }

            string output = ReplacePrepositions(input);
            Console.WriteLine("\nВиправлений текст:");
            Console.WriteLine(output);

            Console.WriteLine("\nНатисніть Enter, щоб продовжити...");
            Console.ReadLine();
        }
        static string ReplacePrepositions(string text)
        {
            string[] words = text.Split(' ');
            for (int i = 1; i < words.Length - 1; i++)
            {
                if ((words[i] == "в" || words[i] == "у") &&
                    words[i - 1].Length > 0 && words[i + 1].Length > 0)
                {
                    char lastCharPrev = words[i - 1][^1];
                    char firstCharNext = words[i + 1][0];

                    if (IsConsonant(lastCharPrev) && IsConsonant(firstCharNext) && words[i] == "в")
                    {
                        words[i] = "у";
                    }
                    else if (IsVowel(lastCharPrev) && IsVowel(firstCharNext) && words[i] == "у")
                    {
                        words[i] = "в";
                    }
                }
            }
            return string.Join(" ", words);
        }
        static bool IsConsonant(char c)
        {
            return "бвгґджзйклмнпрстфхцчшщ".Contains(Char.ToLower(c));
        }

        static bool IsVowel(char c)
        {
            return "аеєиіїоуюя".Contains(Char.ToLower(c));
        }
    }
}
