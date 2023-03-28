using OrdersApiAppSPD011.Model.Entity;

namespace OrdersApiAppSPD011.Service.OrderService
{
    // интерфейс DAO для работы с заказом
    public interface IDaoOrder
    {
        Task<List<Order>> GetAllAsync();
        Task<Order> AddAsync(Order order);
        Task<Order> UpdateAsync(Order order);
        Task<Order> DeleteAsync(int id);
        Task<Order> GetAsync(int id);
    }
}
