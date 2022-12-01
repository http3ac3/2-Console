using System;

namespace UP_2._3_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите число строк: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n > 11)
            {
                Console.Write("К вводу достпуны только цифры и знак \"минус\"!Число строк должно быть от 1 до 11\nВведите число строк: ");
            }

            int start = 25;
            for (int i = 0; i < n; i++)
            {
                
                string s = $"{start} {start + 0.5} {start - 0.2}\n";
                s = s.Replace(',', '.');
                Console.WriteLine(s);
                start++;
            }

            start = 25;
            int j = 0;
            Console.WriteLine();
            while (j < n)
            {
                string s = $"{start} {start + 0.5} {start - 0.2}\n";
                s = s.Replace(',', '.');
                Console.WriteLine(s);
                start++;
                j++;
            }

            Console.WriteLine();
            start = 25;
            j = 0;
            do
            {
                string s = $"{start} {start + 0.5} {start - 0.2}\n";
                s = s.Replace(',', '.');
                Console.WriteLine(s);
                start++;
                j++;
            } while (j < n);
        }
    }
}
