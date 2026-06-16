using System;

Console.Write("Enter your name: ");
string? name = Console.ReadLine();

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine()!);

Console.WriteLine();
Console.WriteLine($"Hello {name}");
Console.WriteLine($"You are {age} years old.");