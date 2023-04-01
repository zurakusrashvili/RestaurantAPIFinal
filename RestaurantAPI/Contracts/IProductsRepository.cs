using RestaurantAPI.Data;
using RestaurantAPI.Models.Products;

namespace RestaurantAPI.Contracts
{
    public interface IProductsRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetFiltered(bool? vegeterian, bool? nuts, int? spiciness, int? categoryId);
    }
}
