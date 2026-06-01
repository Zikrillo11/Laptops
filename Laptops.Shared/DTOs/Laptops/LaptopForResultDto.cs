using Laptops.Shared.DTOs.Categories;

namespace Laptops.Shared.DTOs.Laptops;

public class LaptopForResultDto : BaseDto
{
    public long Id { get; set; }

    public string Name { get; set; }

    public string Brand { get; set; }

    public decimal Price { get; set; }
}
