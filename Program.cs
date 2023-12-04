
using System;
using System.Collections.Generic;

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
        Console.WriteLine("Objects in Stack: ");
        foreach (var employee in employeeStack)
        {
            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
            Console.WriteLine($"Items left on the stack: {employeeStack.Count}");
        }

        // Poping all objects from the stack
        Console.WriteLine("\nObjects popped from Stack: ");
        while (employeeStack.Count > 0)
        {
            var poppedEmployee = employeeStack.Pop();
            Console.WriteLine($"Id: {poppedEmployee.Id}, Name: {poppedEmployee.Name}, Gender: {poppedEmployee.Gender}, Salary: {poppedEmployee.Salary}");
            Console.WriteLine($"Items left on the stack: {employeeStack.Count}");
        }

        // Pushing all objects in the stack again
        employeeStack.Push(employee1);
        employeeStack.Push(employee2);
        employeeStack.Push(employee3);
        employeeStack.Push(employee4);
        employeeStack.Push(employee5);


        // Get object using Peek method
        Console.WriteLine("\nPeeking two objects from Stack:");
        for (int i = 0; i < 2; i++)
        {
            Employee employee = employeeStack.Peek();
            Console.WriteLine(employee);
            Console.WriteLine($"Items left on the stack: {employeeStack.Count}");
        }

        // Checking whether object number 3 is in the stack

        var targetEmployee = employee3;
        Console.WriteLine($"\nChecking if employee 3, {employee3.Name}, object exists in the stack or not:");
        if (employeeStack.Contains(targetEmployee))
        {
            Console.WriteLine($"{targetEmployee.Name} object exists in the stack");
        }
        else
        {
            Console.WriteLine($"{targetEmployee.Name} object does not exist in the stack");
        }



        // Part-2: Creating List

        // Part 2 - List
        List<Employee> employeeList = new List<Employee>
        {
            employee1, employee2, employee3, employee4, employee5
        };

        // Checking if Employee2 object exists in the list
        var containsEmployee2 = employeeList.Contains(employee2);
        Console.WriteLine($"\nEmployee2 {(containsEmployee2 ? "exists" : "does not exist")} in the list");

        // Finding and printing the first item in the list with Gender = "Male"
        var firstMaleEmployee = employeeList.Find(e => e.Gender == "Male");
        Console.WriteLine($"\nFirst male Employee in the list: Id: {firstMaleEmployee.Id}, Name: {firstMaleEmployee.Name}, Gender: {firstMaleEmployee.Gender}, Salary: {firstMaleEmployee.Salary}");

        // Finding and printing all items in the list with Gender = "Male"
        var maleEmployees = employeeList.FindAll(e => e.Gender == "Male");
        Console.WriteLine("\nAll male Employees in the list: ");
        foreach (var maleEmployee in maleEmployees)
        {
            Console.WriteLine($"Id: {maleEmployee.Id}, Name: {maleEmployee.Name}, Gender: {maleEmployee.Gender}, Salary: {maleEmployee.Salary}");
        }

        // Finding and printing the first item in the list with Gender = "Female"
        var firstfemaleEmployee = employeeList.Find(e => e.Gender == "Female");
        Console.WriteLine($"\nFirst female Employee in the list: Id: {firstfemaleEmployee.Id}, Name: {firstfemaleEmployee.Name}, Gender: {firstfemaleEmployee.Gender}, Salary: {firstfemaleEmployee.Salary}");

        // Finding and printing all items in the list with Gender = "Female"
        var femaleEmployees = employeeList.FindAll(e => e.Gender == "Female");
        Console.WriteLine("\nAll Female Employees in the list: ");
        foreach (var femaleEmployee in femaleEmployees)
        {
            Console.WriteLine($"Id: {femaleEmployee.Id}, Name: {femaleEmployee.Name}, Gender: {femaleEmployee.Gender}, Salary: {femaleEmployee.Salary}");
        }
        Console.ReadLine();
    }
}

