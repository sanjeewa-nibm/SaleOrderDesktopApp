using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  SalesOrderDataManager.Model
{
    public class ItemCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Item> Items { get; set; }

    }
}