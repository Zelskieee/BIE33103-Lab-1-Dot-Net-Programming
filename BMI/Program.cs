using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double weight, height;

            Console.WriteLine("BMI Calculator ~ Self-Reflection :) ");

            Console.Write("\nEnter your name : ");
            name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter your weight (in kg) : ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height (in meter): ");
            height = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / Math.Pow(height, 2);

            string category;

            switch (bmi)
            {
                case var n when n < 18.5:
                    category = "Underweight";
                    break;
                case var n when n < 24.9:
                    category = "Healthy weight";
                    break;
                case var n when n < 29.9:
                    category = "Overweight";
                    break;
                default:
                    category = "Obesity";
                    break;
            }

            Console.WriteLine("\n\t- - Result - -");
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Your BMI : " + bmi.ToString("0.00"));
            Console.WriteLine($"BMI Category : {category}");
            Console.ReadLine();
        }
    }
}
