﻿using System;

namespace practiceA
{
    class Program
    {
        private static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            
            string[] input = Console.ReadLine().Split();
            int b = int.Parse(input[0]);
            int c = int.Parse(input[1]);

            string s = Console.ReadLine();
            
            Console.WriteLine((a + b + c) + " " + s);

        }
    }
}