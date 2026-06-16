using System;
using System.Collections.Generic;

List<string> students = new();

students.Add("John");
students.Add("Mike");
students.Add("Sara");

foreach (string student in students)
{
    Console.WriteLine(student);
}

Console.WriteLine();

Dictionary<int, string> employee = new();

employee.Add(1, "Alex");
employee.Add(2, "Bob");

foreach (var item in employee)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}

Console.WriteLine();

Queue<int> queue = new();

queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);

Console.WriteLine(queue.Dequeue());

Console.WriteLine();

Stack<int> stack = new();

stack.Push(1);
stack.Push(2);
stack.Push(3);

Console.WriteLine(stack.Pop());