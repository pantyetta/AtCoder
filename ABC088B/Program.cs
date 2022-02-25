using System;

namespace ABC088B
{
    class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ');

            var card = new int[n];
            var alice = 0;
            var bob = 0;

            for (var i = 0; i < input.Length; i++)
            {
                card[i] = int.Parse(input[i]);
            }

            input = null;

            for (var i = 0; i < n; i++)
            {
                for (var j = n - 1; j > i; j--)
                {
                    if (card[i] < card[j])
                    {
                        (card[i], card[j]) = (card[j], card[i]);
                    }
                }
            }

            for (var i = 0; i < card.Length; i++)
            {
                if (i % 2 == 0)
                    alice += card[i];
                else
                    bob += card[i];
            }
            
            Console.WriteLine(alice - bob);
        }
    }
    
}