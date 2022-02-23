/*
問題文
黒板に N 個の正の整数 A1,...,An が書かれています．

すぬけ君は，黒板に書かれている整数がすべて偶数であるとき，次の操作を行うことができます．

黒板に書かれている整数すべてを，2 で割ったものに置き換える．
すぬけ君は最大で何回操作を行うことができるかを求めてください．
*/
/*
ex)
3
8 12 40
----------
2

1回目
4 6 20
2回目
2 3 10
 */

using System;

namespace ABC081B
{
    class Program
    {
        private static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split(' ');
            var flag = true;
            var count = 0;
                
            while (flag)
            {
                for (var i = 0; i < n; i++)
                {
                    if (int.Parse(input[i]) % 2 != 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag){
                    for (var i = 0; i < n; i++)
                    {
                        input[i] = (int.Parse(input[i]) / 2).ToString();
                    }
                }
                else
                {
                    Console.WriteLine(count);
                    break;
                }
                count++;
            }
        }
    }
}