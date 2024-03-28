using BookShelfter.Domain.Entities.Common;

namespace BookShelfter.Domain.Entities;

public class Publisher:BaseEntity
{

    public string Name { get; set; }
    public string? Address { get; set; }
    public string? Phone{ get; set; }
    public string?  Email{ get; set; }
    
}