public class Student : Person
{
    private double _gpa;

    public double GPA
    {
        get => _gpa;

        set
        {
            if (value >= 0 && value <= 4)
                _gpa = value;
        }
    }

    public Student()
    {

    }

    public Student(int id, string name, int age, double gpa)
    {
        Id = id;
        Name = name;
        Age = age;
        GPA = gpa;
    }

    public override void Display()
    {
        Console.WriteLine($"{Id} {Name} {Age} {GPA}");
    }
}