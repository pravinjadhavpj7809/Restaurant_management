﻿namespace TequliasRestaurant.Models
{
    [Serializable]
    public class OrderItemViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }


    }
}