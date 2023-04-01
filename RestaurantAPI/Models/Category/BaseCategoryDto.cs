using System.ComponentModel.DataAnnotations;

namespace RestaurantAPI.Models.Category
{
    public class BaseCategoryDto
    {
        [Required]
        public string Name { get; set; }
    }
}
