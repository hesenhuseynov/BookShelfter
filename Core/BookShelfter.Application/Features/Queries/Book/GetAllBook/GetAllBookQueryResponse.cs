namespace BookShelfter.Application.Features.Queries.Book.GetAllBook;

public class GetAllBookQueryResponse
{
    public int TotalProductCount { get; set; }
    public object? Products { get; set; }
}