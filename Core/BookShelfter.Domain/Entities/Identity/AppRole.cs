using System.Collections;
using Microsoft.AspNetCore.Identity;

namespace BookShelfter.Domain.Entities.Identity;
public class AppRole:IdentityRole<string>
{
    public ICollection<Endpoint> Endpoints { get; set; }
    
    
}