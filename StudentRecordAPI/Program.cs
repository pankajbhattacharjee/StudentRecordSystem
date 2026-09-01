using StudentRecordAPI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<StudentStore>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

public class StudentStore
{
    private readonly List<Student> _students = new()
    {
        new Student { Id = 1, Name = "Alice Johnson", Course = "Computer Science", Marks = 92.5 },
        new Student { Id = 2, Name = "Mark Lee", Course = "Business Administration", Marks = 88.0 }
    };

    private int _nextId = 3;

    public List<Student> GetAll()
    {
        return _students;
    }

    public Student? GetById(int id)
    {
        return _students.FirstOrDefault(student => student.Id == id);
    }

    public Student Add(Student student)
    {
        student.Id = _nextId++;
        _students.Add(student);
        return student;
    }

    public bool Update(int id, Student updatedStudent)
    {
        var existingStudent = _students.FirstOrDefault(student => student.Id == id);

        if (existingStudent is null)
        {
            return false;
        }

        existingStudent.Name = updatedStudent.Name;
        existingStudent.Course = updatedStudent.Course;
        existingStudent.Marks = updatedStudent.Marks;

        return true;
    }

    public bool Delete(int id)
    {
        var student = _students.FirstOrDefault(item => item.Id == id);

        if (student is null)
        {
            return false;
        }

        _students.Remove(student);
        return true;
    }
}
