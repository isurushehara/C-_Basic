# C# Basic Learning Path

Welcome to the C# Basic Learning Path! This repository contains a structured collection of lessons covering fundamental to intermediate C# programming concepts.

## 📁 Project Structure

```
C#_Basic/
├── 01-Variables/
│   ├── 01-Variables.csproj
│   └── Program.cs
│   └── Introduction to variables, data types, and basic declarations
│
├── 02-Operators/
│   ├── 02-Operators.csproj
│   └── Program.cs
│   └── Arithmetic, logical, comparison, and assignment operators
│
├── 03-Conditions/
│   ├── 03-Conditions.csproj
│   └── Program.cs
│   └── If statements, else-if chains, and switch statements
│
├── 04-Loops/
│   ├── 04-Loops.csproj
│   └── Program.cs
│   └── For, while, do-while loops and loop control
│
├── 05-Methods/
│   ├── 05-Methods.csproj
│   └── Program.cs
│   └── Method declaration, parameters, return types, and method overloading
│
├── 06-Arrays/
│   ├── 06-Arrays.csproj
│   └── Program.cs
│   └── Single and multi-dimensional arrays, array operations
│
├── 07-Classes/
│   ├── 07-Classes.csproj
│   ├── Program.cs
│   ├── Student.cs
│   └── Object-oriented programming basics, class structure
│
├── 08-Inheritance/
│   ├── 08-Inheritance.csproj
│   ├── Animal.cs
│   ├── Dog.cs
│   └── Program.cs
│   └── Class inheritance and inheritance hierarchy
│
├── 09-Collections/
│   ├── 09-Collections.csproj
│   └── Program.cs
│   └── Lists, dictionaries, and other collection types
│
├── 10-LINQ/
│   ├── 10-LINQ.csproj
│   └── Program.cs
│   └── Language Integrated Query for data manipulation
│
├── 11-AsyncAwait/
│   ├── 11-AsyncAwait.csproj
│   ├── Program.cs
│   ├── bin/
│   └── obj/
│   └── Asynchronous programming with async/await keywords
│
├── 12-InputOutput/
│   ├── 12-InputOutput.csproj
│   └── Program.cs
│   └── File I/O operations and stream handling
│
├── 13-Constructors/
│   ├── 13-Constructors.csproj
│   ├── Person.cs
│   └── Program.cs
│   └── Constructor patterns and initialization
│
├── 14-Properties/
│   ├── 14-Properties.csproj
│   ├── Program.cs
│   ├── Student.cs
│   └── Properties, getters, and setters
│
├── 15-Encapsulation/
│   ├── 15-Encapsulation.csproj
│   ├── BankAccount.cs
│   └── Program.cs
│   └── Data hiding and access modifiers
│
├── 16-Polymorphism/
│   ├── 16-Polymorphism.csproj
│   ├── Animal.cs
│   ├── Cat.cs
│   ├── Dog.cs
│   └── Program.cs
│   └── Method overriding and polymorphic behavior
│
├── 17-Interfaces/
│   ├── 17-Interfaces.csproj
│   ├── Bike.cs
│   ├── Car.cs
│   ├── IVehicle.cs
│   └── Program.cs
│   └── Interface definitions and implementation
│
├── 18-ExceptionHandling/
│   ├── 18-ExceptionHandling.csproj
│   └── Program.cs
│   └── Try-catch-finally and exception management
│
├── 19-Generics/
│   ├── 19-Generics.csproj
│   ├── Box.cs
│   └── Program.cs
│   └── Generic classes and type parameters
│
├── 20-Delegates/
│   ├── 20-Delegates.csproj
│   ├── Program.cs
│   ├── bin/
│   └── Delegate types and callbacks
│
├── 21-Events/
│   ├── 21-Events.csproj
│   ├── Button.cs
│   ├── Program.cs
│   └── Event handling and event publishing
│
├── 22-LambdaExpressions/
│   ├── 22-LambdaExpressions.csproj
│   └── Program.cs
│   └── Lambda expressions and functional programming
│
├── 23-MysqlConnection/
│   ├── 23-MysqlConnection.csproj
│   ├── appsettings.json
│   ├── Program.cs
│   ├── Models/
│   ├── Services/
│   └── Database connectivity with MySQL
│
└── 100-Project/
    ├── 100-Project.csproj
    ├── Program.cs
    ├── students.txt
    ├── Events/
    ├── Helpers/
    ├── Interfaces/
    ├── Models/
    ├── Services/
    └── obj/
    └── Comprehensive project integrating multiple concepts
```

## 🎯 Learning Path Overview

| # | Lesson | Topic | Focus |
|---|--------|-------|-------|
| 01 | Variables | Fundamentals | Data types, variable declaration |
| 02 | Operators | Fundamentals | Operations and expressions |
| 03 | Conditions | Control Flow | Conditional logic |
| 04 | Loops | Control Flow | Iteration and loops |
| 05 | Methods | Functions | Code organization and reusability |
| 06 | Arrays | Collections | Static collections |
| 07 | Classes | OOP | Class basics |
| 08 | Inheritance | OOP | Class hierarchy |
| 09 | Collections | Collections | Dynamic collections |
| 10 | LINQ | Query | Data manipulation |
| 11 | AsyncAwait | Advanced | Asynchronous programming |
| 12 | InputOutput | I/O | File operations |
| 13 | Constructors | OOP | Object initialization |
| 14 | Properties | OOP | Encapsulation basics |
| 15 | Encapsulation | OOP | Data hiding |
| 16 | Polymorphism | OOP | Method overriding |
| 17 | Interfaces | OOP | Contract-based design |
| 18 | ExceptionHandling | Error Handling | Exception management |
| 19 | Generics | Advanced | Type parameters |
| 20 | Delegates | Advanced | Callbacks and function pointers |
| 21 | Events | Advanced | Event-driven programming |
| 22 | LambdaExpressions | Advanced | Functional programming |
| 23 | MysqlConnection | Database | Database integration |
| 100 | Project | Integration | Real-world application |

## 🚀 Getting Started

1. **Clone/Download** this repository
2. **Navigate** to any lesson folder
3. **Open** the `.csproj` file in Visual Studio or VS Code
4. **Run** the project:
   ```bash
   cd <lesson-folder>
   dotnet run
   ```

## 📝 Notes

- Each lesson is a standalone project with its own `.csproj` file
- `Program.cs` contains the main execution logic for each lesson
- Helper classes are organized in separate `.cs` files (e.g., `Student.cs`, `Animal.cs`)
- The `100-Project` folder demonstrates integration of multiple concepts
- Build artifacts are stored in `bin/` and `obj/` directories

## 🔧 Prerequisites

- .NET SDK 6.0 or higher
- A C# IDE (Visual Studio, VS Code with C# extension, or similar)

## 📚 Progression

Start with **01-Variables** and progress sequentially. Each lesson builds on concepts from previous lessons. The fundamental concepts (Variables through Methods) form the foundation for object-oriented concepts (Classes through Interfaces), which are then applied in advanced topics and the final project.

---

**Happy Learning!** 🎓
