using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entity;

public class JobGrade
{
    
    [Key,MaxLength(100)]
    public string GradeLevel { get; set; }
    [Required]
    public int LowestSal { get; set; }
    [Required]
    public int HighestSal { get; set; }
}