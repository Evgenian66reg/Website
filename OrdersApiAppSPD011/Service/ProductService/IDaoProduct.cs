using OrdersApiAppSPD011.Model.Entity;

namespace OrdersApiAppSPD011.Service.ProductService
{
    // интерфейс DAO для работы с товаром
    public interface IDaoProduct
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> AddAsync(Product product);
        Task<Product> UpdateAsync(Product product);
        Task<Product> DeleteAsync(int id);
        Task<Product> GetAsync(int id);
    }
}
