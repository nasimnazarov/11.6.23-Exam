using System.ComponentModel.DataAnnotations;

namespace Domain.Entity;

public class Region
{
    [Key]
    public int RegionId { get; set; }
    [Required,MaxLength(50)]
    public string RegionName { get; set; }
}