using System;
namespace GenerateSumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0;
            Console.Write("Enter a Number : ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                Console.Write("Please Enter Positive Number");
            }
            else
            {
                while (number > 0)
                {
                    sum += number;
                    number -= 1;
                }
            }
            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}

using System;

namespace CalculateSumAndAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, avg = 0;

            // Array of numbers
            double[] numbers = { 10, 20, 50, 40 };

            // Loop through the array and calculate the sum
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            // Calculate the average
            avg = sum / numbers.Length;

            // Print the sum and average to the console
            Console.WriteLine("The Sum is: " + sum);
            Console.WriteLine("The Average is: " + avg);

            // Wait for a key press before exiting the program
            Console.ReadKey();
        }
    }
}
