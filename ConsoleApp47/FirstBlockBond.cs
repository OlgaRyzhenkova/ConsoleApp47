using ConsoleApp47;
using System;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp47
{
    public class Student
    {
        static void MeasureTime(Func<int, string> methodToRun, int n, string methodName)
        {
            Console.WriteLine($"  Вимірювання часу для {methodName} при n = {n}...");
            Stopwatch stopwatch = new Stopwatch();

            // Вимірювання
            stopwatch.Restart();
            string result = methodToRun(n); // Викликаємо метод і отримуємо результат (але не використовуємо його тут)
            stopwatch.Stop();

            long milliseconds = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"    {methodName}\t{n}\t{milliseconds}");
        }

        public void Test()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Запуск тестів продуктивності ===");
            Console.WriteLine("Формат виведення: Метод\tN\tЧас (мс)");

            int[] nValues = { 10000, 20000, 50000, 100000, 200000 };

            foreach (int n in nValues)
            {
                Console.WriteLine($"\n===== Тестування для n = {n} =====");

                // InputsX повертають string
                MeasureTime(Input.Inputs1, n, "Inputs1 (string, += кінець)");
                if (n <= 20000)
                {
                    MeasureTime(Input.Inputs2, n, "Inputs2 (string, + початок)");
                }
                else
                {
                    Console.WriteLine($"    Пропуск Inputs2 для n = {n} (занадто довго)");
                }

                MeasureTime(Input.Inputs3, n, "Inputs3 (StringBuilder, Append кінець)");
                if (n <= 100000)
                {
                    MeasureTime(Input.Inputs4, n, "Inputs4 (StringBuilder, Insert початок)");
                }
                else
                {
                    Console.WriteLine($"    Пропуск Inputs4 для n = {n} (може бути довго)");
                }
                Console.WriteLine($"===== Завершено n = {n} =====");
            }
            Console.WriteLine("\nУсі вимірювання завершено. Натисніть Enter для виходу.");
        }
    }
}