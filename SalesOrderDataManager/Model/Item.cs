using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  SalesOrderDataManager.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public int StockQuantity { get; set; }
        public decimal UnitPrice { get; set; }

        public int CategoryId { get; set; }
        public virtual ItemCategory ItemCategory { get; set; }

        public int UOMId { get; set; }
        public virtual UnitofMeasure UnitofMeasure { get; set; }
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }

    }
}