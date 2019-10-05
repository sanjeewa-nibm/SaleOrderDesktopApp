using SalesOrderDataManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderDataManager.GenRepository.GenManagers
{
    public class CustomerManager : ICustomer
    {
        public IEnumerable<Customer> GetAllCustomer()
        {
            IEnumerable<Customer> _results;
            try
            {
                using (SODBContext db = new SODBContext())
                {
                    _results = db.Customers.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _results;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerByID(int ID)
        {
            Customer _results;
            try
            {
                using (SODBContext db = new SODBContext())
                {
                    _results = db.Customers.Find(ID);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _results;
        }

        public Customer GetCustomerByName(string Name)
        {
            Customer _results;
            try
            {
                using (SODBContext db = new SODBContext())
                {
                    _results = db.Customers.Where(x => x.CustName == Name).FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _results;
        }

        public void DisposeCustomer()
        {
            throw new NotImplementedException();
        }

        public bool CustomerNameExists(string custName)
        {
            throw new NotImplementedException();
        }
    }

}
