using BeveragesAPI.Data.Models;
using BeveragesAPI.DTO;
using BeveragesAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace BeveragesAPI.Data;

public class BeveragesRepository : IBeveragesRepository
{
    private readonly MyDbContext _context;

    public BeveragesRepository(MyDbContext context)
    {
        _context = context;
    }

    public async Task CreateBeverageAsync(Beverage beverage)
    {
        _context.Beverages.Add(beverage);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteBeverageAsync(int id)
    {
        var theBeverage = await _context.Beverages.FirstOrDefaultAsync(x => x.Id == id);
        _context.Beverages.Remove(theBeverage);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Beverage>> GetAllBeveragesAsync()
    {
        return await _context.Beverages.ToListAsync();
    }

    public async Task<Beverage> GetBeverageAsync(int beverageId)
    {
        return await _context.Beverages.Where(b => b.Id == beverageId).SingleOrDefaultAsync();

    }

    public async Task UpdateBeverageAsync(int id, Beverage editedBeverage)
    {
        var theBeverage = await _context.Beverages.FirstOrDefaultAsync(b => b.Id == id);
        if (theBeverage != null)
        {
            theBeverage.Name = editedBeverage.Name;
            theBeverage.Description = editedBeverage.Description;
            theBeverage.AlcPercent = editedBeverage.AlcPercent;
            theBeverage.Manufacturer = editedBeverage.Manufacturer;
            theBeverage.Category = editedBeverage.Category;
            theBeverage.Rating = editedBeverage.Rating;
            theBeverage.Age = editedBeverage.Age;
            theBeverage.Price = editedBeverage.Price;
            theBeverage.ImageUrl = editedBeverage.ImageUrl;
            theBeverage.SecretRecipe = editedBeverage.SecretRecipe;

            _context.Update(theBeverage);
            await _context.SaveChangesAsync();

        }
    }
}
