using System;
using System.Diagnostics;

namespace ConsoleApp47
{
    internal class TimeBlock1Olia
    {
        public static void TestPerformance()
        {
            int[] testCases = { 10000, 20000, 50000, 100000, 200000 };

            Console.Clear();
            Console.WriteLine("Тестування продуктивності (часу виконання):");

            foreach (int n in testCases)
            {
                Console.WriteLine($"\nТест для n = {n}:");


                MeasureExecutionTime("Version1", n, InputOlia.Version1);
                MeasureExecutionTime("Version2", n, InputOlia.Version2);
                MeasureExecutionTime("Version3", n, InputOlia.Version3);
                MeasureExecutionTime("Version4", n, InputOlia.Version4);
            }

            Console.WriteLine("\nНатисніть Enter, щоб повернутися в головне меню...");
            Console.ReadLine();
        }

        private static void MeasureExecutionTime(string versionName, int n, Func<int, string> versionMethod)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            versionMethod(n); // Виклик методу
            stopwatch.Stop();

            Console.WriteLine($"{versionName}: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}