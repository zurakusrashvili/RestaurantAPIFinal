using RestaurantAPI.Data;

namespace RestaurantAPI.Contracts
{
    public interface IBasketRepository : IGenericRepository<Basket>
    {
        Task<Basket> GetDetails(int id);
        Task<Product> GetProductDetails(int id);
        Task<List<Basket>> GetBasketsAsync();
        Task<Basket> GetBasketWithProductId(int id);

        Task DeleteProductFromBasket(Basket basket);
    }
}
