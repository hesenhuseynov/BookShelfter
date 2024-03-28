using BookShelfter.Domain.Entities.Common;

namespace BookShelfter.Domain.Entities;

public class BasketItem:BaseEntity
{
    public Guid BasketId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public Basket Basket { get; set; }
    public Book  Book { get; set; }
}