using System;
using System.Collections.Generic;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    private int speed = 0;

    public void Accelerate(int amount)
    {
        speed += amount;
        Console.WriteLine($"Accelerating {Make} {Model} to {speed} km/h");
    }

    public void Brake(int amount)
    {
        speed = Math.Max(0, speed - amount);
        Console.WriteLine($"Braking {Make} {Model} to {speed} km/h");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Car: {Year} {Make} {Model}, Current Speed: {speed} km/h");
    }
}

public class Employer
{
    public string Name { get; set; }
    public string Company { get; set; }
    public string Position { get; set; }
    private List<string> employees = new List<string>();

    public void Hire(string employeeName)
    {
        employees.Add(employeeName);
        Console.WriteLine($"{employeeName} hired by {Name}");
    }

    public void DisplayTeam()
    {
        Console.WriteLine($"\nTeam under {Name} ({Position} at {Company}):");
        foreach (var employee in employees)
        {
            Console.WriteLine("- " + employee);
        }
    }
}

public class Student
{
    public string Name { get; set; }
    public string School { get; set; }
    public int Grade { get; set; }
    private List<string> courses = new List<string>();

    public void Enroll(string courseName)
    {
        courses.Add(courseName);
        Console.WriteLine($"{Name} enrolled in {courseName}");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"\nStudent: {Name}, Grade: {Grade} at {School}");
        Console.WriteLine("Courses:");
        foreach (var course in courses)
        {
            Console.WriteLine("- " + course);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Car example
        var myCar = new Car();
        myCar.Make = "Toyota";
        myCar.Model = "Camry";
        myCar.Year = 2022;
        myCar.DisplayInfo();
        myCar.Accelerate(30);
        myCar.Accelerate(20);
        myCar.Brake(10);
        myCar.DisplayInfo();

        // Employer example
        var manager = new Employer();
        manager.Name = "John Smith";
        manager.Company = "Tech Solutions";
        manager.Position = "IT Manager";
        manager.Hire("Alice Johnson");
        manager.Hire("Bob Williams");
        manager.DisplayTeam();

        // Student example
        var student = new Student();
        student.Name = "Emma Watson";
        student.School = "Harvard University";
        student.Grade = 3;
        student.Enroll("Computer Science 101");
        student.Enroll("Mathematics");
        student.DisplayInfo();

        Console.ReadKey();
    }
}