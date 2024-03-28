using System.Collections;
using MediatR;

namespace BookShelfter.Application.Features.Queries.Category.GetBooksByCategory;

public class GetBooksByCategoryQueryResponse
{
    public bool Success { get; set; }
    public string Message { get; set; }
    public  ICollection<Domain.Entities.Book>  Books { get; set; }
    
    public List<string> Errors { get; set; } = new List<string>();
}