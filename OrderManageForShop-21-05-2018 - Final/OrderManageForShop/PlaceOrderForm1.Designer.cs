namespace OrderManageForShop
{
    partial class PlaceOrderForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaceOrderForm1));
            this.ItemCodeComboBox = new System.Windows.Forms.ComboBox();
            this.remainsStockBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.shopJeansDataSet5final = new OrderManageForShop.ShopJeansDataSet5final();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPlaceOrder = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditStock = new System.Windows.Forms.Button();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnViewStock = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblTotal1 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblGrandTotalCalc = new System.Windows.Forms.Label();
            this.dataGridViewAddToCart = new System.Windows.Forms.DataGridView();
            this.ItemCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnProceedOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelItemID = new System.Windows.Forms.Label();
            this.lblReaderOrder = new System.Windows.Forms.Label();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.remainsStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remainsStockTableAdapter = new OrderManageForShop.ShopJeansDataSet5finalTableAdapters.RemainsStockTableAdapter();
            this.remainsStockBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.remainsStockBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.remainsStockBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.remainsStockBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.remainsStockBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopJeansDataSet5final)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddToCart)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remainsStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsStockBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsStockBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsStockBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsStockBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemCodeComboBox
            // 
            this.ItemCodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remainsStockBindingSource5, "ItemCode", true));
            this.ItemCodeComboBox.DataSource = this.remainsStockBindingSource5;
            this.ItemCodeComboBox.DisplayMember = "ItemCode";
            this.ItemCodeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCodeComboBox.FormattingEnabled = true;
            this.ItemCodeComboBox.Location = new System.Drawing.Point(19, 39);
            this.ItemCodeComboBox.MaxDropDownItems = 20;
            this.ItemCodeComboBox.Name = "ItemCodeComboBox";
            this.ItemCodeComboBox.Size = new System.Drawing.Size(84, 26);
            this.ItemCodeComboBox.TabIndex = 0;
            this.ItemCodeComboBox.ValueMember = "ItemCode";
            // 
            // remainsStockBindingSource5
            // 
            this.remainsStockBindingSource5.DataMember = "RemainsStock";
            this.remainsStockBindingSource5.DataSource = this.shopJeansDataSet5final;
            // 
            // shopJeansDataSet5final
            // 
            this.shopJeansDataSet5final.DataSetName = "ShopJeansDataSet5final";
            this.shopJeansDataSet5final.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.lblOrderDate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblPlaceOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 76);
            this.panel1.TabIndex = 1;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.Location = new System.Drawing.Point(762, 46);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(51, 16);
            this.lblOrderDate.TabIndex = 22;
            this.lblOrderDate.Text = "label1";
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
            // lblPlaceOrder
            // 
            this.lblPlaceOrder.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaceOrder.Location = new System.Drawing.Point(315, 11);
            this.lblPlaceOrder.Name = "lblPlaceOrder";
            this.lblPlaceOrder.Size = new System.Drawing.Size(388, 51);
            this.lblPlaceOrder.TabIndex = 0;
            this.lblPlaceOrder.Text = "Place Order";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.btnSales);
            this.panel2.Controls.Add(this.btnEditStock);
            this.panel2.Controls.Add(this.btnAddNewItem);
            this.panel2.Controls.Add(this.btnViewStock);
            this.panel2.Controls.Add(this.btnPlaceOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 497);
            this.panel2.TabIndex = 0;
            // 
            // btnEditStock
            // 
            this.btnEditStock.Location = new System.Drawing.Point(12, 292);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(119, 55);
            this.btnEditStock.TabIndex = 9;
            this.btnEditStock.Text = "Edit Stock";
            this.btnEditStock.UseVisualStyleBackColor = true;
            this.btnEditStock.Click += new System.EventHandler(this.btnEditStock_Click_1);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(12, 220);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(119, 55);
            this.btnAddNewItem.TabIndex = 8;
            this.btnAddNewItem.Text = "Add new Item";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click_1);
            // 
            // btnViewStock
            // 
            this.btnViewStock.Location = new System.Drawing.Point(12, 148);
            this.btnViewStock.Name = "btnViewStock";
            this.btnViewStock.Size = new System.Drawing.Size(119, 55);
            this.btnViewStock.TabIndex = 7;
            this.btnViewStock.Text = "View/Remove Stock";
            this.btnViewStock.UseVisualStyleBackColor = true;
            this.btnViewStock.Click += new System.EventHandler(this.btnViewStock_Click_1);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Enabled = false;
            this.btnPlaceOrder.Location = new System.Drawing.Point(12, 77);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(119, 55);
            this.btnPlaceOrder.TabIndex = 6;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // txtPrice
            // 
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remainsStockBindingSource5, "Price", true));
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(125, 40);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(84, 24);
            this.txtPrice.TabIndex = 2;
            // 
            // numericUpDownQty
            // 
            this.numericUpDownQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownQty.Location = new System.Drawing.Point(330, 39);
            this.numericUpDownQty.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownQty.Name = "numericUpDownQty";
            this.numericUpDownQty.Size = new System.Drawing.Size(84, 24);
            this.numericUpDownQty.TabIndex = 4;
            this.numericUpDownQty.ValueChanged += new System.EventHandler(this.numericUpDownQty_ValueChanged);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(436, 40);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(84, 24);
            this.txtTotal.TabIndex = 5;
            // 
            // txtStock
            // 
            this.txtStock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remainsStockBindingSource5, "Stock", true));
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(229, 40);
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(84, 24);
            this.txtStock.TabIndex = 6;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(765, 111);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(99, 69);
            this.btnAddToCart.TabIndex = 7;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCode.Location = new System.Drawing.Point(16, 16);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(77, 18);
            this.lblItemCode.TabIndex = 8;
            this.lblItemCode.Text = "Item code:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(122, 16);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 18);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(327, 16);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(35, 18);
            this.lblQty.TabIndex = 10;
            this.lblQty.Text = "Qty:";
            // 
            // lblTotal1
            // 
            this.lblTotal1.AutoSize = true;
            this.lblTotal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal1.Location = new System.Drawing.Point(433, 16);
            this.lblTotal1.Name = "lblTotal1";
            this.lblTotal1.Size = new System.Drawing.Size(45, 18);
            this.lblTotal1.TabIndex = 11;
            this.lblTotal1.Text = "Total:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(226, 16);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(51, 18);
            this.lblStock.TabIndex = 12;
            this.lblStock.Text = "Stock:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblItemCode);
            this.groupBox1.Controls.Add(this.lblStock);
            this.groupBox1.Controls.Add(this.ItemCodeComboBox);
            this.groupBox1.Controls.Add(this.lblTotal1);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lblQty);
            this.groupBox1.Controls.Add(this.numericUpDownQty);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Location = new System.Drawing.Point(176, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 87);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(772, 224);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(90, 18);
            this.lblGrandTotal.TabIndex = 14;
            this.lblGrandTotal.Text = "Grand Total:";
            // 
            // lblGrandTotalCalc
            // 
            this.lblGrandTotalCalc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblGrandTotalCalc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGrandTotalCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotalCalc.Location = new System.Drawing.Point(765, 251);
            this.lblGrandTotalCalc.Name = "lblGrandTotalCalc";
            this.lblGrandTotalCalc.Size = new System.Drawing.Size(99, 69);
            this.lblGrandTotalCalc.TabIndex = 15;
            this.lblGrandTotalCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewAddToCart
            // 
            this.dataGridViewAddToCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddToCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCode,
            this.Price,
            this.Stock,
            this.Qty,
            this.Total});
            this.dataGridViewAddToCart.Location = new System.Drawing.Point(176, 211);
            this.dataGridViewAddToCart.Name = "dataGridViewAddToCart";
            this.dataGridViewAddToCart.Size = new System.Drawing.Size(546, 247);
            this.dataGridViewAddToCart.TabIndex = 16;
            // 
            // ItemCode
            // 
            this.ItemCode.HeaderText = "Item Code";
            this.ItemCode.Name = "ItemCode";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 105;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(195, 486);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(149, 32);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrintPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintPreview.Location = new System.Drawing.Point(368, 486);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(149, 32);
            this.btnPrintPreview.TabIndex = 18;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = false;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnProceedOrder
            // 
            this.btnProceedOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnProceedOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedOrder.Location = new System.Drawing.Point(741, 479);
            this.btnProceedOrder.Name = "btnProceedOrder";
            this.btnProceedOrder.Size = new System.Drawing.Size(149, 48);
            this.btnProceedOrder.TabIndex = 19;
            this.btnProceedOrder.Text = "Proceed Order";
            this.btnProceedOrder.UseVisualStyleBackColor = false;
            this.btnProceedOrder.Click += new System.EventHandler(this.btnProceedOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(541, 486);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 32);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelItemID);
            this.groupBox2.Controls.Add(this.lblReaderOrder);
            this.groupBox2.Location = new System.Drawing.Point(158, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 473);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // labelItemID
            // 
            this.labelItemID.Location = new System.Drawing.Point(580, 307);
            this.labelItemID.Name = "labelItemID";
            this.labelItemID.Size = new System.Drawing.Size(61, 24);
            this.labelItemID.TabIndex = 23;
            this.labelItemID.Visible = false;
            // 
            // lblReaderOrder
            // 
            this.lblReaderOrder.Location = new System.Drawing.Point(570, 354);
            this.lblReaderOrder.Name = "lblReaderOrder";
            this.lblReaderOrder.Size = new System.Drawing.Size(85, 16);
            this.lblReaderOrder.TabIndex = 22;
            this.lblReaderOrder.Visible = false;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // remainsStockBindingSource
            // 
            this.remainsStockBindingSource.DataMember = "RemainsStock";
            this.remainsStockBindingSource.DataSource = this.shopJeansDataSet5final;
            // 
            // remainsStockTableAdapter
            // 
            this.remainsStockTableAdapter.ClearBeforeFill = true;
            // 
            // remainsStockBindingSource1
            // 
            this.remainsStockBindingSource1.DataMember = "RemainsStock";
            this.remainsStockBindingSource1.DataSource = this.shopJeansDataSet5final;
            // 
            // remainsStockBindingSource2
            // 
            this.remainsStockBindingSource2.DataMember = "RemainsStock";
            this.remainsStockBindingSource2.DataSource = this.shopJeansDataSet5final;
            // 
            // remainsStockBindingSource3
            // 
            this.remainsStockBindingSource3.DataMember = "RemainsStock";
            this.remainsStockBindingSource3.DataSource = this.shopJeansDataSet5final;
            // 
            // remainsStockBindingSource4
            // 
            this.remainsStockBindingSource4.DataMember = "RemainsStock";
            this.remainsStockBindingSource4.DataSource = this.shopJeansDataSet5final;
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(12, 362);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(119, 55);
            this.btnSales.TabIndex = 10;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // PlaceOrderForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 573);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnProceedOrder);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.dataGridViewAddToCart);
            this.Controls.Add(this.lblGrandTotalCalc);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "PlaceOrderForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PlaceOrderForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.remainsStockBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopJeansDataSet5final)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddToCart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.remainsStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsStockBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsStockBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsStockBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remainsStockBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ItemCodeComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlaceOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownQty;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblTotal1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblGrandTotalCalc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewAddToCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPrintPreview;
        private System.Windows.Forms.Button btnProceedOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnViewStock;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Label lblReaderOrder;
        private System.Windows.Forms.Label labelItemID;
        private ShopJeansDataSet5final shopJeansDataSet5final;
        private System.Windows.Forms.BindingSource remainsStockBindingSource;
        private ShopJeansDataSet5finalTableAdapters.RemainsStockTableAdapter remainsStockTableAdapter;
        private System.Windows.Forms.BindingSource remainsStockBindingSource1;
        private System.Windows.Forms.BindingSource remainsStockBindingSource2;
        private System.Windows.Forms.BindingSource remainsStockBindingSource3;
        private System.Windows.Forms.BindingSource remainsStockBindingSource4;
        private System.Windows.Forms.BindingSource remainsStockBindingSource5;
        private System.Windows.Forms.Button btnSales;
    }
}

