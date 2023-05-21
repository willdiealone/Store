namespace Store.Tests;

public class OrderTests
{
    [Fact]
    public void Order_WithNullItems_ThrowsArgumentNullExeprion()
    {
        Assert.Throws<ArgumentNullException>(() => new Order(1, null));
    }

    [Fact]
    public void TotalCount_WithEmpltyItems_RetirnZero()
    {
        var order = new Order(1, new OrderItem[0]);
        
        Assert.Equal(0,order.TotalCount);
    }
    
    [Fact]
    public void TotalPrice_WithEmpltyItems_RetirnZero()
    {
        var order = new Order(1, new OrderItem[0]);
        
        Assert.Equal(0,order.TotalCount);
    }

    [Fact]
    public void TotalCount_WithNotEmpty_CalculatesTotalCounts()
    {
        var order = new Order(1, new[]
        {
            new OrderItem(1, 3, 10m),
            new OrderItem(2, 5, 100m)
        });

        Assert.Equal(3 + 5, order.TotalCount);
    }
    
    [Fact]
    public void TotalPrice_WithNotEmpty_CalculatesTotalPrice()
    {
        var order = new Order(1, new[]
        {
            new OrderItem(1, 3, 10m),
            new OrderItem(2, 5, 100m)
        });

        Assert.Equal((3 * 10m) + (5 * 100m), order.TotalPrice);
    }
}