using System;

namespace _200922
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Írás");
            for (int i = 0; i < 100; i++)
            {
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.SetCursorPosition(rnd.Next( Console.WindowWidth), rnd.Next(Console.WindowHeight));
                Console.Write("*");
            }
            Console.ReadKey(true);
        }
    }
}
