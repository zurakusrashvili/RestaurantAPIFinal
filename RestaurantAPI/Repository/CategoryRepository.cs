using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Contracts;
using RestaurantAPI.Data;

namespace RestaurantAPI.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoriesRepository
    {
        private readonly RestaurantOrderDbContext _context;

        public CategoryRepository(RestaurantOrderDbContext context) : base(context)
        {
            this._context = context;
        }

        public async Task<Category> GetDetails(int id)
        {
            return await _context.Categories
                .Include(q => q.Products)
                .FirstOrDefaultAsync(q => q.Id == id);
        }
    }
}
