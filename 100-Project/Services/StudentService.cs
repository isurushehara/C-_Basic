public class StudentService
{
    private List<Student> students = new();

    public void Add(Student student)
    {
        students.Add(student);
    }

    public void ShowAll()
    {
        foreach (var s in students)
        {
            s.Display();
        }
    }

    public Student? Search(int id)
    {
        return students.FirstOrDefault(x => x.Id == id);
    }

    public void Delete(int id)
    {
        var student = Search(id);

        if (student != null)
            students.Remove(student);
    }

    public void Sort()
    {
        students = students
            .OrderBy(x => x.Name)
            .ToList();
    }

    public double AverageGpa()
    {
        return students.Average(x => x.GPA);
    }

    public async Task SaveAsync()
    {
        await File.WriteAllTextAsync(
            "students.txt",
            string.Join(Environment.NewLine,
                students.Select(x =>
                    $"{x.Id},{x.Name},{x.Age},{x.GPA}")));
    }
}