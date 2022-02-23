using System;

namespace ABC086A
{
    class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            Console.WriteLine((a * b) % 2 != 0 ? "Odd" : "Even");
        }
    }
    
}