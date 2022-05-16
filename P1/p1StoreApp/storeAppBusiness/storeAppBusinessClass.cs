using System.Data.SqlClient;
using storeAppModel;
using storeAppRepo;

namespace storeAppBusiness;
public class storeAppBusinessClass
{     //inject the dependency into the class
    public storeAppRepoClass repo { get; set; }
    
    public storeAppBusinessClass(storeAppRepoClass r)
    {
        this.repo = r;
    }
    
    public Customer newCustomer(string FirstName, string LastName, string address, string email, string password)
    {
        Customer c = repo.newCustomer(FirstName, LastName, address, email, password);//make query
        return c;
    }
    public Orders newOrders(int CustomerId, int ProductId, int Total)
    {
        Orders or = repo.newOrders(CustomerId, ProductId, Total);//make query
        return or;
    }
    
    public Product newProduct(int StoreId, string Name, string Color, string Size, string Description, int UnitPrice, int Quantity)
    {
        
        Product p = repo.newProduct(StoreId, Name, Color, Size, Description, UnitPrice, Quantity);//make query
        return p;
    }
    // public Inventory InventoryList(int InventoryNumber, int ProductId, int StoreId)
    // {
    //     Inventory I = repo.Inventory(InventoryNumber, ProductId, StoreId);
    //     return I;
    // }
    // public List<Inventory> InventoryList()
    // {
    //     List<Inventory> I = repo.InventoryList();
    //     return I;
    // }
    // public List<Order_History> Order_HistoryList(int Order_HistoryId)
    // {
    //     List<Order_History> oh = repo.Order_History();

    //     return oh;
    // }
    // public List<Product> ProductList()
    // {
    //     List<Product> p = repo.ProductList();
    //     return p;
    // }
    // public List<Store> StoreList()
    // {
    //     List<Store> s = repo.StoreList();
    //     return s;
    // }
   
}
   

