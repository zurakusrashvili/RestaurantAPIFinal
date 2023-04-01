namespace RestaurantAPI.Models.Products
{
    public class FilterProductsDto
    {
        public Boolean? Nuts { get; set; }
        public Boolean? Vegeterian { get; set; }
        public int? Spiciness { get; set; }
    }
}
