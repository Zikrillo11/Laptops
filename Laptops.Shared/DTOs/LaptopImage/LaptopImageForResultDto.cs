using Laptops.Shared.DTOs.Laptops;

namespace Laptops.Shared.DTOs.LaptopImage;

public class LaptopImageForResultDto : BaseDto
{
    public string ImageUrl { get; set; }

    public LaptopForShortResultDto Laptop { get; set; }
}
