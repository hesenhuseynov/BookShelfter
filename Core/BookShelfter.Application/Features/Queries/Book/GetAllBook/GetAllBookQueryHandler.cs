using BookShelfter.Application.Repositories.Book;
using MediatR;

namespace BookShelfter.Application.Features.Queries.Book.GetAllBook;

public class GetAllBookQueryHandler:IRequestHandler<GetAllBookQueryRequest,GetAllBookQueryResponse>
{
    private readonly IBookReadRepository _bookReadRepository;

    public GetAllBookQueryHandler(IBookReadRepository bookReadRepository)
    {
        _bookReadRepository = bookReadRepository;
    }
    public async Task<GetAllBookQueryResponse> Handle(GetAllBookQueryRequest request, CancellationToken cancellationToken)
    {
        
       var allbooks=  _bookReadRepository.GetAll();
       var totalProductCount = _bookReadRepository.GetAll(false).Count();
       return new()
       {
           Products = allbooks,
           TotalProductCount = totalProductCount

       };

    }
}