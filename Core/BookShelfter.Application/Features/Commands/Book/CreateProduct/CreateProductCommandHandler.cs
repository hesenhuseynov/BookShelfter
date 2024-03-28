using BookShelfter.Application.Abstractions.Hubs;
using BookShelfter.Application.Repositories.Book;
using MediatR;

namespace BookShelfter.Application.Features.Commands.Book.CreateProduct;

public class CreateProductCommandHandler:IRequestHandler<CreateProductCommandRequest,CreateProductCommandResponse>
{
     readonly IBookWriteRepository _bookWriteRepository;
     // private readonly IBookHubService _bookHubService;

     public CreateProductCommandHandler(IBookWriteRepository bookWriteRepository)
     {
         _bookWriteRepository = bookWriteRepository;
     }
     
     public async  Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
     {
         await _bookWriteRepository.AddAsync(new()
         {
             BookName = request.BookName,
             Price = request.Price,
             Stock = request.Stock ,
             AuthorName = request.AuthorName,
             ISBN = request.ISBN,
             Description = request.Description,
             CategoryId = request.CategoryId
             
             
             

         });
         await _bookWriteRepository.SaveAsync();
         // await _bookHubService.BookAddedMessageAsync($"{request.Name} named added book");
         return new();
         
        
       
    }
}