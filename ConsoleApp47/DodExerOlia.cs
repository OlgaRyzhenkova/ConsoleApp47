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
                Console.WriteLine("3. Завдання 3");
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
                    case "3":
                        Task3();
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
        static void Task3()
        {
            Console.WriteLine("Виконання завдання 3");
            Console.Write("Введіть рядок: ");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            for (int i = 0; i < parts.Length - 1; i++)
            {
                int number;
                if (int.TryParse(parts[i], out number))
                {
                    string unit = parts[i + 1];
                    if (unit == "м" || unit == "грн")
                    {
                        parts[i] = NumberToWords(number, unit);      // Число словами з урахуванням роду
                        parts[i + 1] = UnitToWords(number, unit);     // Слово "метр" або "гривня" в правильній формі
                    }
                }
            }

            Console.WriteLine("Результат: " + string.Join(" ", parts));
        }

        static string NumberToWords(int number, string unit)
        {
            // Українські словники
            string[] onesMasculine = { "", "один", "два", "три", "чотири", "п’ять", "шість", "сім", "вісім", "дев’ять" };
            string[] onesFeminine = { "", "одна", "дві", "три", "чотири", "п’ять", "шість", "сім", "вісім", "дев’ять" };
            string[] teens = { "десять", "одинадцять", "дванадцять", "тринадцять", "чотирнадцять", "п’ятнадцять", "шістнадцять", "сімнадцять", "вісімнадцять", "дев’ятнадцять" };
            string[] tens = { "", "", "двадцять", "тридцять", "сорок", "п’ятдесят", "шістдесят", "сімдесят", "вісімдесят", "дев’яносто" };
            string[] hundreds = { "", "сто", "двісті", "триста", "чотириста", "п’ятсот", "шістсот", "сімсот", "вісімсот", "дев’ятсот" };

            // Допоміжна функція для формування трійки чисел
            string TripletToWords(int n, bool isFeminine)
            {
                string[] ones = isFeminine ? onesFeminine : onesMasculine;
                int h = n / 100;
                int t = (n / 10) % 10;
                int o = n % 10;

                string result = hundreds[h];

                if (t == 1)
                    result += " " + teens[o];
                else
                {
                    if (t > 1) result += " " + tens[t];
                    if (o > 0) result += " " + ones[o];
                }

                return result.Trim();
            }

            // Розбираємо число по розрядах
            int billions = number / 1_000_000_000;
            int millions = (number / 1_000_000) % 1000;
            int thousands = (number / 1000) % 1000;
            int rest = number % 1000;

            string words = "";

            if (billions > 0)
            {
                words += TripletToWords(billions, false) + " " + GetForm(billions, "мільярд") + " ";
            }
            if (millions > 0)
            {
                words += TripletToWords(millions, false) + " " + GetForm(millions, "мільйон") + " ";
            }
            if (thousands > 0)
            {
                words += TripletToWords(thousands, true) + " " + GetForm(thousands, "тисяча") + " ";
            }
            if (rest > 0 || number == 0)
            {
                words += TripletToWords(rest, unit == "грн");
            }

            return words.Trim();
        }

        // Повертає правильну форму одиниці виміру ("метр", "метри", "метрів" тощо)
        static string UnitToWords(int number, string unit)
        {
            int lastDigit = number % 10;
            int lastTwo = number % 100;

            if (unit == "м")
            {
                if (lastDigit == 1 && lastTwo != 11) return "метр";
                else if (lastDigit >= 2 && lastDigit <= 4 && !(lastTwo >= 12 && lastTwo <= 14)) return "метри";
                else return "метрів";
            }
            else if (unit == "грн")
            {
                if (lastDigit == 1 && lastTwo != 11) return "гривня";
                else if (lastDigit >= 2 && lastDigit <= 4 && !(lastTwo >= 12 && lastTwo <= 14)) return "гривні";
                else return "гривень";
            }

            return unit;
        }

        // Вибирає правильну форму для мільйонів/тисяч/мільярдів
        static string GetForm(int number, string baseWord)
        {
            int lastDigit = number % 10;
            int lastTwo = number % 100;

            if (baseWord == "мільйон" || baseWord == "мільярд")
            {
                if (lastDigit == 1 && lastTwo != 11) return baseWord;
                else if (lastDigit >= 2 && lastDigit <= 4 && !(lastTwo >= 12 && lastTwo <= 14)) return baseWord + "и";
                else return baseWord + "ів";
            }
            else if (baseWord == "тисяча")
            {
                if (lastDigit == 1 && lastTwo != 11) return "тисяча";
                else if (lastDigit >= 2 && lastDigit <= 4 && !(lastTwo >= 12 && lastTwo <= 14)) return "тисячі";
                else return "тисяч";
            }

            return baseWord;
        }
    }
}
