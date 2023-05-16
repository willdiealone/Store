namespace Store;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }

    public Book(int Id,string Title)
    {
        this.Id = Id;
        this.Title = Title;
    }
}