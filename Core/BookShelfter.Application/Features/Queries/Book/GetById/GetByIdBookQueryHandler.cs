using BookShelfter.Application.Repositories.Book;
using MediatR;

namespace BookShelfter.Application.Features.Queries.Book.GetById;

public class GetByIdBookQueryHandler:IRequestHandler<GetByIdBookQueryRequest,GetByIdBookQueryResponse>
{
    private readonly IBookReadRepository _bookReadRepository;
    
    public GetByIdBookQueryHandler(IBookReadRepository bookReadRepository)
    {
        _bookReadRepository = bookReadRepository;
    }
    
    public async Task<GetByIdBookQueryResponse> Handle(GetByIdBookQueryRequest request, CancellationToken cancellationToken)
    {
        var book=  await _bookReadRepository.GetByIdAsync(request.Id, false);

        return new()
        {
            Name = book.BookName,
            Price = book.Price,
            Stock = book.Stock
        };
    }
}