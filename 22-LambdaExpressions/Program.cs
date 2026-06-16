// Traditional method
int Square(int x)
{
    return x * x;
}

Console.WriteLine(Square(5));

// Lambda expression
Func<int, int> square = x => x * x;
Console.WriteLine(square(5));

Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(10, 20));