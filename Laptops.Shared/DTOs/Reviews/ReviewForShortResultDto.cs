namespace Laptops.Shared.DTOs.Reviews;

public class ReviewForShortResultDto : BaseDto
{
    public long Id { get; set; }

    public string UserName { get; set; }

    public int Rating { get; set; }
}
