using SalesOrderDataManager.GenRepository.GenManagers;
using SalesOrderDataManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderSharedLib
{
    public class SalesPersonSharedManager
    {
        SalesPersonManager _SalesPerson;

        public SalesPersonSharedManager()
        {
            _SalesPerson = new SalesPersonManager();
        }
        public IEnumerable<SalesPerson> LoadAllSalesPersons()
        {
            try
            {
                return _SalesPerson.GetAllSalesPerson();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public SalesPerson LoadSalesPersonByName(string _name)
        {
            try
            {
                return _SalesPerson.GetSalesPersonByName(_name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
