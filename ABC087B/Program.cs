using System;

namespace ABC087B
{
    class Program
    {
        private static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());

            var count = 0;
            
            for (var i = 0; i <= a; i++)
            {
                for (var j = 0; j <= b; j++)
                {
                    for (var k = 0; k <= c; k++)
                    {
                        if (i * 500 + j * 100 + k * 50 == x)
                            count++;
                    }
                }
            }
            
            Console.WriteLine(count);
        }
    }
    
}