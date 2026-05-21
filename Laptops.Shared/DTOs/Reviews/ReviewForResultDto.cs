using Laptops.Shared.DTOs.Laptops;

namespace Laptops.Shared.DTOs.Reviews;

public class ReviewForResultDto : BaseDto
{
    public string UserName { get; set; }

    public string Comment { get; set; }

    public int Rating { get; set; }

    public LaptopForShortResultDto Laptop { get; set; }
}
