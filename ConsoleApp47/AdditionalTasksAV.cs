using System;

namespace ConsoleApp47
{
    class AdditionalTasksAV
    {
        public static void Run()
        {
            Console.Write("Введіть рядок: ");
            string input = Console.ReadLine();

            int balance = 0;
            bool correct = true;

            foreach (char ch in input)
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
                        correct = false;
                        break;
                    }
                }
            }

            if (balance != 0)
                correct = false;

            Console.WriteLine(correct ? "Правильна розстановка дужок." : "Неправильна розстановка дужок.");
            Console.WriteLine("\nНатисніть Enter для продовження...");
            Console.ReadLine();
        }
    }
}
