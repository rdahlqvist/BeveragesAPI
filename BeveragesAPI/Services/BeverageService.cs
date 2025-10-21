using BeveragesAPI.Data;
using BeveragesAPI.Data.Models;
using BeveragesAPI.DTO;
namespace BeveragesAPI.Services;
public class BeverageService : IBeverageService
{
    private readonly IBeveragesRepository _beverageRepository;

    public BeverageService(IBeveragesRepository beverageRepository)
    {
        _beverageRepository = beverageRepository;
    }

    public async Task<List<BeverageDTO>> GetAllBeveragesAsync()
    {
        //return await _beverageRepository.GetAllBeveragesAsync();
        var beverageDto = from c in await _beverageRepository.GetAllBeveragesAsync()
                          select new BeverageDTO()
                          {
                              Id = c.Id,
                              Name = c.Name,
                              Price = c.Price,
                              Manufacturer = c.Manufacturer,
                              Age = c.Age,
                              AlcPercent = c.AlcPercent,
                              Rating = c.Rating,
                              Description = c.Description,
                              Category = c.Category,
                              ImageUrl = c.ImageUrl
                          };
        return beverageDto.ToList();
    }

    public async Task<BeverageDTO> GetBeverageAsync(int id)
    {
        //return await _beverageRepository.GetBeverageAsync(id);

        var beverage = await _beverageRepository.GetBeverageAsync(id);

        var beverageDTO = new BeverageDTO()
        {
            Id = beverage.Id,
            Name = beverage.Name,
            Price = beverage.Price,
            Manufacturer = beverage.Manufacturer,
            Age = beverage.Age,
            AlcPercent = beverage.AlcPercent,
            Rating = beverage.Rating,
            Description = beverage.Description,
            Category = beverage.Category,
            ImageUrl = beverage.ImageUrl
        };

        return beverageDTO;
    }

    public async Task CreateBeverageAsync(CreateBeverageDTO beverageDTO)
    {
        //await _beverageRepository.CreateBeverageAsync(beverage);

        Beverage beverage = new Beverage()
        {
            Name = beverageDTO.Name,
            Price = beverageDTO.Price,
            Manufacturer = beverageDTO.Manufacturer,
            Age = beverageDTO.Age,
            AlcPercent = beverageDTO.AlcPercent,
            Rating = beverageDTO.Rating,
            Description = beverageDTO.Description,
            Category = beverageDTO.Category,
            ImageUrl = beverageDTO.ImageUrl
        };

        await _beverageRepository.CreateBeverageAsync(beverage);
    }

    public async Task UpdateBeverageAsync(int id, Beverage beverage)
    {
        await _beverageRepository.UpdateBeverageAsync(id, beverage);
    }

    public async Task DeleteBeverageAsync(int id)
    {
        await _beverageRepository.DeleteBeverageAsync(id);
    }
}
