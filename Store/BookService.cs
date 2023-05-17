namespace Store;

// класс служба(Service) не имеет состояния
// этот класс относиттся к бизнес-логике так как это служба(по этому он находится здесь)
public class BookService
{
    private readonly IBookRepository bookRepository;

    public BookService(IBookRepository bookRepository) // constructor injection
    {
        this.bookRepository = bookRepository;
    }
    public Book[] GetAllByQuery(string query)
    {
        if (Book.IsIsbn(query))
            return bookRepository.GetAllByIsbn(query);

        return bookRepository.GetAllByTitleOrAuthorName(query);
    }
}