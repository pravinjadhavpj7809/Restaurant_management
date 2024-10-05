namespace TequliasRestaurant.Models
{
    public class OrderViewModel
    {
        
        public decimal TotalAmount { get; set; }
        public List<OrderItemViewModel> OrderItems { get; set; } = new List<OrderItemViewModel>(); // Ensure it's initialized
        public IEnumerable<Product> Products { get; set; } = new List<Product>(); // Ensure it's initialized

    }
}
