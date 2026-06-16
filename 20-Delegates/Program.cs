using System;

// Without parameters
Message message = Hello;

message();

void Hello()
{
    Console.WriteLine("Hello World");
}

// With parameters
Calculate calculate = Add;

Console.WriteLine(calculate(10, 20));

int Add(int x, int y)
{
    return x + y;
}

// Delegate declarations
delegate void Message();

delegate int Calculate(int a, int b);