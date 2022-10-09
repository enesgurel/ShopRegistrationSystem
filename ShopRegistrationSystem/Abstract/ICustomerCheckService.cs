using ShopRegistrationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopRegistrationSystem.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
