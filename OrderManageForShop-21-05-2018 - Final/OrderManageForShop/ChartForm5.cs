using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace OrderManageForShop
{
    public partial class ChartForm5 : Form
    {
        public ChartForm5()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            new PlaceOrderForm1().Show();
            this.Hide();
        }

        private void btnViewStock_Click(object sender, EventArgs e)
        {
            new ViewForm2().Show();
            this.Hide();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            new AddForm3().Show();
            this.Hide();
        }

        private void btnEditStock_Click(object sender, EventArgs e)
        {
            new EditForm4().Show();
            this.Hide();
        }
     
        private void RemoveForm5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopJeansDataSet5final.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.shopJeansDataSet5final.Orders);          
        }           
    }
}

