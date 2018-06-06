using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManageForShop
{
    public partial class EditForm4 : Form
    {
        SqlCommand cmd;
        SqlConnection con;

        public EditForm4()
        {
            InitializeComponent();
        }
        private void btnPlaceOrder_Click_1(object sender, EventArgs e)
        {
            new PlaceOrderForm1().Show();
            this.Hide();
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
        private void btnSales_Click(object sender, EventArgs e)
        {
            new ChartForm5().Show();
            this.Hide();
        }

        private void EditForm4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shopJeansDataSet5final.RemainsStock' table. You can move, or remove it, as needed.
            this.remainsStockTableAdapter1.Fill(this.shopJeansDataSet5final.RemainsStock);
            // TODO: This line of code loads data into the 'shopJeansDataSetMyLast.RemainsStock' table. You can move, or remove it, as needed.
            this.remainsStockTableAdapter.Fill(this.shopJeansDataSetMyLast.RemainsStock);
            comboBoxItemCode.Text = " ";
            txtCost.Text = " ";
            txtPrice.Text = " ";
            txtQtyPerUnit.Text = " ";
            txtTotalQty.Text = " ";
            txtDescription.Text = " ";
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=.;Initial Catalog=ShopJeans;Integrated Security=True");
            cmd = new SqlCommand("UPDATE RemainsStock SET Cost = @Cost, Markup = @Markup, Price = @Price, QuantityPerUnit = @QuantityPerUnit, Description = @Description where ItemCode = " + "'" + comboBoxItemCode.Text + "'", con);

            con.Open();
            cmd.Parameters.AddWithValue("@Cost", Convert.ToDouble(txtCost.Text));
            cmd.Parameters.AddWithValue("@Markup", Convert.ToDouble(txtMarkup.Text));
            cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(txtPrice.Text));          
            cmd.Parameters.AddWithValue("@QuantityPerUnit", Convert.ToInt32(txtQtyPerUnit.Text));
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Item is updated ! ");
            comboBoxItemCode.Text = "";
            txtCost.Text = "";
            txtPrice.Text = "";
            txtQtyPerUnit.Text = "";
            txtTotalQty.Text = "";
            txtDescription.Text = "";
            PhotoPictureBox.Image = null;
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            //open the Open File Dialog.If user clicks OK, load the picture that user chose.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PhotoPictureBox.Load(openFileDialog.FileName);
            }
        }

        private void checkBoxStretch_CheckedChanged(object sender, EventArgs e)
        {
            //if user selects Stretch Check box, change the picture box's SizeMode property to "Stretch"
            //if user clears the check box, change it to "Normal"
            if (checkBoxStretch.Checked)
            {
                PhotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                PhotoPictureBox.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void btnClearPhoto_Click(object sender, EventArgs e)
        {
            //clear the image
            PhotoPictureBox.Image = null;
        }

        private void txtMarkup_TextChanged(object sender, EventArgs e)
        {
            double calcPrice = Convert.ToDouble(txtCost.Text) * Convert.ToDouble(txtMarkup.Text);
            txtPrice.Text = calcPrice.ToString();
        }

        private void comboBoxItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
