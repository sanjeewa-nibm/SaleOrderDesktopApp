using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace  SalesOrderDataManager.Model
{
    public class SalesOrderDetail
    {
        public SalesOrderDetail()
        {
            this.Item = new Item();
            //this.SalesOrderHeader = new SalesOrderHeader();
        }

        public int Id { get; set; }
        [ForeignKey("SalesOrderHeader")]
        public int? SoId { get; set; }
        //public string ItemType { get; set; }
        //public int ItemId { get; set; }
        public string ItemCode { get; set; }
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