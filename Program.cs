
using System;

namespace OOP_StackListL8;

class Program
{
    static void Main(string[] args)
    {
        // Part 1 - Creating Stack
        Stack<Employee> employeeStack = new Stack<Employee>();

        // Here pushing five objects into the employee stack
        Employee employee1 = new Employee(1, "Glenn", "Male", 45000);
        employeeStack.Push(employee1);

        Employee employee2 = new Employee(2, "Allan", "Male", 65000);
        employeeStack.Push(employee2);

        Employee employee3 = new Employee(3, "Scarlet", "Female", 50000);
        employeeStack.Push(employee3);

        Employee employee4 = new Employee(4, "Salma", "Female", 50000);
        employeeStack.Push(employee4);

        Employee employee5 = new Employee(5, "Catherina", "Female", 50000);
        employeeStack.Push(employee5);

        
        // Now printing out all the objects in the employee stack
        Console.WriteLine("Objects in Stack:");
        foreach (var employee in employeeStack)
        {
            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
            Console.WriteLine($"Items left on the stack: {employeeStack.Count}");
        }
    }
}

