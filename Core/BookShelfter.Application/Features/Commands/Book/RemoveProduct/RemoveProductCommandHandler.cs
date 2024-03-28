using BookShelfter.Application.Repositories.Book;
using MediatR;

namespace BookShelfter.Application.Features.Commands.Book.RemoveProduct;

public class RemoveProductCommandHandler:IRequestHandler<RemoveProductCommandRequest,RemoveProductCommandResponse>
{
    private readonly IBookWriteRepository _bookWriteRepository;

    public RemoveProductCommandHandler(IBookWriteRepository bookWriteRepository)
    {
        _bookWriteRepository = bookWriteRepository;
    }
    
    public async Task<RemoveProductCommandResponse> Handle(RemoveProductCommandRequest request, CancellationToken cancellationToken)
    {
        await _bookWriteRepository.RemoveAsync(request.Id);
        await _bookWriteRepository.SaveAsync();
        return new(){};


    }
}