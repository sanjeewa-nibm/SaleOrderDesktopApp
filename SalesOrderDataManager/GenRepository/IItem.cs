using SalesOrderDataManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderDataManager.GenRepository
{
    interface IItem
    {
        IEnumerable<Item> GetAllItem();
        //void InsertItem(Item ward); // C

        IEnumerable<Item> GetItems(); // R
        Item GetItemByID(int ID); // R
        //void UpdateItem(Item cust); //U
        //void DeleteItem(Item cust); //D

        void DisposeItem();
        bool ItemNameExists(string custName);
    }
}
