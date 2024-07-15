using System;

//Creating the interface IQuittable
public interface IQuittable
{
    void Quit();
}

// Modifying the Employee class to implement IQuittable
public class Employee : IQuittable
{
    // Employee class properties
    public string Name { get; set; }
    public int EmployeeId { get; set; }

    // Constructor
    public Employee(string name, int employeeId)
    {
        Name = name;
        EmployeeId = employeeId;
    }

    // Implement the Quit method from IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"{Name} has quit the job.");
        // Additional logic for quitting can be added here
    }
}

class Program
{
    static void Main()
    {
        // Useing polymorphism to create an object of type IQuittable
        IQuittable quittableEmployee = new Employee("Tuka", 123);

        // Call the Quit method using the IQuittable reference
        quittableEmployee.Quit();

        // Keep the console window open until a key is pressed
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
