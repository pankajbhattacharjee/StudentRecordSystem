using System.ComponentModel.DataAnnotations;

namespace StudentRecordAPI.Models;

public class Student
{
    public int Id { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [StringLength(100, MinimumLength = 2)]
    public string Course { get; set; } = string.Empty;

    [Range(0, 100)]
    public double Marks { get; set; }
}
