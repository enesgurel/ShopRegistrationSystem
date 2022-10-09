using ShopRegistrationSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopRegistrationSystem.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
