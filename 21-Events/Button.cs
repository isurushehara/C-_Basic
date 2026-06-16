public class Button
{
    public event Action? Click;

    public void Press()
    {
        Console.WriteLine("Button Pressed");

        Click?.Invoke();
    }
}