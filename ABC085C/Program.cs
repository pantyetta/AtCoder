using System;

namespace ABC085C
{
    class Program
    {
        private static void Main(string[] args)
        {
            var a = -1;
            var b = -1;
            var c = -1;
            
            var input = Console.ReadLine().Split(' ');
            var n = int.Parse(input[0]);
            var y = int.Parse(input[1]);

            for (var i = 0; i <= n; i++)
            {
                for (var j = 0; i + j <= n; j++)
                {
                    var otoshidama = (i * 10000) + (j * 5000) + ((n - (i + j)) * 1000);
                    if (otoshidama == y)
                    {
                        a = i;
                        b = j;
                        c = n - (i + j);
                    }
                }
            }
            
            Console.WriteLine($"{a} {b} {c}");
        }
    }
}
