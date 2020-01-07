using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesOrderDataManager.Model;

namespace SalesOrderDataManager.GenRepository.GenManagers
{
    public class SalesOrderHeaaderManager : ISalesOrderHeader
    {
        SalesOrderDetailManager _SalesOrderDetail;

        public SalesOrderHeaaderManager()
        {
            _SalesOrderDetail = new SalesOrderDetailManager();
        }

        public IEnumerable<SalesOrderHeader> GetAllSOHeader()
        {
            throw new NotImplementedException();
        }

        public int GetSOHeaderDocNo()
        {
            SalesOrderHeader _results;
            int _DocID;

            try
            {
                using (SODBContext db = new SODBContext())
                {
                    _results = db.SalesOrderHeaders.OrderByDescending(x => x.Id).Take(1).FirstOrDefault();
                    _DocID = (_results == null) ? 1 : _results.Id;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _DocID;
        }

        public IEnumerable<SalesOrderHeader> GetSOHeader()
        {
            throw new NotImplementedException();
        }

        public Customer GetSOHeaderByID(int ID)
        {
            throw new NotImplementedException();
        }

        public void SaveSOHeader(SalesOrderHeader SO)
        {
            try
            {
                using (SODBContext db = new SODBContext())
                {
                    db.Entry(SO.SalesPerson).State = EntityState.Unchanged;
                    db.Entry(SO.Customer).State = EntityState.Unchanged;
                    db.Entry(SO.Customer.CustCity).State = EntityState.Unchanged;

                    //db.Entry(SO.SalesOrderDetails).State = EntityState.Unchanged;


                    db.SalesOrderHeaders.Add(SO);
                    //db.Entry(SO).State = EntityState.Added;


                    _SalesOrderDetail.SaveSODetail(SO.SalesOrderDetails,db);
                    //foreach (SalesOrderDetail line in SO.SalesOrderDetails)
                    //{
                    //    //line.SalesOrderHeader = SO;
                    //    //db.Entry(line.SalesOrderHeader).State = EntityState.Unchanged;
                    //    db.Entry(line.Item).State = EntityState.Unchanged;
                    //    //db.Entry(line.Item.UnitofMeasure).State = EntityState.Unchanged;
                    //    //db.Entry(line.Item.ItemCategory).State = EntityState.Unchanged;

                    //    //db.Entry(line).State = EntityState.Added;
                    //    //db.Items.Attach(line.Item);
                    //    //db.UnitofMeasures.Attach(line.Item.UnitofMeasure);
                    //    //db.ItemCategories.Attach(line.Item.ItemCategory);

                    //    db.SalesOrderDetails.Add(line);
                    //}

                    db.Entry(SO).State = EntityState.Added;

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DisposeSOHeader()
        {
            throw new NotImplementedException();
        }


    }
}
