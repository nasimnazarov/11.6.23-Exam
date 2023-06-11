using Domain.Entity;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services;

public class CountryService
{
    private readonly DataContext _context;

    public CountryService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Country>> GetCourses()
    {
        return await _context.Countries.ToListAsync();
    }
    public async Task<Country> GetCountryById(int id)
    {
        return await _context.Countries.FindAsync(id);
    }

    public async Task<Country> AddCountry(Country country)
    {
        await _context.Countries.AddAsync(country);
        await _context.SaveChangesAsync();
        return country;
    }
    
}