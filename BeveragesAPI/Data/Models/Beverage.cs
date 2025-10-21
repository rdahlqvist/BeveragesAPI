using System.ComponentModel.DataAnnotations;

namespace BeveragesAPI.Data.Models;

public class Beverage
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public string Manufacturer { get; set; }

    public int Age { get; set; }

    public string AlcPercent { get; set; }

    public double Rating { get; set; }

    public string Description { get; set; }

    public string Category { get; set; } //"Wine" or "Beer"

    public string? ImageUrl { get; set; }

    public string? SecretRecipe { get; set; } //denna ska inte användas, bara för att vi ska använda DTO och välja bort den.
}
