namespace storeAppModel
{
    public class Store
    {
        public int StoreId { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public string City { get; set; } = "";
        public string State { get; set; } = "";
        public string PostalCode { get; set; } = "";
        public string Phone { get; set; } = "";
        public string Email { get; set; } = "";
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}