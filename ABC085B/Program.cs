using System;

namespace ABC085B
{
    class Program
    {
        private static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var omochi = new int[N];

            for (int i = 0; i < N; i++)
            {
                omochi[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = N - 1; j > i; j--)
                {
                    if(omochi[i] < omochi[j])
                        (omochi[i], omochi[j]) = (omochi[j], omochi[i]);
                }
            }

            var history = 0;
            var count = 0;
            for (int i = 0; i < N; i++)
            {
                if (omochi[i] != history)
                    count++;
                history = omochi[i];
            }
            
            Console.WriteLine(count);
        }
    }
}
