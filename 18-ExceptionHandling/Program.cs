using System;

try
{
    Console.Write("Enter number: ");

    int number = int.Parse(Console.ReadLine()!);

    Console.WriteLine(number);
}
catch (FormatException)
{
    Console.WriteLine("Invalid number.");
}
finally
{
    Console.WriteLine("Program Finished.");
}