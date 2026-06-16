public class StudentEvents
{
    public event Action? StudentAdded;

    public void Raise()
    {
        StudentAdded?.Invoke();
    }
}