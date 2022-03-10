using System;

namespace ABC086C
{
    class Program
    {
        private static void Main(string[] args)
        {
            var n =  int.Parse(Console.ReadLine());
            int[] oldPosition = {0, 0, 0};

            var flag = true;
            
            for (var i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var move = (Math.Abs(int.Parse(input[1]) - oldPosition[1]) +
                            Math.Abs(int.Parse(input[2]) - oldPosition[2]));
                var time = (int.Parse(input[0]) - oldPosition[0]);
                
                if (time < move || move % 2 != time % 2)
                {
                    flag = false;
                    break;
                }
                
                oldPosition[0] = int.Parse(input[0]);
                oldPosition[1] = int.Parse(input[1]);
                oldPosition[2] = int.Parse(input[2]);
            }

            Console.WriteLine(flag ? "Yes": "No");
        }
    }
}