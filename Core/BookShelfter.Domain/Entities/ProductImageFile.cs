using BookShelfter.Domain.Entities.Common;

namespace BookShelfter.Domain.Entities;

public class ProductImageFile:BaseEntity
{
    public bool Showcase { get; set; }
    public ICollection<Book> Books { get; set; }
}