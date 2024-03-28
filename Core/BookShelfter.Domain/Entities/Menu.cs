using BookShelfter.Domain.Entities.Common;

namespace BookShelfter.Domain.Entities;

public class Menu:BaseEntity
{
    public string Name { get; set; }
    public ICollection<Endpoint> Endpoints { get; set; }
}

