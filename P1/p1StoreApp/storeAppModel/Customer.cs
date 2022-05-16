using System;

namespace storeAppModel;
public class Customer
{
       //public Guid CustomerIdId { get; set; } = new Guid();
    public int CustomerId { get; set; } = 0;
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Address { get; set; } = "";
    public string City { get; set; } = "";
    public string State { get; set; } = "";
    public string Country { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
    public DateTime DateCreated { get; set; } = DateTime.Now;

}
