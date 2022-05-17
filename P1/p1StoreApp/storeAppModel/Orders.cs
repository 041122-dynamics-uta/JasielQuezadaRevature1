namespace storeAppModel
{
    public Guid Orders
    {
        public Guid OrdersId { get; set; } 
        public Dictionary<Product, int> Product { get; set;} = new Dictionary<Product, int> ();
        public Customer Customer { get; set; } = new Customer();
        public Store Store { get; set;} = new Store();
    }
}