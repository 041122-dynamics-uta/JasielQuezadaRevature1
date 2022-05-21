namespace storeAppModel
{
    public class Orders
    {
        public int LineItemId { get; set; } 
        public Guid OrdersId { get; set; } 
        public int CustomerId_FK { get; set;}
        public int ProductId_FK { get; set;}
        //public Customer Customer { get; set; } = new Customer();
        //public Dictionary<Product, int> Product { get; set;} = new Dictionary<Product, int> ();
        //public Store Store { get; set;} = new Store();
        public int StoreId_FK { get; set; } = 0;
        public decimal Total { get; set; } = 0;
    }
}