namespace storeAppModel
{
    public class Product
    {
        public int ProductId { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int UnitPrice { get; set; } = 0;  
        public int Quantity { get; set; } = 0; 
    }
}