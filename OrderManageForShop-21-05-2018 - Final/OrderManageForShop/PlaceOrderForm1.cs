using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;

namespace OrderManageForShop
{
    public partial class PlaceOrderForm1 : Form
        
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ShopJeans;Integrated Security=True");
        SqlCommand cmd;

        public PlaceOrderForm1()
        {
            InitializeComponent();
        }
        private void btnViewStock_Click_1(object sender, EventArgs e)
        {
            new ViewForm2().Show();
            this.Hide();
        }
        private void btnAddNewItem_Click_1(object sender, EventArgs e)
        {
            new AddForm3().Show();
            this.Hide();
        }
        private void btnEditStock_Click_1(object sender, EventArgs e)
        {
            new EditForm4().Show();
            this.Hide();
        }

        private void PlaceOrderForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopJeansDataSet5final.RemainsStock' table. You can move, or remove it, as needed.
            this.remainsStockTableAdapter.Fill(this.shopJeansDataSet5final.RemainsStock);

            ItemCodeComboBox.Text = " ";
            txtPrice.Text = " ";
            txtStock.Text = " ";
            lblOrderDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");         
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewAddToCart.CurrentCell.RowIndex;
            dataGridViewAddToCart.Rows.RemoveAt(rowIndex);
            lblGrandTotalCalc.Text = dataGridViewAddToCart.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDouble(t.Cells[4].Value)).ToString();
        }

        private void numericUpDownQty_ValueChanged(object sender, EventArgs e)
        {
            Double calcTotal = Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(numericUpDownQty.Value);
            txtTotal.Text = calcTotal.ToString();
        }
        
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            int n = dataGridViewAddToCart.Rows.Add();
            dataGridViewAddToCart.Rows[n].Cells[0].Value = ItemCodeComboBox.Text;
            dataGridViewAddToCart.Rows[n].Cells[1].Value = txtPrice.Text;
            dataGridViewAddToCart.Rows[n].Cells[2].Value = txtStock.Text;
            dataGridViewAddToCart.Rows[n].Cells[3].Value = numericUpDownQty.Value;
            dataGridViewAddToCart.Rows[n].Cells[4].Value = txtTotal.Text;

            //calculate Grand Total
            double total = dataGridViewAddToCart.Rows.Cast<DataGridViewRow>()
                .Sum(t => Convert.ToDouble(t.Cells[4].Value));
            lblGrandTotalCalc.Text = total.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblGrandTotalCalc.Text = "";
            dataGridViewAddToCart.Rows.Clear();
            txtTotal.Text = "0";
            ItemCodeComboBox.Text = " ";
            txtPrice.Text = " ";
            txtStock.Text = " ";
            numericUpDownQty.ResetText();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = (Bitmap)Image.FromFile(@"C:\Users\ipd13\Desktop\Nailia\Visual Basic .Net  C#\Final Project\OrderManageForShop-21-05-2018 - Final\images\logo1.png", true);
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);

            Bitmap bm = new Bitmap(this.dataGridViewAddToCart.Width, this.dataGridViewAddToCart.Height);
            dataGridViewAddToCart.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridViewAddToCart.Width, this.dataGridViewAddToCart.Height));
            e.Graphics.DrawImage(bm, 80,150);
            e.Graphics.DrawString(dataGridViewAddToCart.Container + "Total:" + lblGrandTotalCalc.Text, new Font("Arial", 16, FontStyle.Bold), Brushes.DarkBlue, new Point(650, 380));

        }

        private void btnProceedOrder_Click(object sender, EventArgs e)
        {
            con.Open();           
            cmd = new SqlCommand("INSERT INTO Orders (OrderTotal, OrderDate) " +
                "VALUES (@OrderTotal, @OrderDate)", con);
            cmd.Parameters.AddWithValue("@OrderTotal", Convert.ToDouble(lblGrandTotalCalc.Text));
            cmd.Parameters.AddWithValue("@OrderDate", lblOrderDate.Text);
            cmd.ExecuteNonQuery();
            con.Close();

            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ShopJeans;Integrated Security=True;MultipleActiveResultSets=true;"))
            {
                con.Open();
                string sql = "SELECT max(OrderID) from [dbo].[Orders] ";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    lblReaderOrder.Text = cmd.ExecuteScalar().ToString();
                }
                con.Close();
                con.Open();
                int v_itemId = 0;
                for (int i = 0; i < dataGridViewAddToCart.Rows.Count; i++)
                {
                    string sqlItemId = "SELECT ItemID from Purchase where ItemCode = '" + dataGridViewAddToCart.Rows[i].Cells[0].Value + "'";

                    using (SqlCommand cmd = new SqlCommand(sqlItemId, con))
                    {
                        SqlDataReader reader1 = cmd.ExecuteReader();

                        while (reader1.Read())
                        {
                            v_itemId = Convert.ToInt32(reader1["ItemID"]);
                        }
                            SqlCommand cmd1 = new SqlCommand("INSERT INTO OrderDetails (OrderID, ItemID, Qty, Total) VALUES (@OrderID, @ItemID, @Qty, @Total)", con);
                            cmd1.Parameters.AddWithValue("@OrderID", Convert.ToInt32(lblReaderOrder.Text));
                            cmd1.Parameters.AddWithValue("@ItemID", v_itemId);
                            cmd1.Parameters.AddWithValue("@Qty", Convert.ToInt32(dataGridViewAddToCart.Rows[i].Cells[3].Value));
                            cmd1.Parameters.AddWithValue("@Total", Convert.ToDouble(dataGridViewAddToCart.Rows[i].Cells[4].Value));
                            cmd1.ExecuteNonQuery();
                    }
                }
                con.Close();
            }         
            MessageBox.Show("Order placed!");
            lblGrandTotalCalc.Text = "";
            dataGridViewAddToCart.Rows.Clear();
            txtTotal.Text = "0";
            ItemCodeComboBox.Text = " ";
            txtPrice.Text = " ";
            txtStock.Text = " ";
            numericUpDownQty.ResetText();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            new ChartForm5().Show();
            this.Hide();
        }
    }
}
