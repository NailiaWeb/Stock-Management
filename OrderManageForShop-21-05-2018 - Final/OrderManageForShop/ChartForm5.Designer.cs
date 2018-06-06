namespace OrderManageForShop
{
    partial class ChartForm5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm5));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAddNewItem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnEditStock = new System.Windows.Forms.Button();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.btnViewStock = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopJeansDataSet5final = new OrderManageForShop.ShopJeansDataSet5final();
            this.ordersTableAdapter = new OrderManageForShop.ShopJeansDataSet5finalTableAdapters.OrdersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopJeansDataSet5final)).BeginInit();
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
            this.panel1.TabIndex = 9;
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
            this.lblAddNewItem.Location = new System.Drawing.Point(346, 9);
            this.lblAddNewItem.Name = "lblAddNewItem";
            this.lblAddNewItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAddNewItem.Size = new System.Drawing.Size(285, 51);
            this.lblAddNewItem.TabIndex = 0;
            this.lblAddNewItem.Text = "Sales chart";
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
            this.panel2.TabIndex = 8;
            // 
            // btnSales
            // 
            this.btnSales.Enabled = false;
            this.btnSales.Location = new System.Drawing.Point(12, 376);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(119, 55);
            this.btnSales.TabIndex = 54;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = true;
            // 
            // btnEditStock
            // 
            this.btnEditStock.Location = new System.Drawing.Point(12, 297);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(119, 55);
            this.btnEditStock.TabIndex = 5;
            this.btnEditStock.Text = "Edit Stock";
            this.btnEditStock.UseVisualStyleBackColor = true;
            this.btnEditStock.Click += new System.EventHandler(this.btnEditStock_Click);
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(12, 216);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(119, 55);
            this.btnAddNewItem.TabIndex = 4;
            this.btnAddNewItem.Text = "Add new Item";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // btnViewStock
            // 
            this.btnViewStock.Location = new System.Drawing.Point(12, 135);
            this.btnViewStock.Name = "btnViewStock";
            this.btnViewStock.Size = new System.Drawing.Size(119, 55);
            this.btnViewStock.TabIndex = 3;
            this.btnViewStock.Text = "View/Remove Stock";
            this.btnViewStock.UseVisualStyleBackColor = true;
            this.btnViewStock.Click += new System.EventHandler(this.btnViewStock_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(12, 54);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(119, 55);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chart);
            this.groupBox1.Location = new System.Drawing.Point(168, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 463);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // chart
            // 
            this.chart.BorderlineWidth = 3;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.DataSource = this.ordersBindingSource;
            legend1.Name = "Sale";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(25, 32);
            this.chart.Name = "chart";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "PixelPointWidth=20, IsXAxisQuantitative=False";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBorderWidth = 5;
            series1.Legend = "Sale";
            series1.MarkerSize = 7;
            series1.Name = "Sales";
            series1.XValueMember = "OrderDate";
            series1.YValueMembers = "OrderTotal";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(670, 381);
            this.chart.TabIndex = 6;
            this.chart.Text = "chart1";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.shopJeansDataSet5final;
            // 
            // shopJeansDataSet5final
            // 
            this.shopJeansDataSet5final.DataSetName = "ShopJeansDataSet5final";
            this.shopJeansDataSet5final.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ChartForm5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 573);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ChartForm5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RemoveForm5";
            this.Load += new System.EventHandler(this.RemoveForm5_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopJeansDataSet5final)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAddNewItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.Button btnViewStock;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private ShopJeansDataSet5final shopJeansDataSet5final;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private ShopJeansDataSet5finalTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Button btnSales;
    }
}