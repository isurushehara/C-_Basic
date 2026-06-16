using System;

Console.WriteLine("For Loop");

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine();

Console.WriteLine("While Loop");

int x = 1;

while (x <= 5)
{
    Console.WriteLine(x);
    x++;
}

Console.WriteLine();

Console.WriteLine("Do While");

int y = 1;

do
{
    Console.WriteLine(y);
    y++;

} while (y <= 5);

Console.WriteLine();

string[] names =
{
    "John",
    "Mike",
    "Sara"
};

foreach (string name in names)
{
    Console.WriteLine(name);
}