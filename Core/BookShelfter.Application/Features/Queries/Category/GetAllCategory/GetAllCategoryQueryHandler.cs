using BookShelfter.Application.Repositories.Category;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShelfter.Application.Features.Queries.Category.GetAllCategory;

public class GetAllCategoryQueryHandler:IRequestHandler<GetAllCategoryQueryRequest,GetAllCategoryQueryResponse>
{
    private readonly ICategoryReadRepository _categoryReadRepository;

    public GetAllCategoryQueryHandler(ICategoryReadRepository categoryReadRepository)
    {
        _categoryReadRepository = categoryReadRepository;
    }

    public Task<GetAllCategoryQueryResponse> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
    {
        
        
      
        var categories = _categoryReadRepository
            .GetAll()
            .Include(c => c.Books) // Books koleksiyonunu yükle
            .ToList();        var response = new GetAllCategoryQueryResponse()
        {
            TotalCount = categories.Count(),
            Category = categories,
            
         
        };
        
        return Task.FromResult(response);


    }
}