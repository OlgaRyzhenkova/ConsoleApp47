using System;

namespace ProjectForLaba4
{
    class SimpleCode
    {
        public static void VayBlock()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

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
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "в" || words[i] == "у")
                {
                    char? lastCharPrev = i > 0 ? GetLastLetter(words[i - 1]) : null;
                    char? firstCharNext = i < words.Length - 1 ? GetFirstLetter(words[i + 1]) : null;

                    if (lastCharPrev.HasValue && firstCharNext.HasValue)
                    {
                        if (IsConsonant(lastCharPrev.Value) && IsConsonant(firstCharNext.Value) && words[i] == "в")
                        {
                            words[i] = "у";
                        }
                        else if (IsVowel(lastCharPrev.Value) && IsVowel(firstCharNext.Value) && words[i] == "у")
                        {
                            words[i] = "в";
                        }
                    }
                    else if (!lastCharPrev.HasValue && firstCharNext.HasValue)
                    {
                        if (IsVowel(firstCharNext.Value) && words[i] == "у")
                            words[i] = "в";
                        else if (IsConsonant(firstCharNext.Value) && words[i] == "в")
                            words[i] = "у";
                    }
                }
            }
            return string.Join(" ", words);
        }

        static char? GetFirstLetter(string word)
        {
            foreach (char c in word)
            {
                if (char.IsLetter(c)) return c;
            }
            return null;
        }

        static char? GetLastLetter(string word)
        {
            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (char.IsLetter(word[i])) return word[i];
            }
            return null;
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
