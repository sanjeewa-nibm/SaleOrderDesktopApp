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


        public void SaveSODetail(IEnumerable<SalesOrderDetail> SO, SODBContext db)
        {
            try
            {

                foreach (SalesOrderDetail line in SO)
                {
                    db.Entry(line.Item).State = EntityState.Unchanged;
                    db.SalesOrderDetails.Add(line);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
