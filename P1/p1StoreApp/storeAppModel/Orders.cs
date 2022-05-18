namespace storeAppModel
{
    public class Orders
    {
        public int LineItemId { get; set; } 
        public Guid OrdersId { get; set; } 
        public Customer Customer { get; set; } = new Customer();
        public Dictionary<Product, int> Product { get; set;} = new Dictionary<Product, int> ();
        public Store Store { get; set;} = new Store();
        public decimal Price { get; set; } = 0;
    }
}