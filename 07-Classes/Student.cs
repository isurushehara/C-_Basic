public class Student
{
    public string Name { get; set; }

    public int Age { get; set; }

    public void Display()
    {
        Console.WriteLine($"{Name} {Age}");
    }
}