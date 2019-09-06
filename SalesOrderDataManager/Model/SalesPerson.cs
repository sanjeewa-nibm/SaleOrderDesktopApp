using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace  SalesOrderDataManager.Model
{
    public class SalesPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PersonCode { get; set; }

        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }

    }
}