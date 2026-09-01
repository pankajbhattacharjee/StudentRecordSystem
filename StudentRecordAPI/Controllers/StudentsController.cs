using Microsoft.AspNetCore.Mvc;
using StudentRecordAPI.Models;

namespace StudentRecordAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly global::StudentStore _studentStore;

    public StudentsController(global::StudentStore studentStore)
    {
        _studentStore = studentStore;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Student>> GetStudents()
    {
        return Ok(_studentStore.GetAll());
    }

    [HttpGet("{id:int}")]
    public ActionResult<Student> GetStudentById(int id)
    {
        var student = _studentStore.GetById(id);

        if (student is null)
        {
            return NotFound();
        }

        return Ok(student);
    }

    [HttpPost]
    public ActionResult<Student> CreateStudent(Student student)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var createdStudent = _studentStore.Add(student);
        return CreatedAtAction(nameof(GetStudentById), new { id = createdStudent.Id }, createdStudent);
    }

    [HttpPut("{id:int}")]
    public IActionResult UpdateStudent(int id, Student student)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var isUpdated = _studentStore.Update(id, student);

        if (!isUpdated)
        {
            return NotFound();
        }

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteStudent(int id)
    {
        var isDeleted = _studentStore.Delete(id);

        if (!isDeleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}
