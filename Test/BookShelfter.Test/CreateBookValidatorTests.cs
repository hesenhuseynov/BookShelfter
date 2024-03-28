using BookShelfter.Application.Validators.Books;
using BookShelfter.Application.ViewModels.Books;
using FluentValidation.TestHelper;

namespace BookShelfter.Test;

public class CreateBookValidatorTests
{
    private readonly CreateBookValidator validator = new CreateBookValidator();

    [Fact]
    public void Should_Have_Error_When_BookName_Is_Null()
    {
        // Act
        var result = validator.TestValidate(new VM_Create_Book { BookName = null });

        // Assert
        result.ShouldHaveValidationErrorFor(book => book.BookName)
            .WithErrorMessage("Please enter the name of book");
    }

    [Fact]
    public void Should_Have_Error_When_BookName_Is_Empty()
    {
        // Act
        var result = validator.TestValidate(new VM_Create_Book { BookName = string.Empty });

        // Assert
        result.ShouldHaveValidationErrorFor(book => book.BookName)
            .WithErrorMessage("Please enter the name of book");
    }

    [Fact]
    public void Should_Have_Error_When_BookName_Is_Too_Short()
    {
        // Act
        var result = validator.TestValidate(new VM_Create_Book { BookName = "Abc" });

        // Assert
        result.ShouldHaveValidationErrorFor(book => book.BookName)
            .WithErrorMessage("Please Enter only between minimum 5- maximum 150 character name of book");
    }

    [Fact]
    public void Should_Have_Error_When_BookName_Is_Too_Long()
    {
        // Act
        var result = validator.TestValidate(new VM_Create_Book { BookName = new string('A', 151) });

        // Assert
        result.ShouldHaveValidationErrorFor(book => book.BookName)
            .WithErrorMessage("Please Enter only between minimum 5- maximum 150 character name of book");
    }

    [Fact]
    public void Should_Not_Have_Error_When_BookName_Is_Valid()
    {
        // Act
        var result = validator.TestValidate(new VM_Create_Book { BookName = "Valid Book Name" });

        // Assert
        result.ShouldNotHaveValidationErrorFor(book => book.BookName);
    }
}