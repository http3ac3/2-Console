using System;

namespace Exercise_2._1_Console
{
    internal class Program
    {
        static double NonExceptionInput(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Введите точку {s}: ");
                    double num = double.Parse(Console.ReadLine());
                    return num;
                }
                catch
                {
                    Console.WriteLine("Неверный ввод! Доступен ввод только цифр, запятой и знака \"минус\"\n");
                }
            }
        }
        static void Main(string[] args)
        {
            double x = NonExceptionInput("X");
            double y = NonExceptionInput("Y");

            if ((x * x + y * y < 64 && x <= 0) && (x * x + y * y > 9 && x <= 0))
            {
                Console.WriteLine("Да");
            }
            else if ((x * x + y * y > 64) || (x * x + y * y < 9) || x > 0)
            {
                Console.WriteLine("Нет");
            }
            else
            {
                Console.WriteLine("На границе");
            }
        }
    }
}
