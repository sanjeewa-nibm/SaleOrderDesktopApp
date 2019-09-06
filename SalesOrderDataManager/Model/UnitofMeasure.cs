using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  SalesOrderDataManager.Model
{
    public class UnitofMeasure
    {
        public int Id { get; set; }
        public string UOM { get; set; }

        public virtual ICollection<Item> Items { get; set; }

    }
}