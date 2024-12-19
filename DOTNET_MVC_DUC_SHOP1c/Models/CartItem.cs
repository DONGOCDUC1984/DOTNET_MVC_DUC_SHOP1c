namespace DOTNET_MVC_DUC_SHOP1c.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public Cart Cart { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
