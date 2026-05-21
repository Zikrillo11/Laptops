using System.ComponentModel.DataAnnotations.Schema;

namespace Laptops.Domain.Entites;

[Table("Category")]
public class Category : BaceEntity
{
    [Column("Name")]
    public string Name { get; set; }

    public ICollection<Laptop> Laptops { get; set; } = new List<Laptop>();
}
