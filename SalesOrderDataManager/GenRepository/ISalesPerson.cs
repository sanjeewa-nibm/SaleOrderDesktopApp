using SalesOrderDataManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderDataManager.GenRepository
{
    interface ISalesPerson
    {
        IEnumerable<SalesPerson> GetAllSalesPerson();
        //void InsertSalesPerson(SalesPerson sp); // C

        IEnumerable<SalesPerson> GetSalesPerson(); // R
        SalesPerson GetSalesPersonByID(int ID); // R
        //void UpdateSalesPerson(SalesPerson sp); //U
        //void DeleteSalesPerson(SalesPerson sp); //D

        void DisposeSalesPerson();
        bool SalesPersonNameExists(string salespName);

    }
}
