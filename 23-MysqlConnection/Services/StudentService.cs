using MySql.Data.MySqlClient;
using MySqlDemo.Models;

namespace MySqlDemo.Services;

public class StudentService
{
    private readonly string _connectionString;

    public StudentService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void GetAllStudents()
    {
        using MySqlConnection connection = new(_connectionString);

        connection.Open();

        string sql = "SELECT * FROM students";

        MySqlCommand command = new(sql, connection);

        using MySqlDataReader reader = command.ExecuteReader();

        Console.WriteLine();

        while (reader.Read())
        {
            Console.WriteLine(
                $"{reader["id"]} | {reader["name"]} | {reader["age"]}"
            );
        }

        Console.WriteLine();
    }

    public void AddStudent(Student student)
    {
        using MySqlConnection connection = new(_connectionString);

        connection.Open();

        string sql =
            "INSERT INTO students(name,age) VALUES(@name,@age)";

        MySqlCommand command = new(sql, connection);

        command.Parameters.AddWithValue("@name", student.Name);
        command.Parameters.AddWithValue("@age", student.Age);

        command.ExecuteNonQuery();

        Console.WriteLine("Student Added.");
    }

    public void UpdateStudent(Student student)
    {
        using MySqlConnection connection = new(_connectionString);

        connection.Open();

        string sql =
            "UPDATE students SET name=@name,age=@age WHERE id=@id";

        MySqlCommand command = new(sql, connection);

        command.Parameters.AddWithValue("@id", student.Id);
        command.Parameters.AddWithValue("@name", student.Name);
        command.Parameters.AddWithValue("@age", student.Age);

        command.ExecuteNonQuery();

        Console.WriteLine("Student Updated.");
    }

    public void DeleteStudent(int id)
    {
        using MySqlConnection connection = new(_connectionString);

        connection.Open();

        string sql =
            "DELETE FROM students WHERE id=@id";

        MySqlCommand command = new(sql, connection);

        command.Parameters.AddWithValue("@id", id);

        command.ExecuteNonQuery();

        Console.WriteLine("Student Deleted.");
    }
}