using System.ComponentModel;
using System.Data;

namespace Store.Memory;

public class OrderRepository : IOrderRepository
{
    /// <summary>
    /// список заказов
    /// </summary>
    private readonly List<Order> ListOrders = new();

    /// <summary>
    /// Метод создает заказ
    /// </summary>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Order Create()
    {
        var nextId = ListOrders.Count + 1;
        var order = new Order(nextId, new OrderItem[0]);
        
        ListOrders.Add(order);

        return order;
    }

    /// <summary>
    /// Возвращает заказ по id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public Order GetById(int id)
    {
        return ListOrders.SingleOrDefault(order => order.Id == id);
    }

    /// <summary>
    /// Обновляет состояние заказа
    /// </summary>
    /// <param name="order"></param>
    /// <exception cref="NotImplementedException"></exception>
    public void Update(Order order){}
}