using SalesOrderDataManager.Model;
using SalesOrderSharedLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleOrderDesktopApp
{
    public partial class FormSalesOrder : Form
    {
        IEnumerable<Customer> _CustomerList;
        IEnumerable<SalesPerson> _SalesPersonList;

        CustomerSharedManager _CustShareMgr = new CustomerSharedManager();
        SalesPersonSharedManager _SalesPersonShareMgr = new SalesPersonSharedManager();
        SOHeaderSharedManager _SOHeaderSharedMgr = new SOHeaderSharedManager();
        SODetailSharedManager _SODetailSharedMgr = new SODetailSharedManager();

        ItemSharedManager _ItemShareMgr = new ItemSharedManager();

        #region Constructor
        public FormSalesOrder()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void LoadAllCustomers()
        {
            _CustomerList = _CustShareMgr.LoadAllCustomers();

            foreach (var item in _CustomerList)
            {
                cmbCustomerName.Items.Add(item.CustName);
            }

        }

        private void LoadAllSalesPerson()
        {
            _SalesPersonList = _SalesPersonShareMgr.LoadAllSalesPersons();

            foreach (var item in _SalesPersonList)
            {
                cmbSalesPerson.Items.Add(item.Name);
            }

        }

        private void LoadSODocumentNo()
        {
            try
            {
                textBoxSalesOrderID.Text = _SOHeaderSharedMgr.GetSOHeaderDocNo().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private SalesOrderHeader GetUIHeaderData()
        {
            SalesOrderHeader _soheader = new SalesOrderHeader();

            try
            {
                _soheader.CustName = cmbCustomerName.Text;
                _soheader.CustCity = textBoxCity.Text;
                _soheader.DocumentDate = dtDocDate.Value;
                _soheader.DeliveryDate = dtDeliveryDate.Value;

                _soheader.SalesPerson.Id = _SalesPersonShareMgr.LoadSalesPersonByName(cmbSalesPerson.Text).Id;
                _soheader.Customer = _CustShareMgr.LoadCustomerByName(cmbCustomerName.Text);

                 /*   _soheader.SalesPerson = new SalesPerson() { Name = cmbSalesPerson.Text };
                _soheader.Customer  = new Customer() { CustName = cmbCustomerName.Text  , CustCity = new CustomerCity { CityName = textBoxCity.Text } };


                SalesPerson salesPerson=  _SalesPersonShareMgr.LoadSalesPersonByName(cmbSalesPerson.Text);
                _soheader.SalesPerson = salesPerson;

                Customer cust = new Customer()
                {
                    CustName = cmbCustomerName.Text,

                };

                CustomerCity custcity = new CustomerCity()
                {
                    CityName = textBoxCity.Text
                };
                cust.CustomerCity = custcity;



                _soheader.Customer = cust;
                _soheader.SalesPerson.Id = salesPerson.Id;
                _soheader.SalesPerson.Name = salesPerson.Name;*/
                _soheader.DocumentDate = dtDocDate.Value;
                _soheader.PostingDate = dtPostingDate.Value;
                _soheader.OrderDate = dtOrderDate.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
            return _soheader;
        }

        private void GetUIDetailData(SalesOrderHeader h)
        {
            //ICollection<SalesOrderDetail> _x = h.SalesOrderDetails;
            h.SalesOrderDetails = new List<SalesOrderDetail>();
            try
            {
                
                for (int i = 0; i < dgSODetails.Rows.Count - 1 ; i++)
                {
                    SalesOrderDetail x = new SalesOrderDetail();

                    //x.SalesOrderHeader.Id = h.Id;
                    x.SalesOrderHeader = h;

                    string _code = dgSODetails.Rows[i].Cells[1].Value.ToString();
                    Item _item = _ItemShareMgr.LoadItemByCode(_code);

                    //x.Item = _item;
                    //x.Item.UnitofMeasure = _item.UnitofMeasure;
                    //x.Item.ItemCategory = _item.ItemCategory;

                    x.Item.Id = _item.Id;
                    //x.Item.UnitofMeasure.Id = _item.UnitofMeasure.Id;
                    //x.Item.ItemCategory.Id = _item.ItemCategory.Id;

                    x.ItemCode = _code;
                    x.ItemDescription = dgSODetails.Rows[i].Cells[2].Value.ToString();
                    x.LocationCode = dgSODetails.Rows[i].Cells[3].Value.ToString();
                    x.Quantity = int.Parse(dgSODetails.Rows[i].Cells[4].Value.ToString());
                    x.UOM = dgSODetails.Rows[i].Cells[5].Value.ToString();
                    x.UnitPrice = decimal.Parse(dgSODetails.Rows[i].Cells[6].Value.ToString());
                    //x.LineAmount = decimal.Parse(dgSODetails.Rows[i].Cells[8].Value.ToString());
                    x.LineDiscount = decimal.Parse(dgSODetails.Rows[i].Cells[7].Value.ToString());

                    //_x.Add(x);
                    h.SalesOrderDetails.Add(x);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            //return _x;

        }

        private void CalculateAllDiscount()
        {
            decimal _FinalDiscouAmount = 0;
            try
            {
                for (int i = 0; i < dgSODetails.Rows.Count - 1; i++)
                {
                    decimal _DiscountPer = 0;
                    decimal _Qty = 0, _Price = 0;

                    decimal.TryParse(dgSODetails.Rows[i].Cells[7].Value.ToString(), out _DiscountPer);                    

                    decimal.TryParse(dgSODetails.Rows[i].Cells[4].Value.ToString(), out _Qty);
                    decimal.TryParse(dgSODetails.Rows[i].Cells[6].Value.ToString(), out _Price);

                    decimal _Amount = _Qty * _Price;

                    _FinalDiscouAmount += (_DiscountPer / 100) * _Amount;

                    labelAllDiscount.Text =  _FinalDiscouAmount.ToString();

                }
            }
            catch (Exception ex)
            { 
                throw ex;
            }
        }

        private void CalculateAllAmount()
        {
            decimal _LineAmount = 0;
            decimal _FinalValue = 0;
            try
            {
                for (int i = 0; i < dgSODetails.Rows.Count - 1; i++)
                {
                    decimal.TryParse(dgSODetails.Rows[i].Cells[8].Value.ToString(), out _LineAmount);

                    _FinalValue += _LineAmount;

                    labelAllAmount.Text = _FinalValue.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void CalculateFullTotal()
        {
            try
            {
                labelFullAmount.Text = labelAllAmount.Text;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

        #region Events
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SalesOrderHeader objH = GetUIHeaderData();

                //objH.SalesOrderDetails = GetUIDetailData(objH);
                GetUIDetailData(objH);


                _SOHeaderSharedMgr.SaveSOHeader(objH);
                //_SODetailSharedMgr.SaveSODetail(objH.SalesOrderDetails);
                MessageBox.Show("Sales Order Saved !");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }       

        private void buttonClose_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCustomerName.SelectedItem != null)
                {
                    //MessageBox.Show(cmbCustomerName.SelectedItem.ToString());
                    Customer _cust = _CustShareMgr.LoadCustomerByName(cmbCustomerName.SelectedItem.ToString());
                    textBoxCustomerID.Text = _cust.Id.ToString();
                    textBoxCity.Text = _cust.CustCity.CityName.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void FormSalesOrder_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllCustomers();
                LoadAllSalesPerson();
                LoadSODocumentNo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgSODetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgSODetails.CurrentCell != null)
                {
                    if (e.RowIndex != -1)
                    {
                        decimal _FinalReducedAmount = 0;

                        if (dgSODetails.CurrentCell.ColumnIndex == 1)
                        {
                            Item _item;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
                            string _ItemCode = dgSODetails.Rows[e.RowIndex].Cells[1].Value.ToString();

                            _item = _ItemShareMgr.LoadItemByCode(_ItemCode.Trim());
                            if (_item != null)
                            {
                                dgSODetails.Rows[e.RowIndex].Cells[2].Value = _item.ItemDescription;
                                dgSODetails.Rows[e.RowIndex].Cells[5].Value = _item.UnitofMeasure.UOM;
                                dgSODetails.Rows[e.RowIndex].Cells[6].Value = _item.UnitPrice;
                            }
                            else
                            {
                                dgSODetails.Rows[e.RowIndex].Cells[2].Value = string.Empty;

                                MessageBox.Show("Item Not Found !", "Sales Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (dgSODetails.CurrentCell.ColumnIndex == 4)
                        {
                            decimal _Qty=0, _Price =0;

                             decimal.TryParse(dgSODetails.Rows[e.RowIndex].Cells[4].Value.ToString(),out _Qty);
                            decimal.TryParse(dgSODetails.Rows[e.RowIndex].Cells[6].Value.ToString(),out _Price);

                            decimal _Amount = _Qty * _Price;

                            dgSODetails.Rows[e.RowIndex].Cells[8].Value = _Amount.ToString();
                            CalculateAllAmount();
                            CalculateFullTotal();
                        }
                        else if (dgSODetails.CurrentCell.ColumnIndex == 7)
                        {
                            decimal _DiscountPer = 0, _FinalAmount = 0;
                            _FinalReducedAmount = 0;

                            decimal.TryParse(dgSODetails.Rows[e.RowIndex].Cells[7].Value.ToString(), out _DiscountPer);
                            decimal.TryParse(dgSODetails.Rows[e.RowIndex].Cells[8].Value.ToString(), out _FinalAmount);

                            _FinalReducedAmount = (1 - (_DiscountPer / 100)) * _FinalAmount;

                            //dgSODetails.Rows[e.RowIndex].Cells[8].Value = _FinalReducedAmount.ToString();
                        }

                        if (_FinalReducedAmount>0 && e.ColumnIndex==7)
                        {
                            dgSODetails.Rows[e.RowIndex].Cells[8].Value = _FinalReducedAmount.ToString();
                            CalculateAllDiscount();
                            CalculateAllAmount();
                            CalculateFullTotal();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sales Order",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void dgSODetails_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (e.ColumnIndex == 0)
                {
                    if (MessageBox.Show("Are You Sure Delete Current Item?", "Sales Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                        if (dgSODetails.Rows[e.RowIndex].IsNewRow)
                        {
                            MessageBox.Show("No data to delete ", "Sales Order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            dgSODetails.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sales Order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        #endregion

        private void textFullDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 ) ///todo tab key add
            {
                decimal FullAmt = 0,FullDiscount = 0;
                decimal.TryParse(labelFullAmount.Text,out FullAmt);
                decimal.TryParse(textFullDiscount.Text, out FullDiscount);

                FullAmt = FullAmt - FullDiscount;

                labelFullAmount.Text = FullAmt.ToString();
            }
        }
    }
}
