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
    public partial class ViewForm2 : Form
    {
        public ViewForm2()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            new PlaceOrderForm1().Show();
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

        private void ViewForm2_Load(object sender, EventArgs e)
        {
            ViewStockDataGridView.DataSource = GetStockList();
        }
        private DataTable GetStockList()
        {
            DataTable dtStock = new DataTable();
           
            string connString = @"Data Source=.;Initial Catalog=ShopJeans;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM RemainsStock", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtStock.Load(reader);
                }
            }
            return dtStock;
        }

        //Connection String  
        string cs = @"Data Source=.;Initial Catalog=ShopJeans;Integrated Security=True";
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from RemainsStock where ItemCode like '" + txtSearch.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            ViewStockDataGridView.DataSource = dt;
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            DialogResult del = MessageBox.Show("Are you Sure you want to Delete" + ViewStockDataGridView.SelectedRows[0].Cells[0].Value.ToString() +
                "Record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (del == DialogResult.Yes)
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE from RemainsStock WHERE (StockID='" + ViewStockDataGridView.SelectedRows[0].Cells[0].Value.ToString() + "')", con);
                var j = cmd.ExecuteNonQuery();
                if (j > 0)
                {
                    MessageBox.Show("Record Deleted Successfully!" + j + "");
                    ViewStockDataGridView.DataSource = GetStockList();
                }
                con.Close();
                this.Show();
                this.Refresh();
            }
            else
            {
                this.Show();

            }

        }

        private void ViewStockDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {           
                //int a = e.ColumnIndex;
                //int b = e.RowIndex;
                //Image.GetThumbnailImageAbort myImage = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                //Image image1 = ((Image)this.ViewStockDataGridView.Rows[b].Cells[a].Value).GetThumbnailImage(200, 200, myImage, IntPtr.Zero);
                //this.pictureBox2.Image = image1;          
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            new ChartForm5().Show();
            this.Hide();
        }
        //public bool ThumbnailCallback()
        //{
        //    return false;
        //}
    }
}

