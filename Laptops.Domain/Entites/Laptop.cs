using System.ComponentModel.DataAnnotations.Schema;

namespace Laptops.Domain.Entites;


[Table("Laptop")]
public class Laptop : BaceEntity
{
    public string Name { get; set; }

    public string Brand { get; set; }

    public decimal Price { get; set; }
}

