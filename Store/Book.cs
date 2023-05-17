using System.Text.RegularExpressions;

namespace Store;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }

    public string Isbn { get; set; }

    public string AuthorName { get; set; }

    public Book(int Id,string Title,string Isbn,string AuthorName)
    {
        this.Id = Id;
        this.Title = Title;
        this.Isbn = Isbn;
        this.AuthorName = AuthorName;
    }

    // доступен всем класам проекта Store
    internal static bool IsIsbn(string query)
    {
        if(query == null)
            return false;

        query = query.Replace("-", " ")
            .Replace(" ","")
            .ToUpper();
        
        if (Regex.IsMatch(query, @"ISBN\d{13}"))
            return false;
        
        return Regex.IsMatch(query, @"ISBN\d{10}");
    }
}