using RestaurantAPI.Data;

namespace RestaurantAPI.Contracts
{
    public interface ICategoriesRepository : IGenericRepository<Category>
    {
        Task<Category> GetDetails(int id);
    }
}
