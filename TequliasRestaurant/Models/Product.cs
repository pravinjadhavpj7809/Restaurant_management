using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace TequliasRestaurant.Models
{
    [Serializable]
    public class Product
    {
        public Product()
        {
            ProductIngredients = new List<ProductIngredients>();
        }
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public string? Discription { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public string ImageUrl { get; set; } = "https://via.placeholder.com/150";

        [ValidateNever]
        public Category? Category { get; set; }

        [ValidateNever]
        public ICollection<OrderItem>? OrderItems { get; set; }

        [ValidateNever]
        public ICollection<ProductIngredients>? ProductIngredients { get; set; }

      
       




    }
}