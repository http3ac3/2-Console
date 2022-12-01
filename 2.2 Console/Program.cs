using System;

namespace Exercise_2._2_Console
{
    internal class Program
    {
        static int NonExceptionInput()
        {
            while (true)
            {
                try
                {
                    Console.Write($"Введите номер масти: ");
                    int num = int.Parse(Console.ReadLine());
                    if (num < 1 || num > 4)
                    {
                        Console.WriteLine("Номер масти должен быть от 1 до 4!\n");
                        continue;
                    }
                    return num;
                }
                catch
                {
                    Console.WriteLine("Неверный ввод! Доступен ввод только цифр и знака \"минус\"\n");
                }
            }
        }

        static void Main(string[] args)
        {
            int m = NonExceptionInput();
            switch (m)
            {
                case 1:
                    Console.WriteLine("пики");
                    break;
                case 2:
                    Console.WriteLine("трефы");
                    break;
                case 3:
                    Console.WriteLine("бубны");
                    break;
                case 4:
                    Console.WriteLine("червы");
                    break;
            }
        }
    }
}
