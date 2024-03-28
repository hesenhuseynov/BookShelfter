using System.Net;
using BookShelfter.Application.Features.Commands.Book.CreateProduct;
using BookShelfter.Application.Features.Commands.Book.RemoveProduct;
using BookShelfter.Application.Features.Queries.Book.GetAllBook;
using BookShelfter.Application.Features.Queries.Book.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookShelfter.API.Controllers;



[Route("api/[controller]")]
[ApiController]
public class BooksController:ControllerBase
{
    private readonly IMediator _mediator;
    // private readonly ILogger<BooksController> _logger;

    public BooksController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateBook(CreateProductCommandRequest createProductCommandRequest)
    {
        CreateProductCommandResponse response = await _mediator.Send(createProductCommandRequest);
        return StatusCode((int)HttpStatusCode.Created);
    }

    
    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] GetAllBookQueryRequest getAllBookQueryRequest)
    {
        GetAllBookQueryResponse response = await _mediator.Send(getAllBookQueryRequest);
        return Ok(response);

    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> GetById([FromRoute] GetByIdBookQueryRequest getByIdBookQueryRequest)
    {
        GetByIdBookQueryResponse response = await _mediator.Send(getByIdBookQueryRequest);
        
        return Ok(response);

    }

    [HttpDelete("{Id}")]
    public async Task<IActionResult> RemoveById([FromRoute] RemoveProductCommandRequest removeProductCommandRequest)
    {
        RemoveProductCommandResponse response=await _mediator.Send(removeProductCommandRequest);
        return Ok(response);
    }

}

