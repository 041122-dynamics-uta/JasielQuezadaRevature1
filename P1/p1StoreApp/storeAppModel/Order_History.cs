namespace storeAppModel
{
    public class Order_History
    {
        public int Order_HistoryId { get; set; } = 0;
        public int OrderId { get; set; } = 0;
        public int Total { get; set;} = 0;
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}