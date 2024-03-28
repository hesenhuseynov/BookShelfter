using System.Collections;
using BookShelfter.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BookShelfter.Domain.Entities;

public class Book:BaseEntity
{
    public string BookName { get; set; }
    public string AuthorName { get; set; }
    public int  Stock { get; set; }
    public float Price { get; set; }
    

    public string  ISBN { get; set; }
    public string Description { get; set; }
    public Guid PublisherId { get; set; }
    public Guid CategoryId{ get; set; }
    public Category Category { get; set; }
    public ICollection<ProductImageFile> ProductImageFiles { get; set; }
    public ICollection<BasketItem> BasketItems { get; set; }

    public ICollection<Reviews> Reviews { get; set; }
    
    
}