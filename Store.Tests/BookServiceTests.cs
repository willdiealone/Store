using Moq;

namespace Store.Tests;

public class BookServiceTests
{
    [Fact]
    public void GetAllByQuery_WithIsbn_CallGetAllByQuery()
    {
        var bookRepositoryStub = new Mock<IBookRepository>();
        bookRepositoryStub.Setup(x => x.GetAllByIsbn(It.IsAny<string>()))
            .Returns(new[] {new Book(1, "","","","",0m)});
        
        bookRepositoryStub.Setup(x => x.GetAllByTitleOrAuthorName(It.IsAny<string>()))
            .Returns(new[] { new Book(2, "", "", "","",0m) });

        var bookService = new BookService(bookRepositoryStub.Object);

        var validIsbn = "ISBN 12345-67777";

        var actual = bookService.GetAllByQuery(validIsbn);
        
        Assert.Collection(actual, book => Assert.Equal(1,book .Id));
    }
    
    [Fact]
    public void GetAllByQuery_WithAuthor_CallGetAllByQuery()
    {
        var bookRepositoryStub = new Mock<IBookRepository>();
        bookRepositoryStub.Setup(x => x.GetAllByIsbn(It.IsAny<string>()))
            .Returns(new[] {new Book(1, "","","","",0m)});
        
        bookRepositoryStub.Setup(x => x.GetAllByTitleOrAuthorName(It.IsAny<string>()))
            .Returns(new[] { new Book(2, "", "", "","",0m) });

        var bookService = new BookService(bookRepositoryStub.Object);

        var invalidIsbn = "12345-67777";

        var actual = bookService.GetAllByQuery(invalidIsbn);
        
        Assert.Collection(actual, book => Assert.Equal(2,book .Id));
    }
}