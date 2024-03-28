using BookShelfter.Application.Repositories.Category;
using MediatR;

namespace BookShelfter.Application.Features.Commands.Category;

public class CreateCategoryCommandHandler:IRequestHandler<CreateCategoryCommandRequest,CreateCategoryCommandResponse>
{
    private readonly ICategoryWriteRepository _categoryWriteRepository;

    public CreateCategoryCommandHandler(ICategoryWriteRepository categoryWriteRepository)
    {
        _categoryWriteRepository = categoryWriteRepository;
    }
    public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
    {
        try
        {
            await _categoryWriteRepository.AddAsync(new Domain.Entities.Category(){
                CategoryName = request.CategoryName,
            });
            await _categoryWriteRepository.SaveAsync();

            return new()
            {
                Success = true,
            };

        }
        catch (Exception e)
        {
            return new()
            {
                Success = false,
                Errors = new List<string> { e.Message }
            };

        }
        
     
  

        
        

    }
}