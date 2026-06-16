using System;

int a = 10;
int b = 3;

Console.WriteLine("Arithmetic");

Console.WriteLine(a + b);
Console.WriteLine(a - b);
Console.WriteLine(a * b);
Console.WriteLine(a / b);
Console.WriteLine(a % b);

Console.WriteLine();

Console.WriteLine("Comparison");

Console.WriteLine(a == b);
Console.WriteLine(a != b);
Console.WriteLine(a > b);
Console.WriteLine(a < b);

Console.WriteLine();

Console.WriteLine("Logical");

bool x = true;
bool y = false;

Console.WriteLine(x && y);
Console.WriteLine(x || y);
Console.WriteLine(!x);

Console.WriteLine();

Console.WriteLine("Assignment");

a += 5;

Console.WriteLine(a);

a--;

Console.WriteLine(a);

a++;

Console.WriteLine(a);