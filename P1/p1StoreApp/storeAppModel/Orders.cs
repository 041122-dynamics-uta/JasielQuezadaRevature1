namespace storeAppModel
{
    public class Orders
    {
        public int OrdersId { get; set; } = 0;
        public int CustomerId { get; set; } = 0;
        public int ProductId { get; set; } = 0;
        public int Total { get; set; } = 0;
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}