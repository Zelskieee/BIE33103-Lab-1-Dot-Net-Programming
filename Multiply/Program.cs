using System;

namespace MultiplyTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1, var2, prod;
            Console.Write("Enter number 1: ");
            var1 = Int32.Parse(Console.ReadLine()); // READ NUMBER 1 AND PARSE TO INT
            Console.Write("Enter number 2: ");
            var2 = Convert.ToInt32(Console.ReadLine()); // READ NUMBER 2 AND CONVERT TO INT
            prod = var1 * var2;
            Console.WriteLine("The result: " + prod);

            Console.ReadLine(); // Wait for user input before closing the console window
        }
    }
}
