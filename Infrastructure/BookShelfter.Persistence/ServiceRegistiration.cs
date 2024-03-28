using BookShelfter.Application.Repositories.Book;
using BookShelfter.Application.Repositories.Category;
using BookShelfter.Domain.Entities.Identity;
using BookShelfter.Persistence.Book;
using BookShelfter.Persistence.Category;
using BookShelfter.Persistence.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BookShelfter.Persistence;

public static class ServiceRegistiration
{

    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<BookShelfterDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<BookShelfterDbContext>()
            .AddDefaultTokenProviders();


        services.AddScoped<IBookReadRepository, BookReadRepository>();
        services.AddScoped<IBookWriteRepository, BookWriteRepository>();
        services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
        services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
        


    }
}