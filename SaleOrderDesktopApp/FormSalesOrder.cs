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

        private SalesOrderHeader GetUIData()
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


        #endregion

        #region Events
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                SalesOrderHeader obj = GetUIData();

                _SOHeaderSharedMgr.SaveSOHeader(obj);
                MessageBox.Show("ok");
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
                        if (dgSODetails.CurrentCell.ColumnIndex == 0)
                        {
                            Item _item;

                            string _ItemCode = dgSODetails.Rows[e.RowIndex].Cells[0].Value.ToString();

                            _item = _ItemShareMgr.LoadItemByCode(_ItemCode);
                            if (_item != null)
                            {
                                dgSODetails.Rows[e.RowIndex].Cells[1].Value = _item.ItemDescription;
                                dgSODetails.Rows[e.RowIndex].Cells[4].Value = _item.UnitofMeasure.UOM;
                                dgSODetails.Rows[e.RowIndex].Cells[5].Value = _item.UnitPrice;
                            }
                            else
                            {
                                dgSODetails.Rows[e.RowIndex].Cells[1].Value = string.Empty;

                                MessageBox.Show("Item Not Found !", "Sales Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (dgSODetails.CurrentCell.ColumnIndex == 3)
                        {
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sales Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

    }
}
