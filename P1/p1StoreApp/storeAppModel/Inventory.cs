namespace storeAppModel
{
    public class Inventory
    {
        public int InventoryId { get; set; } = 0;
        public Dictionary<string, int> Product { get; set;} = new Dictionary<string, int> ();
        public Store Store { get; set;} = new Store();
        public int Quantity { get; set; } = 0;

    }
    
}

//public Dictionary<Product, int> Product { get; set;} = new Dictionary<Product, int> ();