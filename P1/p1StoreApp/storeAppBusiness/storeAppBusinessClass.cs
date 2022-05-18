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
    public void newCustomer(string FirstName, string LastName, string address, string email, string password)
    //public Customer newCustomer(string FirstName, string LastName, string address, string email, string password)
    {
        Customer c = repo.newCustomer(FirstName, LastName, address, email, password);//make query
        return;
    }
    //customer login with email and password
    public void customerLogin()
    {

    }
    //view product from a store
    public List<Product> ProductList(int StoreId, string Name, string Description, int UnitPrice, int Quantity)
    {
        List<Product> p = repo.ProductList(StoreId, Name, Description, UnitPrice, Quantity);
        return p;
    }
    public List<Orders> OrderList(Guid CustomerId, int ProductId, int Total)
    {
        List<Orders> p = repo.OrdersList(CustomerId, ProductId, Total);
        return p;
    }
    //method dictionary of product id/quantity + customer id and storeid
    public void SubmitOrder()
    {

    }
// public List<Store> StoreList()

    // {
    //     List<Store> s = repo.StoreList();
    //     return s;
    // }




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
    
   
}
   

