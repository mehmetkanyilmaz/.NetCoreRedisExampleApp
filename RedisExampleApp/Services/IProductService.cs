using RedisExampleApp.Models;

namespace RedisExampleApp.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAsync();
        Task<Product> GetByIdAsync(int id);
        Task<Product> CreateAsync(Product product);
    }
}
