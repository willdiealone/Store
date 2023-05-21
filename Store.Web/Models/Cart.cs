
using Microsoft.AspNetCore.Server.Kestrel.Transport.Quic;

namespace Store.Web.Models;

public class Cart
{
    /// <summary>
    /// идентификатор заказа
    /// </summary>
    public int OrderId { get; }

    /// <summary>
    /// общее кол-во книг в заказе
    /// </summary>
    public int TotalCount { get; set; }

    /// <summary>
    /// общая цена заказа
    /// </summary>
    public decimal TotalPrice { get; set; }

    public Cart(int OrderId)
    {
        this.OrderId = OrderId;
        TotalCount = 0;
        TotalPrice = 0m;
    }
    
}