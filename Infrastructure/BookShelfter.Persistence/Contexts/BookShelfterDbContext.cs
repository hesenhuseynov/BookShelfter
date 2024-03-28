using BookShelfter.Domain.Entities;
using BookShelfter.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookShelfter.Persistence.Contexts;

public class BookShelfterDbContext:IdentityDbContext<AppUser,AppRole,string>
{
    public BookShelfterDbContext(DbContextOptions options):base(options)
    {
        
    }

    public DbSet<Domain.Entities.Book> Books { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Domain.Entities.File> Files { get; set; }
    public DbSet<BasketItem> BasketItems { get; set; }
    public DbSet<Domain.Entities.Category> Categories { get; set; }
    public DbSet<CompletedOrder> CompletedOrders { get; set; }
    public DbSet<Endpoint> Endpoints { get; set; }
    public DbSet<InvoiceFile> InvoiceFiles { get; set; }
    public DbSet<Menu> Menus { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }
    public DbSet<ProductImageFile> ProductImageFiles { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Reviews> Reviews { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Order>()
            .HasKey(b => b.Id);
        builder.Entity<Order>()
            .HasIndex(o => o.OrderCode);

        builder.Entity<Basket>()
            .HasOne(b => b.order)
            .WithOne(o => o.Basket)
            .HasForeignKey<Order>(b => b.Id);

        builder.Entity<Order>()
            .HasOne(o => o.CompletedOrder)
            .WithOne(c => c.Order)
            .HasForeignKey<CompletedOrder>(c => c.OrderId);

        builder.Entity<Reviews>()
            .HasOne<Domain.Entities.Book>(r => r.Book)
            .WithMany(b => b.Reviews)
            .HasForeignKey(r => r.BookID);
        
        builder.Entity<Domain.Entities.Book>()
            .HasIndex(b => b.ISBN)
            .IsUnique();
            
        
        
        base.OnModelCreating(builder);
    }
}