﻿namespace Lab_7_OOP_Generic_collections
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// PART 1 - STACK
			Console.WriteLine("PART 1 - STACK");
			// creates a new stack
			Stack<Employee> stack = new Stack<Employee>();

			// pushes five employees onto the stack
			stack.Push(new Employee(1,"Andrew", "male", 42000));
			stack.Push(new Employee(2, "Brenda", "female", 45000));
			stack.Push(new Employee(3, "Carl", "male", 37000));
			stack.Push(new Employee(4, "Diane", "female", 36000));
			stack.Push(new Employee(5, "Eric", "male", 38000));

            // writes a for loop that iterates through the stack
            // and prints each employee
            Console.WriteLine("\nRetrieving using a for loop");
			for (int i = 0; i < stack.Count; i++)
			{
				Console.WriteLine(stack.ElementAt(i).ToString());
                Console.WriteLine($"Items left in the Stack = {stack.Count - i - 1}");
			}
			
			// writes a pop loop that removes each employee from the stack
			Console.WriteLine("\nRetrieving using Pop() method");
			while (stack.Count > 0)
			{
				Console.WriteLine(stack.Pop().ToString());
				// prints the number of items left in the stack
				Console.WriteLine($"Items left in the Stack = {stack.Count}");
			}

			// pushes the five employees back onto the stack
			stack.Push(new Employee(1, "Andrew", "male", 42000));
			stack.Push(new Employee(2, "Brenda", "female", 45000));
			stack.Push(new Employee(3, "Carl", "male", 37000));
			stack.Push(new Employee(4, "Diane", "female", 36000));
			stack.Push(new Employee(5, "Eric", "male", 38000));

			// retrieves two objects from the stack using a peek loop
			Console.WriteLine("\nRetrieving using Peek() method");
			for (int i = 0; i < 2; i++)
			{
				Employee topEmployee = stack.Peek();
				Console.WriteLine($"Peek object {i + 1}: {topEmployee}");
				Console.WriteLine($"Items left in the Stack = {stack.Count}");
			}

			// check if object number 3 exists in the stack
			Console.WriteLine("\nChecking if object number 3 exists in the Stack");
			if (stack.Contains(new Employee(3, "Carl", "male", 37000)))
			{
				Console.WriteLine("Employee number 3 exists in the Stack");
			}

			// PART 2 - LIST
			// creates a new list
			Console.WriteLine("PART 2 - LIST");
			List<Employee> list = new List<Employee>();
			list.Add(new Employee(1, "Andrew", "male", 42000));
			list.Add(new Employee(2, "Brenda", "female", 45000));
			list.Add(new Employee(3, "Carl", "male", 37000));
			list.Add(new Employee(4, "Diane", "female", 36000));
			list.Add(new Employee(5, "Eric", "male", 38000));

			// creates an if statement that uses Contains() to check if a specific employee exists in the list
			if (list.Contains(new Employee(2, "Brenda", "female", 45000)))
			{
				Console.WriteLine("\nEmployee 2 exists in the list");
			}
			else
			{
				Console.WriteLine("\nEmployee 2 does not exist in the list");
			}

			// use Find() to find the first male employee in the list
			Employee firstMaleEmployee = list.Find(employee => employee.Gender == "male");
			Console.WriteLine($"\nFirst male employee in the list: {firstMaleEmployee}");

			// use FindAll() to find all male employees in the list
			List<Employee> allMaleEmployees = list.FindAll(employee => employee.Gender == "male");
			Console.WriteLine("\nAll male employees in the list:");
			foreach (Employee employee in allMaleEmployees)
			{
				Console.WriteLine(employee);
			}
		}
	}
}
