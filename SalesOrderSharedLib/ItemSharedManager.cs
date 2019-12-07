using SalesOrderDataManager.GenRepository.GenManagers;
using SalesOrderDataManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderSharedLib
{
    public class ItemSharedManager
    {
        ItemManager _item;

        public ItemSharedManager()
        {
            _item = new ItemManager();
        }

        public Item LoadItemByName(string _name)
        {
            try
            {
                return _item.GetItemByName(_name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
