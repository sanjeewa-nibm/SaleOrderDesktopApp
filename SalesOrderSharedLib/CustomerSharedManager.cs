using SalesOrderDataManager.GenRepository.GenManagers;
using SalesOrderDataManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderSharedLib
{
    public class CustomerSharedManager
    {
        CustomerManager _customer;

        public CustomerSharedManager()
        {
             _customer = new CustomerManager(); 
        }
        public IEnumerable<Customer> LoadAllCustomers()
        {
            try
            {
                return _customer.GetAllCustomer();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Customer LoadCustomerByName(string _name)
        {
            try
            {
                return _customer.GetCustomerByName(_name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }

}