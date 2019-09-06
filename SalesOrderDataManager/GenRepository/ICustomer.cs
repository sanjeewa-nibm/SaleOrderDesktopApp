using SalesOrderDataManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderDataManager.GenRepository
{
    interface ICustomer
    {
        IEnumerable<Customer> GetAllCustomer();
        //void InsertCustomer(Customer ward); // C

        IEnumerable<Customer> GetCustomers(); // R
        Customer GetCustomerByID(int ID); // R
        //void UpdateCustomer(Customer cust); //U
        //void DeleteCustomer(Customer cust); //D

        void DisposeCustomer();
        bool CustomerNameExists(string custName);

    }
}
