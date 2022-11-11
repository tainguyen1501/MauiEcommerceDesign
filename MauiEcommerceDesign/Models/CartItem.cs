namespace MauiEcommerceDesign.Models
{
    public class CartItem
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OldPrice { get; set; }
        public string Description { get; set; }
        public string[] Images { get; set; }
        public string[] Colors { get; set; }
        public string[] Sizes { get; set; }
        public int Quantity { get; set; }
    }
}
