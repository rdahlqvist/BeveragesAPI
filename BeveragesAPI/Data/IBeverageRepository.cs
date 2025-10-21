using BeveragesAPI.Data.Models;
using BeveragesAPI.DTO;

namespace BeveragesAPI.Data;
public interface IBeveragesRepository
{
    Task CreateBeverageAsync(Beverage beverage);
    Task DeleteBeverageAsync(int id);
    Task<List<Beverage>> GetAllBeveragesAsync();
    Task<Beverage> GetBeverageAsync(int beverageId);
    Task UpdateBeverageAsync(int id, Beverage editedBeverage);
}