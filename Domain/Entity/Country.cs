using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Domain.Entity;

public class Country
{
    [Key]
    public int CountryId { get; set; }
    [Required,MaxLength(100)]
    public string CountryName { get; set; }
    [Required]
    public int RegionId { get; set; }
    //public Region Region { get; set; }
}