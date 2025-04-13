using System;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp47
{
    public class PerformanceTester
    {
        static void MeasureTime(Func<int, string> methodToRun, int n, string methodName)
        {
            Console.WriteLine($"  Вимірювання часу для {methodName} при n = {n}...");
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Restart();
            string result = methodToRun(n);
            stopwatch.Stop();

            long milliseconds = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"    {methodName}\t{n}\t{milliseconds} мс");
        }

        public void Test()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] nValues = { 10000, 20000, 50000, 100000, 200000 };

            foreach (int n in nValues)
            {
                Console.WriteLine($"\n===== Тест для n = {n} =====");

                MeasureTime(SequenceBuilder.Input1, n, "Input1 (+= кінець)");

                if (n <= 20000)
                {
                    MeasureTime(SequenceBuilder.Input2, n, "Input2 (+ початок)");
                }
                else
                {
                    Console.WriteLine($"    Пропуск Input2 при n = {n} (занадто довго)");
                }

                MeasureTime(SequenceBuilder.Input3, n, "Input3 (StringBuilder.Append)");

                if (n <= 100000)
                {
                    MeasureTime(SequenceBuilder.Input4, n, "Input4 (StringBuilder.Insert)");
                }
                else
                {
                    Console.WriteLine($"    Пропуск Input4 при n = {n} (занадто повільно)");
                }

                Console.WriteLine($"===== Завершено для n = {n} =====");
            }

            Console.WriteLine("\nВсі вимірювання завершено. Натисніть Enter для завершення.");
            Console.ReadLine();
        }
    }
}
