﻿using System;
namespace CalculateSumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, avg = 0;
            double[] numbers = { 10, 20, 50, 40 };
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            avg = sum / numbers.Length;
            Console.WriteLine("The Sum is : " + sum);
            Console.WriteLine("The Average is : " + avg);

            Console.ReadKey();
        }
    }
}
