using System;
using System.Collections.Generic;
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

         public void DisposeSOHeader()
        {
            throw new NotImplementedException();
        }


    }
}
