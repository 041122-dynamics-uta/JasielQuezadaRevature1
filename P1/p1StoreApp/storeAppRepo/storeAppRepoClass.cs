using System.Data.SqlClient;
using storeAppModel;



namespace storeAppRepo;
public class storeAppRepoClass
{
    public storeAppMapper mapper { get; set; }
    string connectionstring = "Server=tcp:jasielquezadaserver.database.windows.net,1433;Initial Catalog=JasielQuezadaSales;Persist Security Info=False;User ID=JasielQuezadaDB;Password=HorseShoe2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

public storeAppRepoClass()
{
    this.mapper = new storeAppMapper();
}

public Customer newCustomer(string FirstName, string LastName, string address, string email, string password)
    {
    string myQuery1 = "INSERT INTO Customer(FirstName, LastName, address, email, password) VALUES(@f, @l, @a, @e, @p)";
    using (SqlConnection query1 = new SqlConnection(connectionstring))
    {
    SqlCommand command = new SqlCommand(myQuery1, query1);
    command.Parameters.AddWithValue("@f", FirstName);
    command.Parameters.AddWithValue("@l", LastName);
    command.Parameters.AddWithValue("@a", address);
    command.Parameters.AddWithValue("@e", email);
    command.Parameters.AddWithValue("@p", password);
    command.Connection.Open(); //open the connection to the DB
    int results = command.ExecuteNonQuery(); //do the query
    query1.Close();

    if (results == 1){
        Customer c = new Customer
        {
            CustomerId = 1,
            FirstName =FirstName,
            LastName = LastName,
            Address = address,
            Email = email,
            Password = password,
        };
        return c;       
    }    
    return null; 
 }
  List<Inventory> InventoryList()
    {
    string myQuery2 = "SELECT * FROM Inventory";

    using (SqlConnection query2 = new SqlConnection(connectionstring))
    {
    SqlCommand command = new SqlCommand(myQuery2, query2);
    command.Connection.Open(); 
    SqlDataReader results = command.ExecuteReader(); 

        List<Inventory> I = new List<Inventory>();
        while (results.Read())
        {
            I.Add(this.mapper.DboToInventory(results));
        }

        query2.Close();
        return I;  
    }
  }
}//Public list end

    public Orders newOrders(int CustomerId, int ProductId, int Total)
    {
    string myQuery3 = "INSERT INTO Orders(CustomerId, ProductId, Total) VALUES(@ci, @pi, @t";
    using (SqlConnection query3 = new SqlConnection(connectionstring))
    {
    SqlCommand command = new SqlCommand(myQuery3, query3);
    command.Parameters.AddWithValue("@ci", CustomerId);
    command.Parameters.AddWithValue("@pi", ProductId);
    command.Parameters.AddWithValue("@t", Total);
    command.Connection.Open(); 
    int results = command.ExecuteNonQuery();
    query3.Close();

         if (results == 1){
        Orders or = new Orders
        {
            OrdersId = 0,
            CustomerId = CustomerId,
            ProductId = ProductId,
            Total = 0,
            
        };
        return or;     
    }
    return null;
  }
    List<Order_History> Order_HistoryList()
    {
    string myQuery4 = "SELECT * FROM Order_History";

    using (SqlConnection query4 = new SqlConnection(connectionstring))
    {
    SqlCommand command = new SqlCommand(myQuery4, query4);
    command.Connection.Open(); 
    SqlDataReader results = command.ExecuteReader(); 

        List<Order_History> oh = new List<Order_History>();
        while (results.Read())
        {
            oh.Add(this.mapper.DboToOrder_History(results));
        }

        query4.Close();
        return oh;  
    }
  }
    Product newProduct(int StoreId, string Name, string Color, string Size, string Description, int UnitPrice, int Quantity)
    {
    string myQuery4 = "INSERT INTO Product(StoreId, Name, Color, Size, Description, UnitPrice, Quantity) VALUES(@s, @n, @s, @d, @up, @q";
    using (SqlConnection query4 = new SqlConnection(connectionstring))
    {
    SqlCommand command = new SqlCommand(myQuery4, query4);
    command.Parameters.AddWithValue("@s", StoreId);
    command.Parameters.AddWithValue("@n", Name);
    command.Parameters.AddWithValue("@c", Color);
    command.Parameters.AddWithValue("@s", Size);
    command.Parameters.AddWithValue("@d", Description);
    command.Parameters.AddWithValue("@up", UnitPrice);
    command.Parameters.AddWithValue("@q", Quantity);
    command.Connection.Open(); 
    int results = command.ExecuteNonQuery();
    query4.Close();

         if (results == 1){
        Product p = new Product
        {
            ProductId = 0,
            StoreId = StoreId,
            Name = Name,
            Color = Color,
            Size = Size,
            Description = Description,
            UnitPrice = UnitPrice,
            Quantity = Quantity,
        };
        return p;     
    }
    return null;
  }
    }
//     List<Product> ProductList();
//     {
//     string myQuery5 = "SELECT * FROM Product";

//     using (SqlConnection query5 = new SqlConnection(connectionstring))
//     {
//     SqlCommand command = new SqlCommand(myQuery5, query5);
//     command.Connection.Open(); 
//     SqlDataReader results = command.ExecuteReader(); 

//         List<Product> p = new List<Product>();
//         while (results.Read())
//         {
//             p.Add(this.mapper.DboToProduct(results));
//         }
//         query5.Close();
//         return p;   
//     }
//   }
  List<Store> StoreList()
    {
    string myQuery6 = "SELECT * FROM Store";

    using (SqlConnection query6 = new SqlConnection(connectionstring))
    {
    SqlCommand command = new SqlCommand(myQuery6, query6);
    command.Connection.Open(); 
    SqlDataReader results = command.ExecuteReader(); 

        List<Store> s = new List<Store>();
        while (results.Read())
        {
            s.Add(this.mapper.DboToStore(results));
        }
        query6.Close();
        return s;   
    }
  }
}//endofclass
}

