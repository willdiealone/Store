using System.Text.RegularExpressions;

namespace Store;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }

    public string Isbn { get; set; }

    public string AuthorName { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public Book(int Id,string Title,string Isbn,string AuthorName,string Description,decimal Price)
    {
        this.Id = Id;
        this.Title = Title;
        this.Isbn = Isbn;
        this.AuthorName = AuthorName;
        this.Description = Description;
        this.Price = Price;
    }

    // доступен всем класам проекта Store
    internal static bool IsIsbn(string query)
    {
        if (query == null)
            return false;

        var newQuery = query.Replace("-", " ")
            .Replace(" ", "")
            .ToUpper();
        
        // всегда совпадает с началом строки ^ и всегда совпадает с концом строки $
        return Regex.IsMatch(newQuery, @"ISBN\d{10}");
        
    }
}