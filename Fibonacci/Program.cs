using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, first = 0, second = 1, total;
            int i, next;

            Console.Write("Enter the number of terms for the Fibonacci series: ");
            n = Convert.ToInt32(Console.ReadLine());

            total = first + second;

            Console.WriteLine("Fibonacci series :-");
            Console.Write(first + " " + second + " ");

            for (i = 2; i < n; i++)
            {
                next = first + second;
                total += next;
                Console.Write(next + " ");

                first = second;
                second = next;
            }

            Console.WriteLine("\nSum of the Fibonacci series: " + total);
            Console.ReadLine();
        }
    }
}
