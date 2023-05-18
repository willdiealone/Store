namespace Store.Memory;

public class BookRepository : IBookRepository
{

    public readonly Book[] book =
    {
        new Book(1, "Art Of Programming","ISBN 12345-678910","D. Knuth"),
        new Book(2, "Refactoring","ISBN 12345-678911","M. Fowler"),
        new Book(3, "The C# Programming Language","ISBN 12345-678912","A. Hejlsber")
    };


    public Book[] GetAllByTitleOrAuthorName(string tileOrAuthorName)
    {
        return book.Where(b => b.Title.Contains(tileOrAuthorName) 
        || b.AuthorName.Contains(tileOrAuthorName)).ToArray();
    }

    public Book[] GetAllByIsbn(string isbn)
    {
        return book.Where(b => b.Isbn == isbn).ToArray();
    }
}