namespace Laptops.Shared.DTOs.Reviews;

public class ReviewForUpdateDto : BaseDto
{
    public string UserName { get; set; }

    public string Comment { get; set; }

    public int Rating { get; set; }
}
