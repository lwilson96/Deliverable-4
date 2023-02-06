/*
Author: Lee Wilson
Date: 02/05/2023
Comments: This C# console application code demonstrates the use 
            of arrays after getting input from users
*/
using System;

namespace Deliverable_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25];

            fibonacci[0] = 0;
            fibonacci[1] = 1;
            int d = 0;

            for (int i = 0; i < fibonacci.Length; i++)
            {
                d = i;

                if (i >= 2)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];

                }
                Console.WriteLine("Fibonacci number " + "(" + d + ")" + fibonacci[i]);
            }
        }
    }
}