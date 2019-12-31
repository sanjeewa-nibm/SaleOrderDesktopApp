using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace  SalesOrderDataManager.Model
{
    public class SalesOrderHeader
    {
        public SalesOrderHeader()
        {
            this.SalesPerson = new SalesPerson();
            this.Customer = new Customer();
        }
        public int Id { get; set; }
        //public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustCity { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public System.DateTime PostingDate { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public System.DateTime OrderDate { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public System.DateTime DocumentDate { get; set; }

        [Required]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public System.DateTime DeliveryDate { get; set; }

        //public int SalesPersonId { get; set; }
        public bool Status { get; set; }
        public decimal SoDiscountAmount { get; set; }
        public decimal SoTotal { get; set; }
        public decimal SoDiscount { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }


    }
}