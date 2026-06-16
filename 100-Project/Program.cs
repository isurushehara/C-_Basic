StudentService service = new();

StudentEvents events = new();

events.StudentAdded += () =>
{
    Console.WriteLine("Student successfully added.");
};

Log logger = Logger.Print;

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1 Add");
    Console.WriteLine("2 View");
    Console.WriteLine("3 Search");
    Console.WriteLine("4 Delete");
    Console.WriteLine("5 Sort");
    Console.WriteLine("6 Average GPA");
    Console.WriteLine("7 Save");
    Console.WriteLine("8 Exit");

    string? choice = Console.ReadLine();

    try
    {
        switch (choice)
        {
            case "1":

                Console.Write("Id : ");

                int id = int.Parse(Console.ReadLine()!);

                Console.Write("Name : ");

                string name = Console.ReadLine()!;

                Console.Write("Age : ");

                int age = int.Parse(Console.ReadLine()!);

                Console.Write("GPA : ");

                double gpa = double.Parse(Console.ReadLine()!);

                Student student =
                    new(id, name, age, gpa);

                service.Add(student);

                events.Raise();

                logger("Added Student");

                break;

            case "2":

                service.ShowAll();

                break;

            case "3":

                Console.Write("Id : ");

                var s = service.Search(
                    int.Parse(Console.ReadLine()!));

                if (s != null)
                    s.Display();

                break;

            case "4":

                Console.Write("Id : ");

                service.Delete(
                    int.Parse(Console.ReadLine()!));

                break;

            case "5":

                service.Sort();

                break;

            case "6":

                Console.WriteLine(
                    service.AverageGpa());

                break;

            case "7":

                await service.SaveAsync();

                Console.WriteLine("Saved");

                break;

            case "8":

                return;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}