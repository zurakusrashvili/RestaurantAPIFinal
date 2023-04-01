using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantAPI.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Boolean Nuts { get; set; }
        public string  Image { get; set; }
        public Boolean Vegeterian { get; set; }
        public int Spiciness { get; set; }


        [ForeignKey(nameof(CategoryId))]
        public int CategoryId { get; set; }
    }
}
