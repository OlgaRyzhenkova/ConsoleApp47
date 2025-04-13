using System;
using System.Text;
using System.Diagnostics;

namespace ConsoleApp47
{
    class Input
    {
        public static string Inputs1(int n)
        {
            string result1 = "";
            for (int i = 1; i <= n; i++)
            {
                result1 += i;
                if (i < n)
                {
                    result1 += " ";
                }
            }
            return result1;
        }
        public static string Inputs2(int n)
        {
            string result2 = "";
            for (int i = n; i >= 1; i--)
            {
                if (result2 == "")
                {
                    result2 = i.ToString();
                }
                else
                {
                    result2 = i + " " + result2;
                }
            }
            return result2;
        }
        public static string Inputs3(int n)
        {
            StringBuilder result3 = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                result3.Append(i);
                if (i < n)
                {
                    result3.Append(" ");
                }
            }
            return result3.ToString();
        }
        public static string Inputs4(int n)
        {
            StringBuilder result4 = new StringBuilder();
            for (int i = n; i >= 1; i--)
            {
                if (result4.Length == 0)
                {
                    result4.Insert(0, i);
                }
                else
                {
                    result4.Insert(0, i + " ");
                }
            }
            return result4.ToString();
        }
    }
}