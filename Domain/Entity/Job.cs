using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class Job
{
  //  [Key]
   // public int JobId { get; set; }
    [Key,Required,MaxLength(100)]
    public string JobTitle { get; set; }
    [Required]
    public int MinSalary { get; set; }
    [Required]
    public int MaxSalary { get; set; }
}