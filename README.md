# Student Record System

This repository contains a personal learning project for practicing C# and .NET concepts. It includes:

1. A console-based Student Record Management System built in C#.
2. A simple ASP.NET Core Web API for managing student records in memory.

This project was created to gain hands-on experience with C#, .NET 8, ASP.NET Core, REST APIs, CRUD operations, and basic backend development concepts for interview preparation. It is not production experience and does not claim enterprise-scale architecture or cloud deployment.

## 1) Console Student Record Management System

The original project is a simple menu-driven console application that uses a `List<Student>` to store records in memory.

### Features
- Add a student
- View all students
- Update a student
- Delete a student
- Search a student by ID

### Concepts Demonstrated
- Classes and objects
- Properties and constructors
- `List<T>` collections
- Basic input/output in a console app
- CRUD logic using in-memory data

### Run the console app

```powershell
dotnet run
```

## 2) ASP.NET Core Student Record API

The API project is located in the `StudentRecordAPI` folder and is implemented with ASP.NET Core Web API, controllers, dependency injection, and Swagger/OpenAPI.

### REST endpoints
- `GET /api/students`
- `GET /api/students/{id}`
- `POST /api/students`
- `PUT /api/students/{id}`
- `DELETE /api/students/{id}`

### API features
- In-memory storage using `List<Student>`
- JSON request and response handling
- HTTP status codes such as `200`, `201`, `204`, `400`, and `404`
- Basic model validation
- Swagger UI for testing the endpoints in a browser

### Run the API

```powershell
cd .\StudentRecordAPI
dotnet run
```

Then open:

- `http://localhost:5000/swagger` for local HTTP
- or `https://localhost:7047/swagger` if using the HTTPS profile

## Project Structure

```text
StudentRecordSystem/
├── StudentRecordSystem.csproj
├── Program.cs
├── README.md
├── StudentRecordAPI/
│   ├── StudentRecordAPI.csproj
│   ├── Program.cs
│   ├── Models/
│   │   └── Student.cs
│   ├── Controllers/
│   │   └── StudentsController.cs
│   └── Properties/
│       └── launchSettings.json
└── .gitignore
```

## Learning Goal

This repository is meant to show a clean progression from a beginner-friendly console app to a simple ASP.NET Core API, making it easier to explain in interviews and practice real backend skills with C# and ASP.NET Core.
