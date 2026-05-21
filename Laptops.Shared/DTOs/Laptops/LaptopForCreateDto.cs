namespace Laptops.Shared.DTOs.Laptops;

public class LaptopForCreateDto : BaseDto
{
    public string Name { get; set; }

    public string Brand { get; set; }

    public string Processor { get; set; }

    public int Ram { get; set; }

    public int Storage { get; set; }

    public string StorageType { get; set; }

    public decimal Price { get; set; }

    public double ScreenSize { get; set; }

    public string GPU { get; set; }

    public string OperatingSystem { get; set; }

    public int BatteryLife { get; set; }

    public bool IsTouchScreen { get; set; }

    public string Color { get; set; }

    public int Stock { get; set; }

    public long CategoryId { get; set; }
}
