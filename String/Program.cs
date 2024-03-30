using System;

namespace CountNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            Console.Write("Enter String: ");
            sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');
            Console.WriteLine("Count of words: " + words.Length);
            Console.ReadKey();
        }
    }
}
