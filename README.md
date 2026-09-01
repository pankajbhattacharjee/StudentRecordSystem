# Student Record Management System

A simple console-based CRUD application built in **C# (.NET 8)** to manage student records in memory.

## Features
- Add a new student record
- View all student records
- Update an existing student record
- Delete a student record
- Search a student by ID

## Concepts Used
- Object-Oriented Programming (classes, properties, constructors)
- Collections (`List<T>`)
- Lambda expressions (`List.Find(s => s.Id == id)`)
- Console I/O and menu-driven program flow using `switch` statements

## How to Run

1. Install the [.NET SDK](https://dotnet.microsoft.com/download) (8.0 or later)
2. Clone this repository
3. Run the following commands in the project folder:

```bash
dotnet run
```

4. Use the on-screen menu to Add, View, Update, Delete, or Search student records.

## Possible Future Improvements
- Persist data using a database (SQL Server) via Entity Framework Core
- Convert to a Web API using ASP.NET Core
- Add input validation and error handling
