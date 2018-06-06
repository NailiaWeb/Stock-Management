namespace OrderManageForShop
{
    partial class AddForm3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddNewItem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnEditStock = new System.Windows.Forms.Button();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnViewStock = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxStretch = new System.Windows.Forms.CheckBox();
            this.btnClearPhoto = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnChoosePhoto = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.btnAddToStock = new System.Windows.Forms.Button();
            this.lblPhoto = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtQtyPerUnit = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalQty = new System.Windows.Forms.TextBox();
            this.lblTotalQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblMarkup = new System.Windows.Forms.Label();
            this.txtMarkup = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblQtyPerUnit = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopJeansDataSet4 = new OrderManageForShop.ShopJeansDataSet4();
            this.PhotoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.stockTableAdapter = new OrderManageForShop.ShopJeansDataSet4TableAdapters.StockTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopJeansDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblAddNewItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 76);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblAddNewItem
            // 
            this.lblAddNewItem.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewItem.Location = new System.Drawing.Point(368, 9);
            this.lblAddNewItem.Name = "lblAddNewItem";
            this.lblAddNewItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddNewItem.Size = new System.Drawing.Size(333, 51);
            this.lblAddNewItem.TabIndex = 0;
            this.lblAddNewItem.Text = "Add New Item";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.btnSales);
            this.panel2.Controls.Add(this.btnEditStock);
            this.panel2.Controls.Add(this.btnAddNewItem);
            this.panel2.Controls.Add(this.btnViewStock);
            this.panel2.Controls.Add(this.btnPlaceOrder);
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 497);
            this.panel2.TabIndex = 4;
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(12, 383);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(119, 55);
            this.btnSales.TabIndex = 52;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnEditStock
            // 
            this.btnEditStock.Location = new System.Drawing.Point(12, 306);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(119, 55);
            this.btnEditStock.TabIndex = 9;
            this.btnEditStock.Text = "Edit Stock";
            this.btnEditStock.UseVisualStyleBackColor = true;
            this.btnEditStock.Click += new System.EventHandler(this.btnEditStock_Click_1);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Enabled = false;
            this.btnAddNewItem.Location = new System.Drawing.Point(12, 230);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(119, 55);
            this.btnAddNewItem.TabIndex = 8;
            this.btnAddNewItem.Text = "Add new Item";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // btnViewStock
            // 
            this.btnViewStock.Location = new System.Drawing.Point(12, 152);
            this.btnViewStock.Name = "btnViewStock";
            this.btnViewStock.Size = new System.Drawing.Size(119, 55);
            this.btnViewStock.TabIndex = 7;
            this.btnViewStock.Text = "View/Remove Stock";
            this.btnViewStock.UseVisualStyleBackColor = true;
            this.btnViewStock.Click += new System.EventHandler(this.btnViewStock_Click_1);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(12, 75);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(119, 55);
            this.btnPlaceOrder.TabIndex = 6;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxStretch);
            this.groupBox2.Controls.Add(this.btnClearPhoto);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.btnChoosePhoto);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.PhotoPictureBox);
            this.groupBox2.Controls.Add(this.btnAddToStock);
            this.groupBox2.Controls.Add(this.lblPhoto);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.lblDescription);
            this.groupBox2.Controls.Add(this.txtQtyPerUnit);
            this.groupBox2.Controls.Add(this.txtCost);
            this.groupBox2.Controls.Add(this.txtItemName);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(167, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 473);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // checkBoxStretch
            // 
            this.checkBoxStretch.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxStretch.BackColor = System.Drawing.Color.CornflowerBlue;
            this.checkBoxStretch.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxStretch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStretch.Location = new System.Drawing.Point(304, 278);
            this.checkBoxStretch.Name = "checkBoxStretch";
            this.checkBoxStretch.Size = new System.Drawing.Size(78, 34);
            this.checkBoxStretch.TabIndex = 50;
            this.checkBoxStretch.Text = "stretch";
            this.checkBoxStretch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxStretch.UseVisualStyleBackColor = false;
            this.checkBoxStretch.CheckedChanged += new System.EventHandler(this.checkBoxStretch_CheckedChanged_1);
            // 
            // btnClearPhoto
            // 
            this.btnClearPhoto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnClearPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPhoto.Location = new System.Drawing.Point(304, 405);
            this.btnClearPhoto.Name = "btnClearPhoto";
            this.btnClearPhoto.Size = new System.Drawing.Size(78, 41);
            this.btnClearPhoto.TabIndex = 47;
            this.btnClearPhoto.Text = "Clear photo";
            this.btnClearPhoto.UseVisualStyleBackColor = false;
            this.btnClearPhoto.Click += new System.EventHandler(this.btnClearPhoto_Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(295, 395);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(92, 56);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            // 
            // btnChoosePhoto
            // 
            this.btnChoosePhoto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnChoosePhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePhoto.Location = new System.Drawing.Point(304, 338);
            this.btnChoosePhoto.Name = "btnChoosePhoto";
            this.btnChoosePhoto.Size = new System.Drawing.Size(81, 41);
            this.btnChoosePhoto.TabIndex = 45;
            this.btnChoosePhoto.Text = "Choose photo";
            this.btnChoosePhoto.UseVisualStyleBackColor = false;
            this.btnChoosePhoto.Click += new System.EventHandler(this.btnChoosePhoto_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(295, 328);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(95, 56);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(295, 264);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(92, 56);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PhotoPictureBox.Location = new System.Drawing.Point(64, 254);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(180, 196);
            this.PhotoPictureBox.TabIndex = 27;
            this.PhotoPictureBox.TabStop = false;
            // 
            // btnAddToStock
            // 
            this.btnAddToStock.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddToStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToStock.Location = new System.Drawing.Point(523, 340);
            this.btnAddToStock.Name = "btnAddToStock";
            this.btnAddToStock.Size = new System.Drawing.Size(138, 69);
            this.btnAddToStock.TabIndex = 24;
            this.btnAddToStock.Text = "Add to Stock";
            this.btnAddToStock.UseVisualStyleBackColor = false;
            this.btnAddToStock.Click += new System.EventHandler(this.btnAddToStock_Click);
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoto.Location = new System.Drawing.Point(61, 218);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(52, 18);
            this.lblPhoto.TabIndex = 21;
            this.lblPhoto.Text = "Photo:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(185, 174);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(476, 31);
            this.txtDescription.TabIndex = 17;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(69, 177);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(87, 18);
            this.lblDescription.TabIndex = 19;
            this.lblDescription.Text = "Description:";
            // 
            // txtQtyPerUnit
            // 
            this.txtQtyPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyPerUnit.Location = new System.Drawing.Point(450, 76);
            this.txtQtyPerUnit.Name = "txtQtyPerUnit";
            this.txtQtyPerUnit.Size = new System.Drawing.Size(100, 24);
            this.txtQtyPerUnit.TabIndex = 15;
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(185, 78);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 24);
            this.txtCost.TabIndex = 12;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(185, 34);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 24);
            this.txtItemName.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(518, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 84);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalQty);
            this.groupBox3.Controls.Add(this.lblTotalQty);
            this.groupBox3.Controls.Add(this.lblPrice);
            this.groupBox3.Controls.Add(this.txtPrice);
            this.groupBox3.Controls.Add(this.lblMarkup);
            this.groupBox3.Controls.Add(this.txtMarkup);
            this.groupBox3.Controls.Add(this.lblCost);
            this.groupBox3.Controls.Add(this.lblQtyPerUnit);
            this.groupBox3.Controls.Add(this.lblItemName);
            this.groupBox3.Location = new System.Drawing.Point(64, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(597, 141);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            // 
            // txtTotalQty
            // 
            this.txtTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQty.Location = new System.Drawing.Point(386, 103);
            this.txtTotalQty.Name = "txtTotalQty";
            this.txtTotalQty.Size = new System.Drawing.Size(100, 24);
            this.txtTotalQty.TabIndex = 16;
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQty.Location = new System.Drawing.Point(274, 103);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(72, 18);
            this.lblTotalQty.TabIndex = 27;
            this.lblTotalQty.Text = "Total Qty:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(274, 17);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 18);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(386, 14);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 24);
            this.txtPrice.TabIndex = 14;
            // 
            // lblMarkup
            // 
            this.lblMarkup.AutoSize = true;
            this.lblMarkup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkup.Location = new System.Drawing.Point(8, 103);
            this.lblMarkup.Name = "lblMarkup";
            this.lblMarkup.Size = new System.Drawing.Size(62, 18);
            this.lblMarkup.TabIndex = 15;
            this.lblMarkup.Text = "Markup:";
            // 
            // txtMarkup
            // 
            this.txtMarkup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarkup.Location = new System.Drawing.Point(121, 103);
            this.txtMarkup.Name = "txtMarkup";
            this.txtMarkup.Size = new System.Drawing.Size(100, 24);
            this.txtMarkup.TabIndex = 13;
            this.txtMarkup.TextChanged += new System.EventHandler(this.txtMarkup_TextChanged);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(8, 59);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(44, 18);
            this.lblCost.TabIndex = 10;
            this.lblCost.Text = "Cost:";
            // 
            // lblQtyPerUnit
            // 
            this.lblQtyPerUnit.AutoSize = true;
            this.lblQtyPerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyPerUnit.Location = new System.Drawing.Point(274, 61);
            this.lblQtyPerUnit.Name = "lblQtyPerUnit";
            this.lblQtyPerUnit.Size = new System.Drawing.Size(87, 18);
            this.lblQtyPerUnit.TabIndex = 17;
            this.lblQtyPerUnit.Text = "Qty per unit:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(8, 17);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(84, 18);
            this.lblItemName.TabIndex = 9;
            this.lblItemName.Text = "Item Name:";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.shopJeansDataSet4;
            // 
            // shopJeansDataSet4
            // 
            this.shopJeansDataSet4.DataSetName = "ShopJeansDataSet4";
            this.shopJeansDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PhotoOpenFileDialog
            // 
            this.PhotoOpenFileDialog.FileName = "PhotoOpenFileDialog";
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // AddForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 573);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "AddForm3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewItemForm3";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopJeansDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddNewItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblPhoto;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtQtyPerUnit;
        private System.Windows.Forms.Label lblQtyPerUnit;
        private System.Windows.Forms.TextBox txtMarkup;
        private System.Windows.Forms.Label lblMarkup;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnAddToStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotalQty;
        private System.Windows.Forms.Label lblTotalQty;
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnViewStock;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.OpenFileDialog PhotoOpenFileDialog;
        private ShopJeansDataSet4 shopJeansDataSet4;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private ShopJeansDataSet4TableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.CheckBox checkBoxStretch;
        private System.Windows.Forms.Button btnClearPhoto;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnChoosePhoto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSales;
    }
}