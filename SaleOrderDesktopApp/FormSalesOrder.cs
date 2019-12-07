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
        IEnumerable<Customer> _CustomerList ;
        IEnumerable<SalesPerson> _SalesPersonList;

        CustomerSharedManager _CustShareMgr = new CustomerSharedManager();
        SalesPersonSharedManager _SalesPersonShareMgr = new SalesPersonSharedManager();
        SOHeaderSharedManager _SOHeaderSharedMgr = new SOHeaderSharedManager();

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

        #endregion

        #region Events
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("ok");
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
                    Customer _cust =  _CustShareMgr.LoadCustomerByName(cmbCustomerName.SelectedItem.ToString());
                    textBoxCustomerID.Text = _cust.Id.ToString();
                    textBoxCity.Text = _cust.CustomerCity.CityName.ToString();
                }

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

        #endregion

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgSODetails.CurrentCell != null)
                {
                    if (e.RowIndex != -1)
                    {
                        if (dgSODetails.CurrentCell.ColumnIndex == 0)
                        {
                            //if (_currentSalaryTrans != null)
                            //{
                            //    //_currentSalaryTrans.ValidateAmountRate();
                            //}
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Salary Transactions",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
