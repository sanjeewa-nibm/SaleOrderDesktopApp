using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesOrderDataManager.Model;

namespace SalesOrderDataManager.GenRepository.GenManagers
{
    public class SalesOrderHeaaderManager : ISalesOrderHeader
    {
      
        public IEnumerable<SalesOrderHeader> GetAllSOHeader()
        {
            throw new NotImplementedException();
        }

        public int GetSOHeaderDocNo()
        {
            SalesOrderHeader _results;
            int _DocID;

            try
            {
                using (SODBContext db = new SODBContext())
                {
                    _results = db.SalesOrderHeaders.OrderByDescending(x => x.Id).Take(1).FirstOrDefault();
                    _DocID = (_results == null) ? 1 : _results.Id;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _DocID;
        }

        public IEnumerable<SalesOrderHeader> GetSOHeader()
        {
            throw new NotImplementedException();
        }

        public Customer GetSOHeaderByID(int ID)
        {
            throw new NotImplementedException();
        }

        public void SaveSOHeader(SalesOrderHeader SO)
        {
            try
            {
                using (SODBContext db = new SODBContext())
                {
                    db.Entry(SO.SalesPerson).State = EntityState.Unchanged;
                    db.Entry(SO.Customer).State = EntityState.Unchanged;
                    db.Entry(SO.Customer.CustCity).State = EntityState.Unchanged;
                    db.SalesOrderHeaders.Add(SO);

                    ////db.CustomerCities.Remove(SO.Customer.CustCity);
                    ////db.Customers.Remove(SO.Customer);
                  

                    db.Entry(SO).State = EntityState.Added;


                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DisposeSOHeader()
        {
            throw new NotImplementedException();
        }


    }
}
