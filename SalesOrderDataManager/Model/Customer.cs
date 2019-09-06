using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  SalesOrderDataManager.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustName { get; set; }
        public int CityId { get; set; }

        public virtual CustomerCity CustomerCity { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    }
}