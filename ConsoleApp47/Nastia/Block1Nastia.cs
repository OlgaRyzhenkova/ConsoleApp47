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
                output1 += i;
                if (i < n)
                {
                    output1 += " ";
                }
            }
            return output1;
        }

        public static string Input2(int n)
        {
            string output2 = "";
            for (int i = n; i >= 1; i--)
            {
                if (output2 == "")
                {
                    output2 = i.ToString();
                }
                else
                {
                    output2 = i + " " + output2;
                }
            }
            return output2;
        }

        public static string Input3(int n)
        {
            StringBuilder output3 = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                output3.Append(i);
                if (i < n)
                {
                    output3.Append(" ");
                }
            }
            return output3.ToString();
        }

        public static string Input4(int n)
        {
            StringBuilder output4 = new StringBuilder();
            for (int i = n; i >= 1; i--)
            {
                if (output4.Length == 0)
                {
                    output4.Insert(0, i);
                }
                else
                {
                    output4.Insert(0, i + " ");
                }
            }
            return output4.ToString();
        }
    }
}
