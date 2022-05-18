namespace storeAppModel
{
    public class Inventory
    {
        public int InventoryId { get; set; } = 0;
        public Dictionary<Product, int> Product { get; set;} = new Dictionary<Product, int> ();
        public Store Store { get; set;} = new Store();

    }
    
}