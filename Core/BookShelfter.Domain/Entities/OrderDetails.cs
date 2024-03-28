using BookShelfter.Domain.Entities.Common;

namespace BookShelfter.Domain.Entities;

public class OrderDetails:BaseEntity
{
    public int OrderId { get; set; }
    public int BookId { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }
}