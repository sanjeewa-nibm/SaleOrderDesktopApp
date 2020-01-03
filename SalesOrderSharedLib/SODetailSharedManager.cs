using SalesOrderDataManager.GenRepository.GenManagers;
using SalesOrderDataManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderSharedLib
{
    public class SODetailSharedManager
    {
        SalesOrderDetailManager _SalesOrderHeader;

        public SODetailSharedManager()
        {
            _SalesOrderHeader = new SalesOrderDetailManager();
        }
      
         public void SaveSODetail(SalesOrderDetail SO)
        {
            try
            {
                _SalesOrderHeader.SaveSODetail(SO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
