using MediatR;

namespace BookShelfter.Application.Features.Commands.Book.CreateProduct;

public class CreateProductCommandRequest:IRequest<CreateProductCommandResponse>
{
    public string BookName { get; set; }
    
    public string AuthorName { get; set; }
    
    public string  ISBN { get; set; }
    public string Description { get; set; }
    public Guid CategoryId{ get; set; }

    public int Stock { get; set; }
    public float Price { get; set; }
    
}