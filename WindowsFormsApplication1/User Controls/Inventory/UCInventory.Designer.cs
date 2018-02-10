﻿namespace WindowsFormsApplication1
{
    partial class UCInventory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCInventory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lvProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabInventory = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtSearch = new MyTextBox();
            this.drpSearch = new System.Windows.Forms.ComboBox();
            this.txtPriceAdded = new System.Windows.Forms.NumericUpDown();
            this.txtPriceBuy = new System.Windows.Forms.NumericUpDown();
            this.drpCat = new System.Windows.Forms.ComboBox();
            this.txtPriceSell = new MyTextBox();
            this.txtProdDesc = new MyTextBox();
            this.txtProdName = new MyTextBox();
            this.txtProdNo = new MyTextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnRemoveZero = new System.Windows.Forms.Button();
            this.numDeduct = new System.Windows.Forms.NumericUpDown();
            this.drpProd = new System.Windows.Forms.ComboBox();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.btnRemoveStocks = new System.Windows.Forms.Button();
            this.btnSClear = new System.Windows.Forms.Button();
            this.btnSSave = new System.Windows.Forms.Button();
            this.btnSDeduct = new System.Windows.Forms.Button();
            this.btnSEdit = new System.Windows.Forms.Button();
            this.txtSProdName = new MyTextBox();
            this.txtStockNo = new MyTextBox();
            this.numQuan = new System.Windows.Forms.NumericUpDown();
            this.txtReceived = new MyTextBox();
            this.btnSAdd = new System.Windows.Forms.Button();
            this.lvStocks = new System.Windows.Forms.ListView();
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceAdded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceBuy)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 60);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(431, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(330, 39);
            this.label5.TabIndex = 31;
            this.label5.Text = "Inventory Management";
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvProducts.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.GridLines = true;
            this.lvProducts.Location = new System.Drawing.Point(281, 63);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(860, 442);
            this.lvProducts.TabIndex = 12;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            this.lvProducts.SelectedIndexChanged += new System.EventHandler(this.lvProducts_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product ID.";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Product Name";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 111;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Category";
            this.columnHeader2.Width = 114;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Product Price";
            this.columnHeader5.Width = 129;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Added Price";
            this.columnHeader6.Width = 126;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Selling Price";
            this.columnHeader7.Width = 120;
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.tabPage1);
            this.tabInventory.Controls.Add(this.tabPage2);
            this.tabInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInventory.Location = new System.Drawing.Point(15, 114);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.SelectedIndex = 0;
            this.tabInventory.Size = new System.Drawing.Size(1155, 555);
            this.tabInventory.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Firebrick;
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnAddCategory);
            this.tabPage1.Controls.Add(this.txtSearch);
            this.tabPage1.Controls.Add(this.drpSearch);
            this.tabPage1.Controls.Add(this.txtPriceAdded);
            this.tabPage1.Controls.Add(this.txtPriceBuy);
            this.tabPage1.Controls.Add(this.drpCat);
            this.tabPage1.Controls.Add(this.txtPriceSell);
            this.tabPage1.Controls.Add(this.txtProdDesc);
            this.tabPage1.Controls.Add(this.txtProdName);
            this.tabPage1.Controls.Add(this.txtProdNo);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.lvProducts);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1147, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Products";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(542, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 21);
            this.label12.TabIndex = 127;
            this.label12.Text = "Search By:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(289, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 21);
            this.label11.TabIndex = 126;
            this.label11.Text = "Search:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(7, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 21);
            this.label10.TabIndex = 125;
            this.label10.Text = "Selling Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 21);
            this.label9.TabIndex = 124;
            this.label9.Text = "Added Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 123;
            this.label8.Text = "Buying Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(2, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 122;
            this.label7.Text = "Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 121;
            this.label6.Text = "Description:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 120;
            this.label4.Text = "(Barcode)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-4, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 119;
            this.label3.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 118;
            this.label2.Text = "Product ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 30);
            this.label1.TabIndex = 117;
            this.label1.Text = "PRODUCT DETAILS";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.BackgroundImage")));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(250, 189);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(25, 36);
            this.btnAddCategory.TabIndex = 116;
            this.btnAddCategory.Text = "+";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Firebrick;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(358, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 25);
            this.txtSearch.TabIndex = 115;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // drpSearch
            // 
            this.drpSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpSearch.FormattingEnabled = true;
            this.drpSearch.Items.AddRange(new object[] {
            "All",
            "Product ID",
            "Product Name",
            "Category"});
            this.drpSearch.Location = new System.Drawing.Point(633, 25);
            this.drpSearch.Name = "drpSearch";
            this.drpSearch.Size = new System.Drawing.Size(174, 29);
            this.drpSearch.TabIndex = 113;
            this.drpSearch.SelectedIndexChanged += new System.EventHandler(this.drpSearch_SelectedIndexChanged);
            // 
            // txtPriceAdded
            // 
            this.txtPriceAdded.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceAdded.Location = new System.Drawing.Point(116, 275);
            this.txtPriceAdded.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtPriceAdded.Name = "txtPriceAdded";
            this.txtPriceAdded.Size = new System.Drawing.Size(159, 29);
            this.txtPriceAdded.TabIndex = 112;
            this.txtPriceAdded.ValueChanged += new System.EventHandler(this.txtPriceAdded_ValueChanged);
            // 
            // txtPriceBuy
            // 
            this.txtPriceBuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceBuy.Location = new System.Drawing.Point(116, 237);
            this.txtPriceBuy.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtPriceBuy.Name = "txtPriceBuy";
            this.txtPriceBuy.Size = new System.Drawing.Size(159, 29);
            this.txtPriceBuy.TabIndex = 111;
            this.txtPriceBuy.ValueChanged += new System.EventHandler(this.txtPriceBuy_ValueChanged);
            // 
            // drpCat
            // 
            this.drpCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpCat.FormattingEnabled = true;
            this.drpCat.Location = new System.Drawing.Point(116, 192);
            this.drpCat.Name = "drpCat";
            this.drpCat.Size = new System.Drawing.Size(128, 29);
            this.drpCat.TabIndex = 110;
            // 
            // txtPriceSell
            // 
            this.txtPriceSell.BackColor = System.Drawing.Color.Firebrick;
            this.txtPriceSell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriceSell.Enabled = false;
            this.txtPriceSell.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceSell.ForeColor = System.Drawing.Color.White;
            this.txtPriceSell.Location = new System.Drawing.Point(116, 317);
            this.txtPriceSell.Name = "txtPriceSell";
            this.txtPriceSell.Size = new System.Drawing.Size(159, 25);
            this.txtPriceSell.TabIndex = 108;
            // 
            // txtProdDesc
            // 
            this.txtProdDesc.BackColor = System.Drawing.Color.Firebrick;
            this.txtProdDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdDesc.ForeColor = System.Drawing.Color.White;
            this.txtProdDesc.Location = new System.Drawing.Point(116, 159);
            this.txtProdDesc.Name = "txtProdDesc";
            this.txtProdDesc.Size = new System.Drawing.Size(159, 25);
            this.txtProdDesc.TabIndex = 106;
            // 
            // txtProdName
            // 
            this.txtProdName.BackColor = System.Drawing.Color.Firebrick;
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.ForeColor = System.Drawing.Color.White;
            this.txtProdName.Location = new System.Drawing.Point(116, 119);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(159, 25);
            this.txtProdName.TabIndex = 105;
            // 
            // txtProdNo
            // 
            this.txtProdNo.BackColor = System.Drawing.Color.Firebrick;
            this.txtProdNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProdNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdNo.ForeColor = System.Drawing.Color.White;
            this.txtProdNo.Location = new System.Drawing.Point(116, 63);
            this.txtProdNo.MaxLength = 100000000;
            this.txtProdNo.Name = "txtProdNo";
            this.txtProdNo.Size = new System.Drawing.Size(159, 25);
            this.txtProdNo.TabIndex = 104;
            this.txtProdNo.TextChanged += new System.EventHandler(this.txtUN_TextChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(65, 457);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 48);
            this.btnClear.TabIndex = 100;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(130, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 48);
            this.btnSave.TabIndex = 99;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(10, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 48);
            this.btnDelete.TabIndex = 98;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.BackgroundImage")));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(130, 349);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(114, 48);
            this.btnEdit.TabIndex = 97;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(10, 349);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 48);
            this.btnAdd.TabIndex = 96;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Firebrick;
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.btnRemoveZero);
            this.tabPage2.Controls.Add(this.numDeduct);
            this.tabPage2.Controls.Add(this.drpProd);
            this.tabPage2.Controls.Add(this.cboSort);
            this.tabPage2.Controls.Add(this.btnRemoveStocks);
            this.tabPage2.Controls.Add(this.btnSClear);
            this.tabPage2.Controls.Add(this.btnSSave);
            this.tabPage2.Controls.Add(this.btnSDeduct);
            this.tabPage2.Controls.Add(this.btnSEdit);
            this.tabPage2.Controls.Add(this.txtSProdName);
            this.tabPage2.Controls.Add(this.txtStockNo);
            this.tabPage2.Controls.Add(this.numQuan);
            this.tabPage2.Controls.Add(this.txtReceived);
            this.tabPage2.Controls.Add(this.btnSAdd);
            this.tabPage2.Controls.Add(this.lvStocks);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1125, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stocks";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(3, 323);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 21);
            this.label19.TabIndex = 134;
            this.label19.Text = "Deduct:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(1, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 21);
            this.label18.TabIndex = 133;
            this.label18.Text = "Quantity:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(-4, 162);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 21);
            this.label17.TabIndex = 132;
            this.label17.Text = "Receiving Date:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(6, 134);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 21);
            this.label16.TabIndex = 131;
            this.label16.Text = "Stock No:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(2, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 21);
            this.label15.TabIndex = 130;
            this.label15.Text = "Product Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 66);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 21);
            this.label14.TabIndex = 129;
            this.label14.Text = "Product ID:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 21);
            this.label13.TabIndex = 128;
            this.label13.Text = "Sort By:";
            // 
            // btnRemoveZero
            // 
            this.btnRemoveZero.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveZero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveZero.BackgroundImage")));
            this.btnRemoveZero.Enabled = false;
            this.btnRemoveZero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveZero.ForeColor = System.Drawing.Color.White;
            this.btnRemoveZero.Location = new System.Drawing.Point(6, 419);
            this.btnRemoveZero.Name = "btnRemoveZero";
            this.btnRemoveZero.Size = new System.Drawing.Size(137, 50);
            this.btnRemoveZero.TabIndex = 127;
            this.btnRemoveZero.Text = "Remove Zero Stocks";
            this.btnRemoveZero.UseVisualStyleBackColor = false;
            this.btnRemoveZero.Click += new System.EventHandler(this.btnRemoveZero_Click);
            // 
            // numDeduct
            // 
            this.numDeduct.Enabled = false;
            this.numDeduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDeduct.Location = new System.Drawing.Point(72, 315);
            this.numDeduct.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDeduct.Name = "numDeduct";
            this.numDeduct.Size = new System.Drawing.Size(70, 29);
            this.numDeduct.TabIndex = 126;
            // 
            // drpProd
            // 
            this.drpProd.Enabled = false;
            this.drpProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpProd.FormattingEnabled = true;
            this.drpProd.Location = new System.Drawing.Point(111, 63);
            this.drpProd.Name = "drpProd";
            this.drpProd.Size = new System.Drawing.Size(178, 29);
            this.drpProd.TabIndex = 124;
            this.drpProd.SelectedIndexChanged += new System.EventHandler(this.drpProd_SelectedIndexChanged);
            // 
            // cboSort
            // 
            this.cboSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSort.FormattingEnabled = true;
            this.cboSort.Items.AddRange(new object[] {
            "Product ID",
            "Product Name",
            "Stock ID",
            "Available Stock",
            "Date - Desc",
            "Date - Asc"});
            this.cboSort.Location = new System.Drawing.Point(111, 21);
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(178, 29);
            this.cboSort.TabIndex = 123;
            this.cboSort.SelectedIndexChanged += new System.EventHandler(this.cboSort_SelectedIndexChanged);
            // 
            // btnRemoveStocks
            // 
            this.btnRemoveStocks.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveStocks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveStocks.BackgroundImage")));
            this.btnRemoveStocks.Enabled = false;
            this.btnRemoveStocks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStocks.ForeColor = System.Drawing.Color.White;
            this.btnRemoveStocks.Location = new System.Drawing.Point(6, 364);
            this.btnRemoveStocks.Name = "btnRemoveStocks";
            this.btnRemoveStocks.Size = new System.Drawing.Size(137, 50);
            this.btnRemoveStocks.TabIndex = 122;
            this.btnRemoveStocks.Text = "Remove Stock";
            this.btnRemoveStocks.UseVisualStyleBackColor = false;
            this.btnRemoveStocks.Click += new System.EventHandler(this.btnRemoveStocks_Click);
            // 
            // btnSClear
            // 
            this.btnSClear.BackColor = System.Drawing.Color.Transparent;
            this.btnSClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSClear.BackgroundImage")));
            this.btnSClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSClear.ForeColor = System.Drawing.Color.White;
            this.btnSClear.Location = new System.Drawing.Point(152, 396);
            this.btnSClear.Name = "btnSClear";
            this.btnSClear.Size = new System.Drawing.Size(137, 50);
            this.btnSClear.TabIndex = 121;
            this.btnSClear.Text = "Clear";
            this.btnSClear.UseVisualStyleBackColor = false;
            this.btnSClear.Click += new System.EventHandler(this.btnSClear_Click);
            // 
            // btnSSave
            // 
            this.btnSSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSSave.BackgroundImage")));
            this.btnSSave.Enabled = false;
            this.btnSSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSave.ForeColor = System.Drawing.Color.White;
            this.btnSSave.Location = new System.Drawing.Point(5, 259);
            this.btnSSave.Name = "btnSSave";
            this.btnSSave.Size = new System.Drawing.Size(137, 50);
            this.btnSSave.TabIndex = 120;
            this.btnSSave.Text = "Save";
            this.btnSSave.UseVisualStyleBackColor = false;
            this.btnSSave.Click += new System.EventHandler(this.btnSSave_Click);
            // 
            // btnSDeduct
            // 
            this.btnSDeduct.BackColor = System.Drawing.Color.Transparent;
            this.btnSDeduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSDeduct.BackgroundImage")));
            this.btnSDeduct.Enabled = false;
            this.btnSDeduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDeduct.ForeColor = System.Drawing.Color.White;
            this.btnSDeduct.Location = new System.Drawing.Point(152, 315);
            this.btnSDeduct.Name = "btnSDeduct";
            this.btnSDeduct.Size = new System.Drawing.Size(137, 50);
            this.btnSDeduct.TabIndex = 119;
            this.btnSDeduct.Text = "Deduct Stocks";
            this.btnSDeduct.UseVisualStyleBackColor = false;
            this.btnSDeduct.Click += new System.EventHandler(this.btnSDeduct_Click);
            // 
            // btnSEdit
            // 
            this.btnSEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnSEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSEdit.BackgroundImage")));
            this.btnSEdit.Enabled = false;
            this.btnSEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEdit.ForeColor = System.Drawing.Color.White;
            this.btnSEdit.Location = new System.Drawing.Point(152, 259);
            this.btnSEdit.Name = "btnSEdit";
            this.btnSEdit.Size = new System.Drawing.Size(137, 50);
            this.btnSEdit.TabIndex = 118;
            this.btnSEdit.Text = "Add To Stocks";
            this.btnSEdit.UseVisualStyleBackColor = false;
            this.btnSEdit.Click += new System.EventHandler(this.btnSEdit_Click);
            // 
            // txtSProdName
            // 
            this.txtSProdName.BackColor = System.Drawing.Color.Firebrick;
            this.txtSProdName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSProdName.Enabled = false;
            this.txtSProdName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSProdName.ForeColor = System.Drawing.Color.White;
            this.txtSProdName.Location = new System.Drawing.Point(130, 96);
            this.txtSProdName.Name = "txtSProdName";
            this.txtSProdName.Size = new System.Drawing.Size(159, 25);
            this.txtSProdName.TabIndex = 116;
            // 
            // txtStockNo
            // 
            this.txtStockNo.BackColor = System.Drawing.Color.Firebrick;
            this.txtStockNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStockNo.Enabled = false;
            this.txtStockNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockNo.ForeColor = System.Drawing.Color.White;
            this.txtStockNo.Location = new System.Drawing.Point(130, 130);
            this.txtStockNo.Name = "txtStockNo";
            this.txtStockNo.Size = new System.Drawing.Size(159, 25);
            this.txtStockNo.TabIndex = 113;
            // 
            // numQuan
            // 
            this.numQuan.Enabled = false;
            this.numQuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuan.Location = new System.Drawing.Point(81, 209);
            this.numQuan.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numQuan.Name = "numQuan";
            this.numQuan.Size = new System.Drawing.Size(70, 29);
            this.numQuan.TabIndex = 112;
            // 
            // txtReceived
            // 
            this.txtReceived.BackColor = System.Drawing.Color.Firebrick;
            this.txtReceived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceived.Enabled = false;
            this.txtReceived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceived.ForeColor = System.Drawing.Color.White;
            this.txtReceived.Location = new System.Drawing.Point(130, 162);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(159, 25);
            this.txtReceived.TabIndex = 110;
            // 
            // btnSAdd
            // 
            this.btnSAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnSAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSAdd.BackgroundImage")));
            this.btnSAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAdd.ForeColor = System.Drawing.Color.White;
            this.btnSAdd.Location = new System.Drawing.Point(155, 203);
            this.btnSAdd.Name = "btnSAdd";
            this.btnSAdd.Size = new System.Drawing.Size(137, 50);
            this.btnSAdd.TabIndex = 109;
            this.btnSAdd.Text = "Add New Stocks";
            this.btnSAdd.UseVisualStyleBackColor = false;
            this.btnSAdd.Click += new System.EventHandler(this.btnSAdd_Click);
            // 
            // lvStocks
            // 
            this.lvStocks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader15,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader13,
            this.columnHeader11,
            this.columnHeader12});
            this.lvStocks.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStocks.FullRowSelect = true;
            this.lvStocks.GridLines = true;
            this.lvStocks.Location = new System.Drawing.Point(298, 48);
            this.lvStocks.Name = "lvStocks";
            this.lvStocks.Size = new System.Drawing.Size(812, 414);
            this.lvStocks.TabIndex = 75;
            this.lvStocks.UseCompatibleStateImageBehavior = false;
            this.lvStocks.View = System.Windows.Forms.View.Details;
            this.lvStocks.SelectedIndexChanged += new System.EventHandler(this.lvStocks_SelectedIndexChanged);
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Stock ID.";
            this.columnHeader15.Width = 77;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Poduct ID.";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 108;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Product Name";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 134;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Description";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 111;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Selling Price";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 112;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Remaining Stocks";
            this.columnHeader11.Width = 138;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Receiving Date";
            this.columnHeader12.Width = 118;
            // 
            // UCInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.tabInventory);
            this.Controls.Add(this.panel1);
            this.Name = "UCInventory";
            this.Size = new System.Drawing.Size(1186, 694);
            this.Load += new System.EventHandler(this.UserControl4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabInventory.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceAdded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPriceBuy)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.TabControl tabInventory;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvStocks;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        public MyTextBox txtProdNo;
        public MyTextBox txtProdName;
        private System.Windows.Forms.ComboBox drpCat;
        public MyTextBox txtPriceSell;
        public MyTextBox txtProdDesc;
        private System.Windows.Forms.NumericUpDown txtPriceAdded;
        private System.Windows.Forms.NumericUpDown txtPriceBuy;
        private System.Windows.Forms.NumericUpDown numQuan;
        public MyTextBox txtReceived;
        private System.Windows.Forms.Button btnSAdd;
        public MyTextBox txtSProdName;
        public MyTextBox txtStockNo;
        public MyTextBox txtSearch;
        private System.Windows.Forms.ComboBox drpSearch;
        private System.Windows.Forms.Button btnSSave;
        private System.Windows.Forms.Button btnSDeduct;
        private System.Windows.Forms.Button btnSEdit;
        private System.Windows.Forms.Button btnSClear;
        private System.Windows.Forms.Button btnRemoveStocks;
        private System.Windows.Forms.ComboBox drpProd;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.NumericUpDown numDeduct;
        private System.Windows.Forms.Button btnRemoveZero;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}
