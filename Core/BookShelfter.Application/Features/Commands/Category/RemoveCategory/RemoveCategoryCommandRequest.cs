using MediatR;

namespace BookShelfter.Application.Features.Commands.Category.RemoveCategory;

public class RemoveCategoryCommandRequest:IRequest<RemoveCategoryCommandResponse>
{
    public string CategoryId { get; set; }
    
}