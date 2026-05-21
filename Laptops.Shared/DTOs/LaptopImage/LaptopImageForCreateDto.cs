namespace Laptops.Shared.DTOs.LaptopImage;

public class LaptopImageForCreateDto : BaseDto
{
    public string ImageUrl { get; set; }

    public long LaptopId { get; set; }
}
