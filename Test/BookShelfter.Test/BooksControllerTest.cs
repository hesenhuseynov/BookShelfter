using System.Net;
using BookShelfter.API.Controllers;
using BookShelfter.Application.Features.Commands.Book.CreateProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace BookShelfter.Test;

public class BooksControllerTest
{
   

    [Fact]
    public async Task Post_ReturnsCreatedStatus()
    {
      
        // Arrange
        var mediatorMock = new Mock<IMediator>();
        var expectedResponse = new CreateProductCommandResponse { Success = true, BookId = Guid.NewGuid() };
        mediatorMock.Setup(m => m.Send(It.IsAny<CreateProductCommandRequest>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(expectedResponse);
        var controller = new BooksController(mediatorMock.Object);

        var command = new CreateProductCommandRequest(); 

        // Act
        var result = await controller.Post(command);

        // Assert
        Assert.IsType<StatusCodeResult>(result);
        var statusCodeResult = result as StatusCodeResult;
        Assert.Equal((int)HttpStatusCode.Created, statusCodeResult.StatusCode);

    }
}