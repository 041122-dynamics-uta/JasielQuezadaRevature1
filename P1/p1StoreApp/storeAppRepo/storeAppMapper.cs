using System.Data.SqlClient;
using storeAppModel;
namespace storeAppRepo
{
    public class storeAppMapper
    {
         //create a method that will transfer the date from the customer list return into customers
        public Customer DboToCustomer(SqlDataReader read)
        {
            Customer c = new Customer
            {
                CustomerId = (int) read[0],
                FirstName = (string) read[1],
                LastName = (string) read[2],
                Address = (string) read[3],
                City = (string) read[4],
                State = (string) read[5],
                Country = (string) read[6],
                PostalCode = (string) read[7],
                Phone = (string) read[8],
                Email = (string) read[9],
                Password = (string) read[10],
                DateCreated = (DateTime) read[11],    
            };
            return c;
       }
       public Inventory DboToInventory(SqlDataReader read)
        {
            Inventory I = new Inventory
            {
                InventoryId = (int) read[0],
                InventoryNumber = (int) read[1],
                ProductId = (int) read[2],
                StoreId = (int) read[3],
                DateCreated = (DateTime) read[4],    
            };
            return I;
        }
      public Order_History DboToOrder_History(SqlDataReader read)
        {
            Order_History oh = new Order_History
            {
                Order_HistoryId = (int) read[0],
                OrderId = (int) read[1],
                DateCreated = (DateTime) read[2],    
            };
            return oh;
        }
        public Orders DboToOrders(SqlDataReader read)
        {
            Orders or = new Orders
            {
                OrdersId = (int) read[0],
                CustomerId = (int) read[1],
                ProductId = (int) read[2],
                DateCreated = (DateTime) read[3],    
            };
            return or;
        }

        internal Product DboToProduct(SqlDataReader read)
        {
            Product p = new Product
            {
                ProductId = (int) read[0],
                StoreId = (int) read[1],
                Name = (string) read[2],
                Color = (string) read[3],
                Size = (string) read[4],
                Description = (string) read[5],
                UnitPrice = (int) read[6],
                Quantity = (int) read[7],
                DateCreated = (DateTime) read[8],    
            };
            return p;
        }

        public Store DboToStore(SqlDataReader read)
        {
            Store s = new Store
            {
                StoreId = (int) read[1],
                Address = (string) read[2],
                City = (string) read[3],
                State = (string) read[4],
                PostalCode = (string) read[5],
                Phone = (string) read[6],
                Email = (string) read[7],
                DateCreated = (DateTime) read[8],    
            };
            return s;
        }

}//EOC
}//EON

