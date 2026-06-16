using System;

int[] marks =
{
    80,
    90,
    70,
    60,
    100
};

Console.WriteLine(marks[0]);

Console.WriteLine();

foreach (int mark in marks)
{
    Console.WriteLine(mark);
}

Console.WriteLine();

Array.Sort(marks);

foreach (int mark in marks)
{
    Console.WriteLine(mark);
}

Console.WriteLine();

Console.WriteLine($"Length = {marks.Length}");