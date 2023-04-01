using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Data
{
    public class Basket
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        [ForeignKey(nameof(ProductId))]
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
