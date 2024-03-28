using BookShelfter.Application.Repositories.Book;
using BookShelfter.Persistence.Contexts;

namespace BookShelfter.Persistence.Book;

public class BookReadRepository:ReadRepository<Domain.Entities.Book>,IBookReadRepository
{
    public BookReadRepository(BookShelfterDbContext context):base(context)
    {
        
        
    }
    
}