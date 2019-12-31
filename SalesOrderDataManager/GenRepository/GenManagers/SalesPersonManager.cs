using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesOrderDataManager.Model;

namespace SalesOrderDataManager.GenRepository.GenManagers
{
    public class SalesPersonManager : ISalesPerson
    {
        public void DisposeSalesPerson()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SalesPerson> GetAllSalesPerson()
        {
            IEnumerable<SalesPerson> _results;
            try
            {
                using (SODBContext db = new SODBContext())
                {
                    _results = db.SalesPersons.ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _results;
        }

        public IEnumerable<SalesPerson> GetSalesPerson()
        {
            throw new NotImplementedException();
        }

        public SalesPerson GetSalesPersonByID(int ID)
        {
            throw new NotImplementedException();
        }
        public SalesPerson GetSalesPersonByName(string salespName)
        {
            SalesPerson _results;

            try
            {
                using (SODBContext db = new SODBContext())
                {
                    _results = db.SalesPersons
                            .Where(x => x.Name == salespName)
                            .FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _results;
        }
        public bool SalesPersonNameExists(string salespName)
        {
            throw new NotImplementedException();
        }
    }
}
