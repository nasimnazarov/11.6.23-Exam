using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class JobHistory
{
    [Key]
    public int EmployeeId { get; set; }
    [Required]
    public DateTime StartDate { get; set; }
    [Required]
    public DateTime EndDate { get; set; }
    [Required]
    public int JobId { get; set; }
    [Required]
    public int DepartmentId { get; set; }
}