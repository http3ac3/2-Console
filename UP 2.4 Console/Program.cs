using System;

namespace UP_2._4_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 41; i <= 80; i++)
            {
                Console.Write(i + " ");
                if (i % 10 == 0) Console.WriteLine();
            }
        }
    }
}
