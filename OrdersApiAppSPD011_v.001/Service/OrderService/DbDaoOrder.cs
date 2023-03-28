using OrdersApiAppSPD011.Model.Entity;

namespace OrdersApiAppSPD011.Service.OrderService
{
    public class DbDaoOrder : IDaoOrder
    {
        private static List<Order> plugOrders = new List<Order>();
        private static int currentId = 1;

        public Task<Order> AddAsync(Order order)
        {
            order.Id = currentId++;
            plugOrders.Add(order);
            return Task.Run(() => order);
        }

        public Task<Order> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Order> UpdateAsync(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
