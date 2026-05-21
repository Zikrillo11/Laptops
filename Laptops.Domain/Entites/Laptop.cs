using System.ComponentModel.DataAnnotations.Schema;

namespace Laptops.Domain.Entites;


[Table("Laptop")]
public class Laptop : BaceEntity
{
    [Column("Nmae")]
    public string Name { get; set; }

    [Column("Brand")]
    public string Brand { get; set; }

    [Column("Processor")]
    public string Processor { get; set; }

    [Column("Ram")]
    public int Ram { get; set; }

    [Column("Storage")]
    public int Storage { get; set; }

    [Column("StorageType")]
    public string StorageType { get; set; }

    [Column("Price")]
    public decimal Price { get; set; }

    [Column("ScreenSize")]
    public double ScreenSize { get; set; }

    [Column("GPU")]
    public string GPU { get; set; }

    [Column("OperatingSystem")]
    public string OperatingSystem { get; set; }

    [Column("BatteryLife")]
    public int BatteryLife { get; set; }

    [Column("IsTouchScreen")]
    public bool IsTouchScreen { get; set; }

    [Column("Color")]
    public string Color { get; set; }

    [Column("Stock")]
    public int Stock { get; set; }

    [Column("CategoryId")]
    public Guid CategoryId { get; set; }

    [Column("Category")]
    public Category Category { get; set; }

    public ICollection<Review> Reviews { get; set; } = new List<Review>();

    public ICollection<LaptopImage> Images { get; set; } = new List<LaptopImage>();
}
