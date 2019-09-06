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
    public partial class Form1 : Form
    {
        CustomerSharedManager x = new CustomerSharedManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            try
            {
                foreach (var item in x.LoadAllCustomers())
                {
                    MessageBox.Show(item.CustName);
                }
                MessageBox.Show("ok");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
