using OrdersApiAppSPD011.Model.Entity;

namespace OrdersApiAppSPD011.Service.ProductService
{
    public class DbDaoProduct : IDaoProduct
    {
        private static List<Product> plugProducts = new List<Product>();
        private static int currentId = 1;

        public Task<Product> AddAsync(Product product)
        {
            product.Id = currentId++;
            plugProducts.Add(product);
            return Task.Run(() => product);
        }

        public Task<Product> DeleteAsync(int id)
        {
            Product product = plugProducts[id];
            plugProducts.RemoveAt(id);
            return Task.Run(() => product);
        }

        public Task<List<Product>> GetAllAsync()
        {
            return Task.Run(() => plugProducts);
        }

        public Task<Product> GetAsync(int id)
        {
            Product product = plugProducts[id];
            plugProducts.IndexOf(product);
            return Task.Run(() => product);
        }

        public Task<Product> UpdateAsync(Product product)
        {
            plugProducts.Insert(product.Id, product);
            return Task.Run(() => product);
        }
    }
}
