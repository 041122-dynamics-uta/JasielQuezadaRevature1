namespace storeAppModel
{
    public class Product
    {
        public int ProductId { get; set; } = 0;
        public int StoreId { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Color { get; set; } = "";
        public string Size { get; set; } = "";
        public string Description { get; set; } = "";
        public int UnitPrice { get; set; } = 0;
        public int Quantity { get; set; } = 0;
        public DateTime DateCreated { get; set; } = DateTime.Now;
        
    }
}