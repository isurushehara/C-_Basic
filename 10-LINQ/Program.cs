using System;
using System.Linq;

List<int> numbers = new()
{
    1,
    2,
    3,
    4,
    5,
    6,
    7,
    8,
    9,
    10
};

var even = numbers.Where(n => n % 2 == 0);

foreach (var n in even)
{
    Console.WriteLine(n);
}

Console.WriteLine();

var squares = numbers.Select(n => n * n);

foreach (var n in squares)
{
    Console.WriteLine(n);
}

Console.WriteLine();

var descending = numbers.OrderByDescending(x => x);

foreach (var n in descending)
{
    Console.WriteLine(n);
}