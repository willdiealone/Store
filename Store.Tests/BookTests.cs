namespace Store.Tests;

// тестируем только методы класса Book
public class BookTests
{
    [Fact]
    public void IsIsbn_WithNull_ReturnFalse()
    {
        bool actual = Book.IsIsbn(null);
        
        Assert.False(actual);
    }
    
    // [Fact]
    // public void IsIsbn_WithBlankSpace_ReturnFalse()
    // {
    //     bool actual = Book.IsIsbn("   ");
    //     
    //     Assert.False(actual);
    // }
    
    [Fact]
    public void IsIsbn_WithIsbn10Digits_ReturnTrue()
    {
        bool actual = Book.IsIsbn("IsbN 12345-678910");
        
        Assert.True(actual);
    }
    
    [Fact]
    public void IsIsbn_WithIsbn13Digits_ReturnFalse()
    {
        bool actual = Book.IsIsbn("ISBN 123-45-123-4 5123");
        
        Assert.True(actual);
    }
    
    [Fact]
    public void IsIsbn_WithTrashStart_ReturnFalse()
    {
        bool actual = Book.IsIsbn("xxxx ISBN 123-45-123-4 5123 yyyy");
        
        Assert.False(actual);
    }
}