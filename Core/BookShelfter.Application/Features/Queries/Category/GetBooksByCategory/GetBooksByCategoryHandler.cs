using BookShelfter.Application.Repositories.Category;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookShelfter.Application.Features.Queries.Category.GetBooksByCategory;

public class GetBooksByCategoryHandler:IRequestHandler<GetBooksByCategoryQueryRequest,GetBooksByCategoryQueryResponse>
{

    private readonly ICategoryReadRepository _categoryReadRepository;

    public GetBooksByCategoryHandler(ICategoryReadRepository categoryReadRepository)
    {
        _categoryReadRepository = categoryReadRepository;
    }

    public async  Task<GetBooksByCategoryQueryResponse> Handle(GetBooksByCategoryQueryRequest request, CancellationToken cancellationToken)
    {
 

         try
         {
             var categories = await _categoryReadRepository.GetAll().ToListAsync();
             var books = await _categoryReadRepository.GetBooksByCategoryId(request.CategoryId);

             if (books==null ||!books.Any())
             {
                 return new()
                 {
                     Success = false,
                     Message = "No books found for the given category"
                 };

             }
    
            return   new ()
             {
                 Books = books,
                 Message = "Books successfully retrieved for the category.",
                 Success = true



             };
         }
         catch (Exception e)
         {
           return   new GetBooksByCategoryQueryResponse()
             {
                 Success = false,
                 Errors = new List<string>(){e.Message},
              
                 Message = "An error occurred while retrieving books by category."
                 
                 
             };
             
             

         }




    }
}