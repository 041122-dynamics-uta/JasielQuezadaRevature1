using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using storeAppBusiness;
using storeAppModel;
using storeAppRepo;

namespace p1StoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            storeAppRepoClass src = new storeAppRepoClass();
            storeAppBusinessClass sbc = new storeAppBusinessClass(src);
            Customer newCustomer = new Customer();
            Product newProduct = new Product();
            Dictionary<Product, int> dict = new Dictionary<Product, int>();
            bool registerloop = true;
            while (registerloop == true){ //Welcome and login/register loop (do while loop)
            Console.WriteLine("Welcome To Marvel Merch Store");
            Console.WriteLine("(1) Register");
            Console.WriteLine("(2) Log In");
            Console.WriteLine("(3) Exit");
            string registerLogin = Console.ReadLine();//choose option
            switch(registerLogin){
                case "1":
            Console.WriteLine("Enter First Name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            registerloop = false;
            newCustomer = sbc.newCustomer(FirstName, LastName, address, email, password);
            break;
            case "2": //Log in 
            Console.WriteLine("Please enter your Email");
            string uEmail = Console.ReadLine();
            Console.WriteLine("Please enter your Password");
            string upassword = Console.ReadLine();
            registerloop = false;
            break;
            case "3":
            registerloop = !true;//exit
            break;
            default:
            Console.WriteLine("Invalid choice. Please try again");
            break;
        
            }//end of switch case
        }
    
//choose a store loop, on choosing a store correctly, you query the DB for the product of that store
 //Dictionary(list)<Product>
            bool storeloop = true;
            while (storeloop == true){   
            Console.WriteLine("Please select a store");
            Console.WriteLine("(1) Atlanta");
            Console.WriteLine("(2) Los Angeles");
            Console.WriteLine("(3) Exit");
            string storeLocation = Console.ReadLine();
            switch(storeLocation){
                case "1":
                Console.WriteLine("You have Selected our Atlanta location");
                string store1 = Console.ReadLine();
                storeloop = false;
                break;
                case "2":
                Console.WriteLine("You have Selected our Los Angeles location");
                string store2 = Console.ReadLine();
                storeloop = false;
                break;
                case "3":
                storeloop = !false;
                break;
                default:
                break;
            } //fill your cart loop
             //they choose a product and quantity (switch statement)
            bool cartloop = true;
            while (cartloop == true){
            Console.WriteLine("(1) Add items to your cart");
            Console.WriteLine("(2) Check Out");
            Console.WriteLine("(3) Cancel My Order");
            Console.WriteLine("(4) Continue");
            Console.WriteLine("(5) Log Out"); 
            string additems = Console.ReadLine();
            switch(additems){
            case "1":
            Console.WriteLine("Add Items To Your Cart");
            Console.WriteLine("(1) WandaVision T-Shirt");
            Console.WriteLine("(2) Loki T-Shirt");
            Console.WriteLine("(3) Hulk Gloves");
            Console.WriteLine("(4) Iron Man Helmet");
            Console.WriteLine("(5) Thor Pajamas");
            string items = Console.ReadLine();
                switch(items){
                    case"1":
                    Console.WriteLine("You added WandaVision T-Shirt");
                    break;
                    case "2":
                    Console.WriteLine("You added Loki T-Shirt");
                    break;
                    case "3":
                    Console.WriteLine("You added Hulk Gloves");
                    break;
                    case "4":
                    Console.WriteLine("You added Iron Man Helmet");
                    break;
                    case "5":
                    Console.WriteLine("You added Thor Pajamas");
                    break;
                } 
            break;
            case "2":     
            Console.WriteLine("Would you like to add more to you cart or check out");
            Console.WriteLine("(1) Continue Shopping");
            Console.WriteLine("(2) Check Out");
            string cart = Console.ReadLine();
                switch(cart){
                    case"1":
                    Console.WriteLine("Continue Shopping");
                    Console.ReadLine();
                    break;
                    case "2":
                    Console.WriteLine("Log Out");
                    Console.ReadLine();
                    cartloop = false;
                     break; }
                     
            break;
            case "3":
            Console.WriteLine("Cancel your order");
            Console.ReadLine(); 
            cartloop = false;
            break;
            case "4":
            Console.WriteLine("Would you like to continue shopping or log out?");
            Console.WriteLine("(1) Continue Shopping");
            Console.WriteLine("(2) Log Out");
            Console.ReadLine();
            cartloop = false;
            break;
            case "5":
                cartloop = false;
                break;    
            default:
            break;
                 }//EOswitchcase
             }//EoIf statement
    }//Eo static void main
}//Eo class program
}//end of namespace
}


//make sure they dont choose more product than is in inventory
//once they choose to checkout, break out of the loop
//add up the total
//insert the ordered products into the DB
//ask if they would like to continue shopping 
//while option is case 1 register and pull in info and send into repo and put into exsisting user 
//while case 2 exisiting user will have info pulled from repo then present chose of store location then pull product
//while case 3 admin alter add more products and delete add store locations
//case 4 default
//if yes loop back to top of choosing store (continue shopping variable)
//if no log out and loop back to start page
//make sure decrement the inventory of each product

  // Console.WriteLine("Please select items to add to your cart\n");//present them with products and quantities
            // string listanswer = Console.ReadLine();
            // Console.WriteLine("\n");
            // if (listanswer.CompareTo("yes") == 0)
            // {
            //     List<Product> Product = sbc.ProductList();
            //     foreach (Product p in Product)
            //     {
            //         Console.WriteLine($"Product {p.ProductId} is {p.Name}");
            //     }
            // }

// public Customer newCustomer = new Customer();
//             static List<Inventory> InventoryList = new List<Inventory>();
//             static List<Orders> Orders = new List<Orders>();
//             static List<Product> products = new List<Product>();
