using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: "); // Enter integer

            // Try to parse the user input to an integer
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                // Check if the number is even or odd
                if (num % 2 == 0)
                {
                    Console.WriteLine(num + " is even.");
                }
                else
                {
                    Console.WriteLine($"{num} is odd.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            Console.ReadLine(); // Display
        }
    }
}
