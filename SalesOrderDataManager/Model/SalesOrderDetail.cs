using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  SalesOrderDataManager.Model
{
    public class SalesOrderDetail
    {
        public int Id { get; set; }
        public int SoId { get; set; }
        public string ItemType { get; set; }
        public int ItemId { get; set; }
        public string ItemDescription { get; set; }
        public string LocationCode { get; set; }
        public int Quantity { get; set; }
        public string UOM { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal LineAmount { get; set; }
        public decimal LineDiscount { get; set; }

        public virtual Item Item { get; set; }
        public virtual SalesOrderHeader SalesOrderHeader { get; set; }

    }
}