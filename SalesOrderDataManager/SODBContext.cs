
using SalesOrderDataManager.Migrations;
using SalesOrderDataManager.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesOrderDataManager
{
    public class SODBContext : DbContext
    {
        public SODBContext() : base("CommonContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = true;

            var ensureDllIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SODBContext, Configuration>());


        }
        public virtual DbSet<CustomerCity> CustomerCities { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ItemCategory> ItemCategories { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual DbSet<SalesPerson> SalesPersons { get; set; }
        public virtual DbSet<UnitofMeasure> UnitofMeasures { get; set; }

    }

}
