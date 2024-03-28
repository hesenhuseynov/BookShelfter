using MediatR;

namespace BookShelfter.Application.Features.Commands.Book.RemoveProduct;

public class RemoveProductCommandRequest:IRequest<RemoveProductCommandResponse>
{
    public string Id { get; set; }
    
    
}