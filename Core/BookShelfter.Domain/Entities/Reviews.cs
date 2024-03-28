using BookShelfter.Domain.Entities.Common;

namespace BookShelfter.Domain.Entities;

public class Reviews:BaseEntity
{
    public Guid     BookID   { get; set; }
    public string     UserID   { get; set; }
    public int     Rating   { get; set; }
    public string  Title   { get; set; }
    public string  Comment  { get; set; }
    public DateTime ReviewDate { get; set; }
    public int     HelpfulVotes { get; set; }
    public int     Upvotes { get; set; }
    public int     Downvotes { get; set; }
    public bool    Flagged { get; set; }
    public Book  Book { get; set; }
}