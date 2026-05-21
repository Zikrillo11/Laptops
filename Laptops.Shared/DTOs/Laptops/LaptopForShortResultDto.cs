namespace Laptops.Shared.DTOs.Laptops;

public class LaptopForShortResultDto : BaseDto
{
    public long Id { get; set; }

    public string Name { get; set; }

    public decimal Price { get; set; }

    public string Brand { get; set; }
}
