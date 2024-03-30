using System;

public class Program
{
    public class Student
    {
        public string Name { get; set; }
        public int Mark { get; set; }
        public double CarryMark => Mark * 0.6;
    }

    static void Main(string[] args)
    {
        var students = new[]
        {
            new Student { Name = "Student 1", Mark = 67 },
            new Student { Name = "Student 2", Mark = 55 },
            new Student { Name = "Student 3", Mark = 89 },
            new Student { Name = "Student 4", Mark = 34 }
        };

        Console.WriteLine("┌───────────┬──────┬────────────┐");
        Console.WriteLine("│ Student   │ Mark │ Carry Mark │");
        Console.WriteLine("├───────────┼──────┼────────────┤");

        foreach (var student in students)
        {
            Console.WriteLine($"│ {student.Name,-10}│ {student.Mark,-5}│  {student.CarryMark,-10:F2}│");
            Console.WriteLine("├───────────┼──────┼────────────┤");
        }

        Console.ReadLine();
    }
}
