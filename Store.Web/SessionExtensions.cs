using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Session;
using Store.Web.Models;

namespace Store.Web;

public static class SessionExtensions
{
    private const string key = "Cart";

    public static void Set(this ISession session, Cart value)
    {
        if (value == null)
            return;

        using (var stream = new MemoryStream())
        using (var write = new BinaryWriter(stream, Encoding.UTF8, true))
        {
            write.Write(value.OrderId);
            write.Write(value.TotalCount);
            write.Write(value.TotalPrice);
            
            session.Set(key,stream.ToArray());
        }
    }

    public static bool TryGetCart(this ISession session, out Cart value)
    {
        if (session.TryGetValue(key, out byte[] buffer))
        {
            using(var stream = new MemoryStream(buffer))
            using (var reader = new BinaryReader(stream,Encoding.UTF8,true))
            {
                var orderId = reader.ReadInt32();
                var orderCount = reader.ReadInt32();
                var orderTotalPrice = reader.ReadDecimal();

                value = new Cart(orderId)
                {
                    TotalCount = orderCount,
                    TotalPrice = orderTotalPrice
                };
                return true;
            }    
            
        }

        value = null;
        return false;
    }
}