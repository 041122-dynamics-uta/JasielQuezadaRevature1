using System;
using System.Collections.Generic;
using SalesBusiness;
using SalesModels;
using SalesRepository;

namespace Salesmapping
{
    class Program
    {
        //the entrypoint for ANY C# program is the 'static void main()' method
        static void Main(string[] args)
        {    bool registerloop = true;
             while (registerloop = true) //Welcome and login/register loop (do while loop)
            { 
            Console.WriteLine();
            option = Console.ReadLine();
            if (option > 4)
            {
            switch (option)
            { //Choice 0 log in and register
            case 1:
             Console.WriteLine("Please Register or Log In");
            int answer = Console.ReadLine();//choose option
            Console.WriteLine("New Account");//account make variable ask to enter info send info to repo
            break;
            //exsisting user interface: pull user info from repo
            //choose a store loop
            //on choosing a store correctly, you query the DB for the product of that store
            //present them with products and quantities
            //Dictionary(list)<Product>
            case 2:
            Console.WriteLine("Please Select a Store");
            int answer = Console.ReadLine();
            Console.WriteLine("Add items to your cart");
            int answer = Console.ReadLine();
            break;
            //fill your cart loop
            //they choose a product and quantity (switch statement)(choose a product or press 0 to log out)
            //make sure they dont choose more product than is in inventory
            //once they choose to checkout, break out of the loop
            case 3:
            break;
            
            case 4:
            default:
                Console.WriteLine("Would you like to continue shopping or log out?");
            break;
            //add up the total
            //insert the ordered products into the DB
           //ask if they would like to continue shopping 
                 }//EOS
             }//EoW
            }//EoL
//while option is case 1 register and pull in info and send into repo and put into exsisting user 
//while case 2 exisiting user will have info pulled from repo then present chose of store location then pull product
//while case 3 admin alter add more products and delete add store locations
//case 4 default
//if yes loop back to top of choosing store (continue shopping variable)
//if no log out and loop back to start page
//make sure decrement the inventory of each product



            
            
            FamilyRepoClass frc = new FamilyRepoClass();

            FamilyBusinessClass fb = new FamilyBusinessClass(frc);

            if (answer.CompareTo("yes") == 0)
            {
                // create the member class
                List<Member> members = fb.MembersList();

                foreach (Member m in members)
                {
                    Console.WriteLine($"The members data is Fname-{m.Fname}.....");
                }

            }

        }
    }
}
