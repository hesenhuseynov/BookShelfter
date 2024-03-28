using BookShelfter.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BookShelfter.Persistence;

public class DesignTimeDbContextFactory:IDesignTimeDbContextFactory<BookShelfterDbContext>
{
    public BookShelfterDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<BookShelfterDbContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
        return new(dbContextOptionsBuilder.Options);
        
    }
}