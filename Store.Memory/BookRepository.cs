namespace Store.Memory;

public class BookRepository : IBookRepository
{

    public readonly Book[] book =
    {
        new Book(1, "The Art Of Programming","ISBN 12345-678910","D. Knuth",
            "The bible of all fundamental algorithms and the work that taught many of today’s software developers most of what they know about computer programming.\n—Byte, September 1995",209.98m),
        
        new Book(2, "Refactoring","ISBN 12345-678911","M. Fowler",
            "This eagerly awaited new edition has been fully updated to reflect crucial changes in the programming landscape. Refactoring, Second Edition, features an updated catalog of refactoring's and includes JavaScript code examples, as well as new functional examples that demonstrate refactoring without classes.",70.0m),
        
        new Book(3, "The C# Programming Language","ISBN 12345-678912","A. Hejlsber",
            decrHejlsber,14.98m)
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

    public Book GetById(int Id)
    {
        return book.Single(b => b.Id == Id);
    }
    
    const string decrHejlsber = "C# is a simple, modern, object-oriented, and type-safe programming language that combines the high productivity of rapid application development languages with the raw power of C and C++. Written by the language's architect, Anders Hejlsberg, and design team members, and now updated for C# 2.0, The C# Programming Language, Second Edition, is the definitive technical reference for C#. The book provides the complete specification of the language, along with descriptions, reference materials, and code samples from the C# design team." +
                                "\nThe first part of the book opens with an introduction to the language to bring readers quickly up-to-speed on the concepts of C#. Next follows a detailed and complete technical specification of the C# 1.0 language, as delivered in Visual Studio .NET 2002 and 2003. Topics covered include Lexical Structure, Types, Variables, Conversions, Expressions, Statements, Namespaces, Exceptions, Attributes, and Unsafe Code." +
                                "\nThe second part of the book describes the many new features of C# 2.0, including Generics, Anonymous Methods, Iterators, Partial Types, and Nullable Types. This second edition describes C# 2.0 as actually released in Visual Studio .NET 2005, with many additions and improvements over the design presented in the first edition. Reference tabs and an exhaustive index allow readers to easily navigate the text and quickly find the topics that interest them most." +
                                "\nThe C# Programming Language, Second Edition, is the definitive reference for programmers who want to acquire an in-depth knowledge of C#.";
}