using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class Department
{
    [Key]
    public int DepartmentId { get; set; }
    [Required, MaxLength(50)]
    public string DepartmentName { get; set; }
    [Required]
    public int ManagerId { get; set; }
    [Required]
    public int LocationId { get; set; }
}