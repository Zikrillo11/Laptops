namespace Laptops.Shared.DTOs.Reviews;

public class ReviewForCreateDto : BaseDto
{
    public string UserName { get; set; }

    public string Comment { get; set; }

    public int Rating { get; set; }

    public long LaptopId { get; set; }
}
