using BeveragesAPI.Data.Models;
using BeveragesAPI.DTO;
using BeveragesAPI.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace BeveragesAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BeverageController : ControllerBase
{
   private readonly IBeverageService _beverageService;

    public BeverageController(IBeverageService beverageService)
    {
        _beverageService = beverageService;
    }


    //Hämta en lista med alla drycker
    [HttpGet]
    public async Task<List<BeverageDTO>> GetAllBeveragesAsync()
    {
        return await _beverageService.GetAllBeveragesAsync();
    }

    //Skapa en ny
    [HttpPost]
    public async Task CreateBeverage(CreateBeverageDTO beverage)
    {
        await _beverageService.CreateBeverageAsync(beverage);
    }

    //Hämta en med ID
    [HttpGet("{id}")]
    public async Task<BeverageDTO> GetBeverageAsync(int id)
    {
        return await _beverageService.GetBeverageAsync(id);
    }

    //Uppdatera
    [HttpPut("{id}")]
    public async Task UpdateBeverageAsync(int id, Beverage beverage)
    {
         await _beverageService.UpdateBeverageAsync(id, beverage);
    }

    [HttpDelete("{id}")]
    public async Task DeleteBeverageAsync(int id)
    {
        await _beverageService.DeleteBeverageAsync(id);
    }
}
