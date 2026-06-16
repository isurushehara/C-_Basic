using System;

PrintWelcome();

int answer = Add(5, 10);

Console.WriteLine(answer);

double area = CalculateArea(5);

Console.WriteLine(area);

PrintUser("John");

PrintUser();

void PrintWelcome()
{
    Console.WriteLine("Welcome");
}

int Add(int a, int b)
{
    return a + b;
}

double CalculateArea(double radius)
{
    return 3.14 * radius * radius;
}

void PrintUser(string name = "Guest")
{
    Console.WriteLine(name);
}