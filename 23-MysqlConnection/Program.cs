using Microsoft.Extensions.Configuration;
using MySqlDemo.Models;
using MySqlDemo.Services;

IConfiguration config =
    new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

string connectionString =
    config.GetConnectionString("DefaultConnection")!;

StudentService service =
    new StudentService(connectionString);

while (true)
{
    Console.WriteLine();
    Console.WriteLine("===== Student Management =====");
    Console.WriteLine("1. View Students");
    Console.WriteLine("2. Add Student");
    Console.WriteLine("3. Update Student");
    Console.WriteLine("4. Delete Student");
    Console.WriteLine("5. Exit");
    Console.Write("Select: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":

            service.GetAllStudents();

            break;

        case "2":

            Console.Write("Name: ");
            string name = Console.ReadLine()!;

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine()!);

            Student student = new()
            {
                Name = name,
                Age = age
            };

            service.AddStudent(student);

            break;

        case "3":

            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine()!);

            Console.Write("New Name: ");
            string newName = Console.ReadLine()!;

            Console.Write("New Age: ");
            int newAge = int.Parse(Console.ReadLine()!);

            Student updateStudent = new()
            {
                Id = id,
                Name = newName,
                Age = newAge
            };

            service.UpdateStudent(updateStudent);

            break;

        case "4":

            Console.Write("Id: ");

            int deleteId =
                int.Parse(Console.ReadLine()!);

            service.DeleteStudent(deleteId);

            break;

        case "5":

            return;

        default:

            Console.WriteLine("Invalid Option");

            break;
    }
}