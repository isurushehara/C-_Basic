using System;

Console.Write("Enter your mark: ");

int mark = int.Parse(Console.ReadLine()!);

if (mark >= 75)
{
    Console.WriteLine("Grade A");
}
else if (mark >= 65)
{
    Console.WriteLine("Grade B");
}
else if (mark >= 50)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Fail");
}

Console.WriteLine();

Console.Write("Enter day number: ");

int day = int.Parse(Console.ReadLine()!);

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;

    case 2:
        Console.WriteLine("Tuesday");
        break;

    case 3:
        Console.WriteLine("Wednesday");
        break;

    default:
        Console.WriteLine("Unknown");
        break;
}