using System.Runtime.InteropServices.ComTypes;

namespace Store;

// класс нашего заказа
public record OrderItem
{
    // идентификатор заказа
    public int BookId { get; }
    
    // кол-во элементов в заказе
    public int Count { get; }
    
    // цена заказа
    public decimal Price { get; }

    public OrderItem(int BookId,int Count,decimal Price)
    {
        if (Count <= 0)
            throw new ArgumentOutOfRangeException("Counte must greater han zero");
        
        this.BookId = BookId;
        this.Count = Count; 
        this.Price = Price;
    }
}