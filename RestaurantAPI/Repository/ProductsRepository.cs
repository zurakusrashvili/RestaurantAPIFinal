using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Contracts;
using RestaurantAPI.Data;
using RestaurantAPI.Models.Products;

namespace RestaurantAPI.Repository
{
    public class ProductsRepository : GenericRepository<Product>, IProductsRepository
    {
        private readonly RestaurantOrderDbContext _context;

        public ProductsRepository (RestaurantOrderDbContext context) : base(context)
        {
            this._context = context;
        }


        public async Task<List<Product>> GetFiltered(bool? vegetarian, bool? nuts, int? spiciness, int? categoryId)
        {
            var query = _context.Products
                .Where(p => categoryId == null || p.CategoryId == categoryId)
                .Where(p => vegetarian == null || p.Vegeterian == vegetarian)
                .Where(p => nuts == null || (nuts == true ? p.Nuts : !p.Nuts))
                .Where(p => spiciness == null || p.Spiciness == spiciness);

            var products = await query.ToListAsync();
            return products;
        }

    }
}
