using SalesOrderDataManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderDataManager.GenRepository
{
    interface ISalesOrderDetail
    {
        IEnumerable<SalesOrderDetail> GetAllSODetail();

        void SaveSODetail(SalesOrderDetail SO); // C

        IEnumerable<SalesOrderDetail> GetSODetail(); // R
        Customer GetSODetailByID(int ID); // R
        ////void UpdateSODetail(Customer cust); //U
        ////void DeleteSODetail(Customer cust); //D

        void DisposeSODetail();
        //bool CustomerNameExists(string custName);
    }
}
