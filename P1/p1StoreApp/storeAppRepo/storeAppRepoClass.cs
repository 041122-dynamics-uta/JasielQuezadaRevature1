using System.Data.SqlClient;
using storeAppModel;

namespace storeAppRepo;
public class storeAppRepoClass
{
    public storeAppMapper mapper { get; set; }
    string connectionstring = "Server=tcp:jasielquezadaserver.database.windows.net,1433;Initial Catalog=JasielQuezadastoreApp;Persist Security Info=False;User ID=JasielQuezadaDB;Password=HorseShoe2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

public storeAppRepoClass()
{
    this.mapper = new storeAppMapper();
}//end of mapper definer
public bool emailpwdexists(string Email, string Password)
    {
        string myquery = "SELECT * FROM Customer WHERE Email = '@e' AND Password = '@pw'";
        using (SqlConnection con = new SqlConnection(connectionstring))
    {
    SqlCommand command = new SqlCommand(myquery, con);
    command.Parameters.AddWithValue("@e", Email);
    command.Parameters.AddWithValue("@p", Password);
    command.Connection.Open(); 
    SqlDataReader results = command.ExecuteReader(); 
    
    if (results.Read()){
        con.Close();
        return true;       
    }   
    else
    {
        con.Close();
        return false;
    }
 }
}//end
public Customer? newCustomer(string FirstName, string LastName, string Address, string Email, string Password)
    
    {
    string myQuery1 = "INSERT INTO Customer(FirstName, LastName, address, email, password) VALUES(@f, @l, @a, @e, @p)";
    using (SqlConnection query1 = new SqlConnection(connectionstring))
    {
    SqlCommand command = new SqlCommand(myQuery1, query1);
    command.Parameters.AddWithValue("@f", FirstName);
    command.Parameters.AddWithValue("@l", LastName);
    command.Parameters.AddWithValue("@a", Address);
    command.Parameters.AddWithValue("@e", Email);
    command.Parameters.AddWithValue("@p", Password);
    command.Connection.Open(); //open the connection to the DB
    SqlDataReader results1 = command.ExecuteReader(); //do the query
    query1.Close();

    if (results1.Read())
    {
        Customer c = this.mapper.DboToCustomer(results1);
        query1.Close();
        return c;
    } 
    else
    {
        query1.Close();
        return null; 
    }          
    } 
     
}//end

public List<Customer> CustomerList()
    {
   string myQuery2 = "SELECT * FROM Customer WHERE Email = @e AND Password = @p";
    using (SqlConnection query2 = new SqlConnection(connectionstring))
    {
     SqlCommand command = new SqlCommand(myQuery2, query2);
     query2.Open(); 
     SqlDataReader results2 = command.ExecuteReader(); 

        List<Customer> c = new List<Customer>();
        while (results2.Read())
        { 
            c.Add(this.mapper.DboToCustomer(results2));
        }
        query2.Close();
        return c;   
    }  
 }
//  public Customer CustomerLogin(string Email, string Password)
//     {
//     string myQuery2 = "SELECT * FROM Customer WHERE Email = @e AND Password = @p";
//     using (SqlConnection query2 = new SqlConnection(connectionstring))
//     {
//     SqlCommand command = new SqlCommand(myQuery2, query2);
//     command.Parameters.AddWithValue("@e", Email);
//     command.Parameters.AddWithValue("@p", Password);
//     command.Connection.Open(); 
//     SqlDataReader results2 = command.ExecuteReader(); 

//     if (results2.Read()){
//         Customer c = this.mapper.DboToCustomer(results2);
//         query2.Close();
//         return c;       
//     }  
//     else{
//         query2.Close();
//         return null;
//     }  
//  }
// }//Public list end
 public List<Store> StoreList()
    {
    //string connectionstring = "Server=tcp:jasielquezadaserver.database.windows.net,1433;Initial Catalog=JasielQuezadastoreApp;Persist Security Info=False;User ID=JasielQuezadaDB;Password=HorseShoe2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    string myQuery3 = "SELECT * FROM Store";
    using (SqlConnection query3 = new SqlConnection(connectionstring))
    {
    SqlCommand command = new SqlCommand(myQuery3, query3);
    query3.Open(); 
    SqlDataReader results3 = command.ExecuteReader(); 

        List<Store> s = new List<Store>();
        while (results3.Read())
        { 
            s.Add(this.mapper.DboToStore(results3));
        }
        query3.Close();
        return s;   
    }
}//endofclass
 public List<Product> ProductList()
    {
    string myQuery4 = "SELECT * FROM Product";
    using (SqlConnection query4 = new SqlConnection(connectionstring))
    {
    SqlCommand command = new SqlCommand(myQuery4, query4);
    query4.Open();
    //command.Connection.Open(); 
    SqlDataReader results4 = command.ExecuteReader(); 

        List<Product> p = new List<Product>();
        while (results4.Read())
        {
            p.Add(this.mapper.DboToProduct(results4));
        }
        query4.Close();
        return p;   
    }
  }
//orders
public Orders newOrders(int LineItemId, Guid OrdersId, int CustomerId_FK, int ProductId_FK, int StoreId_FK, int Total)
    {
    string myQuery5 = "INSERT INTO Orders(LineItemId, OrdersId, CustomerId_FK, ProductId_FK, StoreId_FK, Total) VALUES(@li, @o, @ci, @pi, @s, @t";
    using (SqlConnection query5 = new SqlConnection(connectionstring))
    {
    SqlCommand command = new SqlCommand(myQuery5, query5);
    command.Parameters.AddWithValue("@li", LineItemId);
    command.Parameters.AddWithValue("@o", OrdersId);
    command.Parameters.AddWithValue("@ci", CustomerId_FK);
    command.Parameters.AddWithValue("@p", ProductId_FK);
    command.Parameters.AddWithValue("@s", StoreId_FK);
    command.Parameters.AddWithValue("@pr", Total);
    command.Connection.Open(); 
    int results = command.ExecuteNonQuery();
    query5.Close();

         if (results == 1){
        Orders or = new Orders
        {
            LineItemId = LineItemId,
            OrdersId = OrdersId,
            CustomerId_FK = CustomerId_FK,
            ProductId_FK = ProductId_FK,
            StoreId_FK = StoreId_FK,
            Total = 0,   
        };
        return or;     
    }
    return null;
  }
    }
//    public Orders SubmitOrder()
//     {

//     }
    
//inventory
  public List<Inventory> InventoryList()
    {
    string myQuery7 = "SELECT * FROM Inventory";
    using (SqlConnection query7 = new SqlConnection(connectionstring))
          {
        SqlCommand command = new SqlCommand(myQuery7, query7); 
        query7.Open();
        SqlDataReader results7 = command.ExecuteReader();

        List<Inventory> I = new List<Inventory>();
        while (results7.Read())
        {
            I.Add(this.mapper.DboToInventory(results7));
        }
        query7.Close();
        return I;  
        }
    }
  
 }//end of the whole thing

   

