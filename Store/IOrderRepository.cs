namespace Store;

public interface IOrderRepository
{
    // Создание заказа
    public Order Create();

    // Возвращает заказ по id
    public Order GetById(int id);

    // Обновляет состояние заказа
    public void Update(Order order);
}