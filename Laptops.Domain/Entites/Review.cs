using System.ComponentModel.DataAnnotations.Schema;

namespace Laptops.Domain.Entites;

[Table("Review")]
public class Review : BaceEntity
{
    [Column("UserName")]
    public string UserName { get; set; }

    [Column("Comment")]
    public string Comment { get; set; }

    [Column("Rating")]
    public int Rating { get; set; }

    [Column("LaptopId")]
    public Guid LaptopId { get; set; }

    [Column("Laptop")]
    public Laptop Laptop { get; set; }
}
