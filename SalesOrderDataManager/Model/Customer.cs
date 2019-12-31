using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  SalesOrderDataManager.Model
{
    public class Customer
    {
        public Customer()
        {
            this.CustCity = new CustomerCity();
        }
        public int Id { get; set; }
        public string CustName { get; set; }
        //public int CityId { get; set; }

        public virtual CustomerCity CustCity { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    }
}