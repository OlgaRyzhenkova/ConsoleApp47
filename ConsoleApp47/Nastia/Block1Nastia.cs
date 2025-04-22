using System;
using System.Text;

namespace ConsoleApp47
{
    class SequenceBuilder
    {
        public static string Input1(int n)
        {
            string output1 = "";
            for (int i = 1; i <= n; i++)
                {
                    output1 += i + " ";
                }
            return output1.Trim();
        }

        public static string Input2(int n)
        {
            string output2 = "";
            for (int i = n; i >= 1; i--)
                {
                    output2 = i + " " + output2;
                }
            return output2.Trim();
        }

        public static string Input3(int n)
        {
            StringBuilder output3 = new StringBuilder();
            for (int i = 1; i <= n; i++)
                {
                    output3.Append(i).Append(" ");
                }
            return output3.ToString().Trim();
        }

        public static string Input4(int n)
        {
            StringBuilder output4 = new StringBuilder();
            for (int i = n; i >= 1; i--)
                {
                    output4.Insert(0, i + " ");
                }
            return output4.ToString().Trim();
        }
    }
}
