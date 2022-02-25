using System;

namespace ABC083B
{
    class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var n = int.Parse(input[0]);
            var a = int.Parse(input[1]);
            var b = int.Parse(input[2]);

            var totalSum = 0;

            for (var i = 1; i <= n; i++)
            {
                var sum = 0;
                foreach (var number in i.ToString())
                {
                    sum += int.Parse(number.ToString());
                }

                if ((a <= sum) && (sum <= b))
                {
                    totalSum += i;
                }
            }
            
            Console.WriteLine(totalSum);
        }
    }
}