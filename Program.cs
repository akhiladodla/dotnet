using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        while (true)
        {
            Console.Write("Enter Student Name:");
            string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
                break;

            Student student = new Student();
            student.Name = name;

            Console.Write("Enter Age: ");
            student.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Marks: ");
            student.Marks = int.Parse(Console.ReadLine());

            students.Add(student);

            Console.WriteLine("Student added successfully.\n");
        }

        Console.WriteLine("\n---- Student Results ----");

        foreach (Student s in students)
        {
            Console.WriteLine("Student Name: " + s.Name);
            Console.WriteLine("Age: " + s.Age);
            Console.WriteLine("Marks: " + s.Marks);
            Console.WriteLine("Grade: " + s.GetGrade());
            Console.WriteLine("---------------------------");
        }
    }
}
