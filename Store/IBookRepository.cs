namespace Store;

public interface IBookRepository
{
    public Book[] GetAllByTitleOrAuthorName(string tileOrAuthorName);

    public Book[] GetAllByIsbn(string isbn);
    
     public Book GetById(int Id);
    
}