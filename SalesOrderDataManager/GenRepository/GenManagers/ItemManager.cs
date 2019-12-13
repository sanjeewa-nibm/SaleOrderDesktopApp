using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesOrderDataManager.Model;

namespace SalesOrderDataManager.GenRepository.GenManagers
{
    public class ItemManager : IItem
    {
        public void DisposeItem()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAllItem()
        {
            throw new NotImplementedException();
        }

        public Item GetItemByID(int ID)
        {
            Item _results;
            try
            {
                using (SODBContext db = new SODBContext())
                {
                    _results = db.Items.Find(ID);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _results;
        }

        public IEnumerable<Item> GetItems()
        {
            throw new NotImplementedException();
        }

        public bool ItemNameExists(string custName)
        {
            throw new NotImplementedException();
        }

        public Item GetItemByName(string Name)
        {
            Item _results;

            try
            {
                using (SODBContext db = new SODBContext())
                {
                    _results = db.Items
                            //.Include("CustomerCity")
                            .Where(x => x.ItemDescription == Name)
                            .FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _results;
        }
        public Item GetItemByCode(string Code)
        {
            Item _results;

            try
            {
                using (SODBContext db = new SODBContext())
                {
                    _results = db.Items
                            //.Include("CustomerCity")
                            .Where(x => x.ItemCode == Code)
                            .FirstOrDefault();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _results;
        }
    }
}
