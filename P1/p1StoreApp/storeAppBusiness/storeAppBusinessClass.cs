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
    public Customer? newCustomer(string FirstName, string LastName, string Address, string Email, string Password)
    {
        bool exist = repo.emailpwdexists(Email, Password);
        if(exist)
        {
            return null;
        }
        else
        {
            Customer newCustomer = repo.newCustomer(FirstName, LastName, Address, Email, Password);
            return newCustomer;
        }   
    }
    //customer login with email and password
    // public Customer CustomerLogin(string uEmail, string uPassword)
    // {
    //     Customer CustomerLogin = repo.CustomerLogin(uEmail, uPassword);
    //     return CustomerLogin;
    // }
    public List<Customer> CustomerList()
    {
         List<Customer> c = repo.CustomerList();
           return c;
    }
    public List<Store> StoreList()
    {
         List<Store> s = repo.StoreList();
           return s;
    }
    //view product 
    public List<Product> ProductList()
    {
        List<Product> p = repo.ProductList();
        return p;
    }
    public Orders newOrders(int LineItemId, Guid OrdersId, int CustomerId_FK, int ProductId_FK,int StoreId_FK, int Total)
    {
        Orders or = repo.newOrders(LineItemId, OrdersId, CustomerId_FK, ProductId_FK,StoreId_FK, Total);
        return or;
    }
    //method dictionary of product id/quantity + customer id and storeid
    // public Orders SubmitOrder()
    // {

    // }
    public List<Inventory> InventoryList()
    {
        List<Inventory> I = repo.InventoryList();
        return I;
    }
    
}//end
    



   //GetProducts()
    
    
    
   

   

