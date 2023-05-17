namespace Store.Memory;

public class BookRepository : IBookRepository
{

    private readonly Book[] book =
    {
        new Book(1, "Art Of Programming"),
        new Book(2, "Refactoring"),
        new Book(3, "C Programming Language")
    };
        
        
    public Book[] GetAllByTitle(string tilePath)
    {
        return book.Where(b => b.Title.Contains(tilePath)).ToArray();
    }
}