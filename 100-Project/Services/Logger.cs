public delegate void Log(string message);

public class Logger
{
    public static void Print(string message)
    {
        Console.WriteLine($"LOG : {message}");
    }
}