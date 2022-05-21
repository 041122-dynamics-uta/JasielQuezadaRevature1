namespace storeAppModel
{
    public class Inventory
    {
        public int InventoryId { get; set; } = 0;
        public int ProductId_FK { get; set; } 
        //public Dictionary<string, int> Product { get; set;} = new Dictionary<string, int> ();
        public int StoreId_FK { get; set;} = 0;
        public int Quantity { get; set; } = 0;

    }
    
}

//public Dictionary<Product, int> Product { get; set;} = new Dictionary<Product, int> ();