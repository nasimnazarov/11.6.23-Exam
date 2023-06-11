using System.Text.RegularExpressions;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context;

public class DataContext:DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Department> Departments { get; set; }
    //public DbSet<Employee> Employees { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<JobGrade> JobGrades { get; set; }
    public DbSet<JobHistory> JobHistories { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Region> Regions { get; set; }
}