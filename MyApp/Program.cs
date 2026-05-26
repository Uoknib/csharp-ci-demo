using System;

namespace MyApp
{
    public class Program
    {
        public static int Add(int a, int b) => a + b;

        static void Main(string[] args)
        {
            Console.WriteLine($"1 + 2 = {Add(1, 2)}");
            Console.WriteLine("All good!");
        }
    }
}
