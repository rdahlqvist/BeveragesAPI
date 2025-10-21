using BeveragesAPI.Data.Models;
using BeveragesAPI.DTO;

namespace BeveragesAPI.Services;
public interface IBeverageService
{
    Task CreateBeverageAsync(CreateBeverageDTO beverage);
    Task DeleteBeverageAsync(int id);
    Task<List<BeverageDTO>> GetAllBeveragesAsync();
    Task<BeverageDTO> GetBeverageAsync(int id);
    Task UpdateBeverageAsync(int id, Beverage beverage);
}