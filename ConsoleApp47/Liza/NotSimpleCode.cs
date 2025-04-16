using System;
using System.Text;
using System.Linq;

namespace ProjectForLaba4
{
    public class NotSimpleCode
    {
        private static readonly char[] UkrainianVowels = { 'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я' };
        private static bool IsUkrainianVowel(char c)
        {
            return UkrainianVowels.Contains(char.ToLowerInvariant(c));
        }
        private static bool IsUkrainianConsonant(char c)
        {
            char lowerC = char.ToLowerInvariant(c);
            return char.IsLetter(lowerC) && !UkrainianVowels.Contains(lowerC) && lowerC != 'ь';
        }
        public static string CorrectPrepositions(string inputText)
        {
            if (string.IsNullOrEmpty(inputText)) return inputText;
            StringBuilder result = new StringBuilder();
            string[] parts = inputText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < parts.Length; i++)
            {
                string currentPart = parts[i];
                string correctedPart = currentPart;

                if (currentPart.Length == 1 && (currentPart.Equals("в", StringComparison.OrdinalIgnoreCase) ||
                                                currentPart.Equals("у", StringComparison.OrdinalIgnoreCase)))
                {
                    char? prevChar = null;
                    char? nextChar = null;
                    if (i > 0)
                    {
                        string prevWord = parts[i - 1];
                        for (int j = prevWord.Length - 1; j >= 0; j--)
                        {
                            if (char.IsLetter(prevWord[j]))
                            {
                                prevChar = prevWord[j];
                                break;
                            }
                        }
                    }
                    if (i < parts.Length - 1)
                    {
                        string nextWord = parts[i + 1];
                        for (int j = 0; j < nextWord.Length; j++)
                        {
                            if (char.IsLetter(nextWord[j]))
                            {
                                nextChar = nextWord[j];
                                break;
                            }
                        }
                    }

                    bool originalIsV = currentPart.Equals("в", StringComparison.OrdinalIgnoreCase);
                    bool originalIsU = currentPart.Equals("у", StringComparison.OrdinalIgnoreCase);
                    bool prevIsConsonant = prevChar.HasValue && IsUkrainianConsonant(prevChar.Value);
                    bool nextIsConsonant = nextChar.HasValue && IsUkrainianConsonant(nextChar.Value);
                    bool prevIsVowel = prevChar.HasValue && IsUkrainianVowel(prevChar.Value);
                    bool nextIsVowel = nextChar.HasValue && IsUkrainianVowel(nextChar.Value);

                    if (prevChar.HasValue && nextChar.HasValue)
                    {
                        if (originalIsV && prevIsConsonant && nextIsConsonant)
                            correctedPart = char.IsUpper(currentPart[0]) ? "У" : "у";
                        else if (originalIsU && prevIsVowel && nextIsVowel)
                            correctedPart = char.IsUpper(currentPart[0]) ? "В" : "в";
                    }
                    else if (!prevChar.HasValue && nextChar.HasValue)
                    {
                        if (originalIsU && IsUkrainianVowel(nextChar.Value))
                            correctedPart = char.IsUpper(currentPart[0]) ? "В" : "в";
                        else if (originalIsV && IsUkrainianConsonant(nextChar.Value))
                            correctedPart = char.IsUpper(currentPart[0]) ? "У" : "у";
                    }
                }
                result.Append(correctedPart);
                if (i < parts.Length - 1)
                {
                    result.Append(" ");
                }
            }
            return result.ToString();
        }
        public static void NotVayBlock()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Введіть текст:");
            string inputText = Console.ReadLine();
            string correctedText = CorrectPrepositions(inputText);
            Console.WriteLine("\nВиправлений текст:");
            Console.WriteLine(correctedText);
            Console.WriteLine("\nНатисніть Enter, щоб продовжити...");
            Console.ReadLine();
        }
    }
}
