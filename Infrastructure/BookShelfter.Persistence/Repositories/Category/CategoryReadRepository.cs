using BookShelfter.Application.Repositories.Category;
using BookShelfter.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace BookShelfter.Persistence.Category;

public class CategoryReadRepository:ReadRepository<Domain.Entities.Category>,ICategoryReadRepository
{
    public CategoryReadRepository(BookShelfterDbContext context) : base(context)
    {
    }

    public  async Task<ICollection<Domain.Entities.Book>> GetBooksByCategoryId(string categoryId)
    {
        var query =  _context.Books.Where(b => b.CategoryId == Guid.Parse(categoryId));
        
        return await query.ToListAsync();
     

    }
}