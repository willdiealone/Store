namespace Store; 

// класс нашего заказа
public class Order
{
    // идентификатор заказа
    public int Id { get; set; }
    
    // список наших элементов заказов
    private List<OrderItem> ListOrderItems;

    //некая обертка ввиде (readonly) коллекции
    // мы можем получить для чтения наш список, но не можем изменять
    public IReadOnlyCollection<OrderItem> OrderItemsCollection
    {
        // возвращаем наш список
        get => ListOrderItems ;
    }

    // общее кол-во книг в заказе
    public int TotalCount
    {
        get { return ListOrderItems.Sum(item => item.Count); }
    }
    
    // общая цена заказа
    public decimal TotalPrice
    {
        get { return ListOrderItems.Sum(item => item.Price * item.Count); }
    }

    public Order(int Id,IEnumerable<OrderItem> items)
    {
        if (items == null)
            throw new ArgumentNullException(nameof(items));
        
        
        this.Id = Id;
        ListOrderItems = new List<OrderItem>(items);
    }

    /// <summary>
    /// метод добавляет заказ
    /// </summary>
    /// <param name="book">Книга которую мы передаем</param>
    /// <param name="count">Кол-во этих книг</param>
    public void AddItem(Book book, int count)
    {
        if (book == null)
            throw new ArgumentNullException(nameof(book));

        var item = ListOrderItems.SingleOrDefault(i => i.BookId == book.Id);

        if (item == null)
        {
            ListOrderItems.Add(new OrderItem(book.Id,count,book.Price));
        }
        else
        {
            ListOrderItems.Remove(item);
            ListOrderItems.Add(new OrderItem(book.Id,item.Count + count,book.Price));
        }
            
    }
    
    
    
    
    
    
    
    
    
     
    
    
    
    
    
    
    
    
    
}