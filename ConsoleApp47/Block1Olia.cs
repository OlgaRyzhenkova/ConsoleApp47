using System;
using System.Text;

namespace ConsoleApp47
{
    class InputOlia
    {
        public static string Block1Olia(int n)
        {
            StringBuilder results = new StringBuilder();

            results.AppendLine("Результат першої версії:");
            results.AppendLine(Version1(n));
            results.AppendLine("Результат другої версії:");
            results.AppendLine(Version2(n));
            results.AppendLine("Результат третьої версії:");
            results.AppendLine(Version3(n));
            results.AppendLine("Результат четвертої версії:");
            results.AppendLine(Version4(n));

            return results.ToString();
        }

        public static string Version1(int n)
        {
            string result1 = "";
            for (int i = 1; i <= n; i++)
            {
                result1 += i + " ";
            }
            return result1.Trim();
        }

        public static string Version2(int n)
        {
            string result2 = "";
            for (int i = n; i >= 1; i--)
            {
                result2 = i + " " + result2;
            }
            return result2.Trim();
        }

        public static string Version3(int n)
        {
            StringBuilder result3 = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                result3.Append(i).Append(" ");
            }
            return result3.ToString().Trim();
        }

        public static string Version4(int n)
        {
            StringBuilder result4 = new StringBuilder();
            for (int i = n; i >= 1; i--)
            {
                result4.Insert(0, i + " ");
            }
            return result4.ToString().Trim();
        }
    }
}