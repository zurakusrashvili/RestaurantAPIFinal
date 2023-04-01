namespace RestaurantAPI.Models.Products
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public Boolean Nuts { get; set; }
        public string Image { get; set; }
        public Boolean Vegeterian { get; set; }
        public int Spiciness { get; set; }
        public int CategoryId { get; set; }
    }
}
