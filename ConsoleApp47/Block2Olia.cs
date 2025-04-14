using System;
using System.Text;

namespace ConsoleApp47
{
    partial class Methods
    {
        public static void Block2Olia()
        {
            Console.WriteLine("Введіть рядок символів:");
            string input = Console.ReadLine();
            string result1 = SimpleString(input);
            Console.WriteLine("Результат без використання StringBuilder:");
            Console.WriteLine(result1);
            string result2 = WithStringBuilder(input);
            Console.WriteLine("Результат з використанням StringBuilder:");
            Console.WriteLine(result2);
        }
        static string SimpleString(string input)
        {
            string result = "";
            foreach( char c in input)
            {
                result += ReplaceChar(c);
            }
            return result;
        }
        static string WithStringBuilder(string input)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                result.Append(ReplaceChar(c));
            }
            return result.ToString();
        }
        static char ReplaceChar(char c) => c switch
        {
            'R' => 'K',
            'S' => 'L',
            'T' => 'M',
            'K' => 'R',
            'L' => 'S',
            'M' => 'T',
            _ => c
        };
    }
}
