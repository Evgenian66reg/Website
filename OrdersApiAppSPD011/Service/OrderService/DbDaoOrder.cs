using OrdersApiAppSPD011.Model.Entity;

namespace OrdersApiAppSPD011.Service.OrderService
{
    //рефлизация методов заказа
    public class DbDaoOrder : IDaoOrder
    {
        private static List<Order> plugOrders = new List<Order>();
        private static int currentId = 1;

        //CRUD
        public Task<Order> AddAsync(Order order)
        {
            order.Id = currentId++;
            plugOrders.Add(order);
            return Task.Run(() => order);
        }

        public Task<Order> DeleteAsync(int id)
        {
            Order order = plugOrders[id];
            plugOrders.RemoveAt(id);
            return Task.Run(() => order);
        }

        public Task<List<Order>> GetAllAsync()
        {
            return Task.Run(() => plugOrders);
        }

        public Task<Order> GetAsync(int id)
        {
            Order order = plugOrders[id];
            plugOrders.IndexOf(order);
            return Task.Run(() => order);
        }

        public Task<Order> UpdateAsync(Order order)
        {
            plugOrders.Insert(order.Id, order);
            return Task.Run(() => order);
        }

        public int total_price_order(Product product, int count_product)
        {
            int sum = product.Price * count_product;
            return sum;
        }
    }
}
