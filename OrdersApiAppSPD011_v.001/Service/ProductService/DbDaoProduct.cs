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
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
