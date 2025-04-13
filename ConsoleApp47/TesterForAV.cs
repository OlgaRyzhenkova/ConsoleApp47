using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp47
{
    public class PerformanceTester
    {
        private (string Method, int N, long Time) TestMethod(Func<int, string> methodToRun, int n, string methodName)
        {
            Console.WriteLine($"  Вимірювання часу для {methodName} при n = {n}...");
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Restart();
            methodToRun(n);
            stopwatch.Stop();

            long milliseconds = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"    {methodName}\t{n}\t{milliseconds} мс");

            return (methodName, n, milliseconds);
        }

        public void Test()
        {
            Console.OutputEncoding = Encoding.UTF8;

            var results = new List<(string Method, int N, long Time)>();
            int[] nValues = { 10000, 20000, 50000, 100000, 200000 };

            foreach (int n in nValues)
            {
                Console.WriteLine($"\n===== Тест для n = {n} =====");

                results.Add(TestMethod(SequenceBuilder.Input1, n, "Input1 (+= кінець)"));

                results.Add(TestMethod(SequenceBuilder.Input2, n, "Input2 (+ початок)"));

                results.Add(TestMethod(SequenceBuilder.Input3, n, "Input3 (Append)"));

                results.Add(TestMethod(SequenceBuilder.Input4, n, "Input4 (+ початок)"));
            }

            Console.WriteLine("\nРезультати:");
            Console.WriteLine("Метод\t\t\tN\tЧас (мс)");
            foreach (var (Method, N, Time) in results)
            {
                string timeDisplay = Time >= 0 ? Time.ToString() : "Пропущено";
                Console.WriteLine($"{Method,-20}\t{N}\t{timeDisplay}");
            }
            Console.WriteLine("\nНатисніть Enter для завершення");
            Console.ReadLine();
        }
    }
}
