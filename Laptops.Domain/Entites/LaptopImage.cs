using System.ComponentModel.DataAnnotations.Schema;

namespace Laptops.Domain.Entites;

[Table("LaptopImmage")]
public class LaptopImage : BaceEntity
{
    [Column("ImmageUrl")]
    public string ImageUrl { get; set; }

    [Column("LaptopId")]
    public Guid LaptopId { get; set; }

    [Column("Laptop")]
    public Laptop Laptop { get; set; }
}
