using System.ComponentModel.Design;
using BookShelfter.Domain.Entities.Common;
using BookShelfter.Domain.Entities.Identity;

namespace BookShelfter.Domain.Entities;

public class Endpoint:BaseEntity
{
    public Endpoint()
    {
        Roles=new HashSet<AppRole>();
    }

    public string ActionType { get; set; }
    public string HttpType { get; set; }
    public string Definition { get; set; }
    public string Code { get; set; }
    public Menu Menu { get; set; }
    public ICollection<AppRole> Roles { get; set; }
    
}