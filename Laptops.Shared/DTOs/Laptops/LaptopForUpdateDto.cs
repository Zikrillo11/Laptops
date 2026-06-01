namespace Laptops.Shared.DTOs.Laptops;

public class LaptopForUpdateDto : BaseDto
{
    public string Name { get; set; }

    public string Brand { get; set; }

    public decimal Price { get; set; }
}
