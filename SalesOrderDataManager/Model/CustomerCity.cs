using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  SalesOrderDataManager.Model
{
    public class CustomerCity
    {
        public int Id { get; set; }
        public string CityName { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }

    }
}