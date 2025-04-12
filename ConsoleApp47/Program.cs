using System;

namespace ConsoleApp47
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("\nОберіть дію:");
                Console.WriteLine("1.Перший блок");
                Console.WriteLine("2.Другий блок");
                Console.WriteLine("3.Додаткові завдання");
                Console.WriteLine("0. Вихід");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Оберіть студента");
                        Console.WriteLine("1.Оля");
                        Console.WriteLine("2.Ліза");
                        Console.WriteLine("3.Настя");
                        int studentChoice1 = int.Parse(Console.ReadLine());
                        switch(studentChoice1)
                        {
                            case 1:
                                Console.WriteLine("Виконую завдання Олі");
                                Methods.Block1Olia();
                                break;
                            case 2:
                                Console.WriteLine("Виконую завдання Лізи");
                                Methods.Block1Lisa();
                                break;
                            case 3:
                                Console.WriteLine("Виконую завдання Насті");
                                Methods.Block1Nastia();
                                break;
                            default:
                                Console.WriteLine("Некоректний вибір студента!");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Оберіть студента");
                        Console.WriteLine("1.Оля - 8 варіант");
                        Console.WriteLine("2.Ліза - 13 варіант");
                        Console.WriteLine("3.Настя - 10 варіант");
                        int studentChoice2 = int.Parse(Console.ReadLine());
                        switch (studentChoice2)
                        {
                            case 1:
                                Console.WriteLine("Виконую завдання Олі");
                                Methods.Block2Olia();
                                break;
                            case 2:
                                Console.WriteLine("Виконую завдання Лізи");
                                Methods.Block2Lisa();
                                break;
                            case 3:
                                Console.WriteLine("Виконую завдання Насті");
                                Methods.Block2Nastia();
                                break;
                            default:
                                Console.WriteLine("Некоректний вибір студента!");
                                break;
                        }
                        break;
                    case 0:
                        Console.WriteLine("Вихід із програми...");
                        isTrue = false;
                        break;

                    default:
                        Console.WriteLine("Некоректний вибір! Спробуйте ще раз.");
                        break;
                }
            }
        }
    }
}