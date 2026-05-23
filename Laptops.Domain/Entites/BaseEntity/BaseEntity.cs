namespace Laptops.Domain.Entites;

public class BaceEntity
{ 
    public Guid Id { get; set; } 

    public DateTime CreatedAt { get; set; }
     
    public DateTime? UpdatedAt { get; set; }
    public long? UpdatedBy { get; set; }
    public long? DeletedBy { get; set; }


    public bool IsDeleted { get; set; } = true;
}
