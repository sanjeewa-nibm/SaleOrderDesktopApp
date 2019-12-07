using SalesOrderDataManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderDataManager.GenRepository
{
    interface ISalesOrderHeader
    {
        IEnumerable<SalesOrderHeader> GetAllSOHeader();
        int GetSOHeaderDocNo();

        //void InsertSOHeader(SalesOrderHeader ward); // C

        IEnumerable<SalesOrderHeader> GetSOHeader(); // R
        Customer GetSOHeaderByID(int ID); // R
        //void UpdateSOHeader(Customer cust); //U
        //void DeleteSOHeader(Customer cust); //D

        void DisposeSOHeader();
        //bool CustomerNameExists(string custName);
    }
}
