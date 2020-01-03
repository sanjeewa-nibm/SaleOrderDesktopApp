using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesOrderDataManager.Model;

namespace SalesOrderDataManager.GenRepository.GenManagers
{
   public class SalesOrderDetailManager : ISalesOrderDetail
    {
        public void DisposeSODetail()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SalesOrderDetail> GetAllSODetail()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SalesOrderDetail> GetSODetail()
        {
            throw new NotImplementedException();
        }

        public Customer GetSODetailByID(int ID)
        {
            throw new NotImplementedException();
        }


        public void SaveSODetail(SalesOrderDetail SO)
        {
            try
            {
                using (SODBContext db = new SODBContext())
                {
                    db.Entry(SO.SalesOrderHeader).State = EntityState.Unchanged;
                    db.Entry(SO.Item).State = EntityState.Unchanged;
               
                    db.SalesOrderDetails.Add(SO);

                    db.Entry(SO).State = EntityState.Added;


                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
