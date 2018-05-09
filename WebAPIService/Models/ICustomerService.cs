using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIService.Models
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();
        List<Customer> GetCustomerEntities();
        bool AddCustomer();
    }
}