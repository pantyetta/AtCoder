using System;

namespace ABC081A
{
    class Program
    {
        private static void Main(string[] args)
        {
            var count = 0;
            var input = Console.ReadLine();
            foreach (var t in input)
            {
                if (t == '1')
                    count++;
            }
            
            Console.WriteLine(count);
        }
    }
    
}