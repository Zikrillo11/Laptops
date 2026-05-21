using Laptops.Shared.DTOs.Categories;

namespace Laptops.Shared.DTOs.Laptops;

public class LaptopForResultDto : BaseDto
{
    public string Name { get; set; }

    public string Brand { get; set; }

    public string Processor { get; set; }

    public int Ram { get; set; }

    public int Storage { get; set; }

    public decimal Price { get; set; }

    public string GPU { get; set; }

    public int Stock { get; set; }

    public CategoryForShortResultDto Category { get; set; }
}
