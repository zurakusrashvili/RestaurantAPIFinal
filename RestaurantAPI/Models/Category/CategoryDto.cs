using RestaurantAPI.Data;

namespace RestaurantAPI.Models.Category
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IList<Product> Products { get; set; }

    }
}
