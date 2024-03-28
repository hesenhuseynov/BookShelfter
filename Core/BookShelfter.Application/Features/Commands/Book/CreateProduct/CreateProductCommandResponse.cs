namespace BookShelfter.Application.Features.Commands.Book.CreateProduct;

public class CreateProductCommandResponse
{
    public bool Success { get; set; } = true;
    public Guid BookId { get; set; } = Guid.NewGuid();

}