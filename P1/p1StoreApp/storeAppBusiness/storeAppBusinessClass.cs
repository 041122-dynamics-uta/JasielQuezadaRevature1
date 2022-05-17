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
    //register customer
    public void newCustomer()
    //public Customer newCustomer(string FirstName, string LastName, string address, string email, string password)
    {
        Customer c = repo.newCustomer(FirstName, LastName, address, email, password);//make query
        return c;
    }
    //customer login with email and password
    public void customerLogin()
    {

    }
    //view product from a store
    public List<Product> ProductList(StoreId, Name, Color, Size, Description, UnitPrice, Quantity)
    {
        
    }
    public List<Order> OrderList(CustomerId, ProductId, Total)
    {

    }
    //method dictionary of product id/quantity + customer id and storeid
    public void SubmitOrder()
    {

    }
    //public Orders newOrders(int CustomerId, int ProductId, int Total)
    // {
    //     Orders or = repo.newOrders(CustomerId, ProductId, Total);//make query
    //     return or;
    // }
    // public List<Inventory> InventoryList()
    // {
    //     List<Inventory> I = repo.InventoryList();
    //     return I;
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
   

