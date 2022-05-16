namespace storeAppModel
{
    public class Inventory
    {
        public int InventoryId { get; set; } = 0;
        public int InventoryNumber { get; set; } = 0;
        public int ProductId { get; set; } = 0;
        public int StoreId { get; set; } = 0;
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
    
}