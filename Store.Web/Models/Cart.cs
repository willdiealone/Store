
namespace Store.Web.Models;

public class Cart
{
    public IDictionary<int, int> items { get; set; } = new Dictionary<int, int>();

    public decimal Amount { get; set; }
    
}