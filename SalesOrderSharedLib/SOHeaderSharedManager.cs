using SalesOrderDataManager.GenRepository.GenManagers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderSharedLib
{
    public class SOHeaderSharedManager
    {
        SalesOrderHeaaderManager _SalesOrderHeader;

        public SOHeaderSharedManager()
        {
            _SalesOrderHeader = new SalesOrderHeaaderManager();
        }
        public int GetSOHeaderDocNo()
        {
            try
            {
                return _SalesOrderHeader.GetSOHeaderDocNo();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
