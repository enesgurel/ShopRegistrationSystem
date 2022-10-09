using ShopRegistrationSystem.Abstract;
using ShopRegistrationSystem.Adapters;
using ShopRegistrationSystem.Concrete;
using System;

namespace ShopRegistrationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BaseCustomerManager customerManager = new NeroCustomerManager();
            //BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter()); //correct ID number required
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new CustomerCheckManager());
            customerManager.Save(new Entities.Customer { DateOFBirth = new DateTime(2000,12,25), FirstName = "Enes", LastName = "Gürel", NationalityId="123456789"});
            Console.ReadLine();
        }
    }
}
