namespace BeveragesAPI.DTO;

public class BeverageDTO
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

}
