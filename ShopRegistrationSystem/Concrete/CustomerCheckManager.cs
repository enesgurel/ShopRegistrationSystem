using ShopRegistrationSystem.Abstract;
using ShopRegistrationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopRegistrationSystem.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
