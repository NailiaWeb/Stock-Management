using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace OrderManageForShop
{
    public partial class AddForm3 : Form
    {
        SqlCommand cmd;
        SqlConnection con;

        public AddForm3()
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
        private void btnEditStock_Click_1(object sender, EventArgs e)
        {
            new EditForm4().Show();
            this.Hide();
        }
        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            new AddForm3().Show();
            this.Hide();
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            new ChartForm5().Show();
            this.Hide();
        }

        private void btnAddToStock_Click(object sender, EventArgs e)
        {          
            con = new SqlConnection(@"Data Source=.;Initial Catalog=ShopJeans;Integrated Security=True");
            con.Open();
            cmd = new SqlCommand("INSERT INTO Purchase (ItemCode, Cost, Price, Markup, QuantityPerUnit, TotalQuantity, Description, Photo) VALUES (@ItemCode, @Cost, @Price, @Markup, @QuantityPerUnit, @TotalQuantity, @Description, @Photo)", con);
            cmd.Parameters.AddWithValue("@ItemCode", txtItemName.Text);
            cmd.Parameters.AddWithValue("@Cost", Convert.ToDouble(txtCost.Text));
            cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(txtPrice.Text));
            cmd.Parameters.AddWithValue("@Markup", Convert.ToDouble(txtMarkup.Text));
            cmd.Parameters.AddWithValue("@QuantityPerUnit", Convert.ToInt32(txtQtyPerUnit.Text));
            cmd.Parameters.AddWithValue("@TotalQuantity", Convert.ToInt32(txtTotalQty.Text));
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
            MemoryStream stream = new MemoryStream();
            PhotoPictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = stream.ToArray();
            cmd.Parameters.AddWithValue("@Photo", pic);

            cmd.ExecuteNonQuery();
            MessageBox.Show(" Item is added ! ");
            txtItemName.Text = "";
            txtCost.Text = "";
            txtPrice.Text = "";
            //txtMarkup.Text = ""; 
            txtQtyPerUnit.Text = "";
            txtTotalQty.Text = "";
            txtDescription.Text = "";
        }

        private void txtMarkup_TextChanged(object sender, EventArgs e)
        {
            double calcPrice = Convert.ToDouble(txtCost.Text) * Convert.ToDouble(txtMarkup.Text);
            txtPrice.Text = calcPrice.ToString();
        }      

        private void btnChoosePhoto_Click_1(object sender, EventArgs e)
        {
            //open the Open File Dialog.If user clicks OK, load the picture that user chose.
            if (PhotoOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                PhotoPictureBox.Load(PhotoOpenFileDialog.FileName);
            }
        }

        private void btnClearPhoto_Click_1(object sender, EventArgs e)
        {
            //clear the image
            PhotoPictureBox.Image = null;
        }

        private void checkBoxStretch_CheckedChanged_1(object sender, EventArgs e)
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
    }
}
