﻿namespace WindowsFormsApplication1
{
    partial class ucServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucServices));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtTypeName = new MyTextBox();
            this.txtTypeID = new MyTextBox();
            this.btnVClear = new System.Windows.Forms.Button();
            this.btnVSave = new System.Windows.Forms.Button();
            this.btnVDelete = new System.Windows.Forms.Button();
            this.btnVEdit = new System.Windows.Forms.Button();
            this.btnVAdd = new System.Windows.Forms.Button();
            this.lvType = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tabInventory = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtServiceName = new MyTextBox();
            this.btnSClear = new System.Windows.Forms.Button();
            this.btnSSave = new System.Windows.Forms.Button();
            this.btnSDelete = new System.Windows.Forms.Button();
            this.btnSEdit = new System.Windows.Forms.Button();
            this.btnSAdd = new System.Windows.Forms.Button();
            this.txtServiceID = new MyTextBox();
            this.lvServices = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numFee = new System.Windows.Forms.NumericUpDown();
            this.cboVehicleType = new System.Windows.Forms.ComboBox();
            this.cboServiceName = new System.Windows.Forms.ComboBox();
            this.txtPriceID = new MyTextBox();
            this.btnPClear = new System.Windows.Forms.Button();
            this.btnPSave = new System.Windows.Forms.Button();
            this.btnPDelete = new System.Windows.Forms.Button();
            this.btnPEdit = new System.Windows.Forms.Button();
            this.btnPAdd = new System.Windows.Forms.Button();
            this.lvPrices = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabInventory.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFee)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 91;
            this.label3.Text = "Vehicle Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 84;
            this.label2.Text = "Service Price ID.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(330, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 83;
            this.label4.Text = "Service Fee:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(17, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 82;
            this.label6.Text = "Service Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Firebrick;
            this.tabPage3.Controls.Add(this.txtTypeName);
            this.tabPage3.Controls.Add(this.txtTypeID);
            this.tabPage3.Controls.Add(this.btnVClear);
            this.tabPage3.Controls.Add(this.btnVSave);
            this.tabPage3.Controls.Add(this.btnVDelete);
            this.tabPage3.Controls.Add(this.btnVEdit);
            this.tabPage3.Controls.Add(this.btnVAdd);
            this.tabPage3.Controls.Add(this.lvType);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(743, 359);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vehicle Types";
            // 
            // txtTypeName
            // 
            this.txtTypeName.BackColor = System.Drawing.Color.Firebrick;
            this.txtTypeName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTypeName.Enabled = false;
            this.txtTypeName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.ForeColor = System.Drawing.Color.White;
            this.txtTypeName.Location = new System.Drawing.Point(227, 48);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(161, 25);
            this.txtTypeName.TabIndex = 135;
            // 
            // txtTypeID
            // 
            this.txtTypeID.BackColor = System.Drawing.Color.Firebrick;
            this.txtTypeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTypeID.Enabled = false;
            this.txtTypeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeID.ForeColor = System.Drawing.Color.White;
            this.txtTypeID.Location = new System.Drawing.Point(227, 12);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(52, 25);
            this.txtTypeID.TabIndex = 134;
            // 
            // btnVClear
            // 
            this.btnVClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVClear.BackgroundImage")));
            this.btnVClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVClear.ForeColor = System.Drawing.Color.White;
            this.btnVClear.Location = new System.Drawing.Point(564, 231);
            this.btnVClear.Name = "btnVClear";
            this.btnVClear.Size = new System.Drawing.Size(102, 49);
            this.btnVClear.TabIndex = 132;
            this.btnVClear.Text = "Clear";
            this.btnVClear.UseVisualStyleBackColor = true;
            this.btnVClear.Click += new System.EventHandler(this.btnVClear_Click);
            // 
            // btnVSave
            // 
            this.btnVSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVSave.BackgroundImage")));
            this.btnVSave.Enabled = false;
            this.btnVSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVSave.ForeColor = System.Drawing.Color.White;
            this.btnVSave.Location = new System.Drawing.Point(564, 163);
            this.btnVSave.Name = "btnVSave";
            this.btnVSave.Size = new System.Drawing.Size(102, 49);
            this.btnVSave.TabIndex = 131;
            this.btnVSave.Text = "Save";
            this.btnVSave.UseVisualStyleBackColor = true;
            this.btnVSave.Click += new System.EventHandler(this.btnVSave_Click);
            // 
            // btnVDelete
            // 
            this.btnVDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVDelete.BackgroundImage")));
            this.btnVDelete.Enabled = false;
            this.btnVDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVDelete.ForeColor = System.Drawing.Color.White;
            this.btnVDelete.Location = new System.Drawing.Point(564, 99);
            this.btnVDelete.Name = "btnVDelete";
            this.btnVDelete.Size = new System.Drawing.Size(102, 49);
            this.btnVDelete.TabIndex = 130;
            this.btnVDelete.Text = "Delete";
            this.btnVDelete.UseVisualStyleBackColor = true;
            this.btnVDelete.Click += new System.EventHandler(this.btnVDelete_Click);
            // 
            // btnVEdit
            // 
            this.btnVEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVEdit.BackgroundImage")));
            this.btnVEdit.Enabled = false;
            this.btnVEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVEdit.ForeColor = System.Drawing.Color.White;
            this.btnVEdit.Location = new System.Drawing.Point(445, 163);
            this.btnVEdit.Name = "btnVEdit";
            this.btnVEdit.Size = new System.Drawing.Size(102, 49);
            this.btnVEdit.TabIndex = 129;
            this.btnVEdit.Text = "Edit";
            this.btnVEdit.UseVisualStyleBackColor = true;
            this.btnVEdit.Click += new System.EventHandler(this.btnVEdit_Click);
            // 
            // btnVAdd
            // 
            this.btnVAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVAdd.BackgroundImage")));
            this.btnVAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVAdd.ForeColor = System.Drawing.Color.White;
            this.btnVAdd.Location = new System.Drawing.Point(445, 99);
            this.btnVAdd.Name = "btnVAdd";
            this.btnVAdd.Size = new System.Drawing.Size(102, 49);
            this.btnVAdd.TabIndex = 128;
            this.btnVAdd.Text = "Add";
            this.btnVAdd.UseVisualStyleBackColor = true;
            this.btnVAdd.Click += new System.EventHandler(this.btnVAdd_Click);
            // 
            // lvType
            // 
            this.lvType.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvType.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvType.FullRowSelect = true;
            this.lvType.GridLines = true;
            this.lvType.Location = new System.Drawing.Point(118, 95);
            this.lvType.Name = "lvType";
            this.lvType.Size = new System.Drawing.Size(307, 219);
            this.lvType.TabIndex = 46;
            this.lvType.UseCompatibleStateImageBehavior = false;
            this.lvType.View = System.Windows.Forms.View.Details;
            this.lvType.SelectedIndexChanged += new System.EventHandler(this.lvType_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type ID";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vehicle Type";
            this.columnHeader4.Width = 202;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(121, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 19);
            this.label7.TabIndex = 39;
            this.label7.Text = "Type ID.:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(121, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Vehicle Type:";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Service Fee";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 172;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 60);
            this.panel1.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(435, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 39);
            this.label5.TabIndex = 30;
            this.label5.Text = "Services";
            // 
            // tabInventory
            // 
            this.tabInventory.Controls.Add(this.tabPage1);
            this.tabInventory.Controls.Add(this.tabPage2);
            this.tabInventory.Controls.Add(this.tabPage3);
            this.tabInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabInventory.Location = new System.Drawing.Point(41, 89);
            this.tabInventory.Name = "tabInventory";
            this.tabInventory.SelectedIndex = 0;
            this.tabInventory.Size = new System.Drawing.Size(943, 397);
            this.tabInventory.TabIndex = 57;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Firebrick;
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.txtServiceName);
            this.tabPage1.Controls.Add(this.btnSClear);
            this.tabPage1.Controls.Add(this.btnSSave);
            this.tabPage1.Controls.Add(this.btnSDelete);
            this.tabPage1.Controls.Add(this.btnSEdit);
            this.tabPage1.Controls.Add(this.btnSAdd);
            this.tabPage1.Controls.Add(this.txtServiceID);
            this.tabPage1.Controls.Add(this.lvServices);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(935, 359);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Services Offered";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtServiceName
            // 
            this.txtServiceName.BackColor = System.Drawing.Color.Firebrick;
            this.txtServiceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServiceName.Enabled = false;
            this.txtServiceName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceName.ForeColor = System.Drawing.Color.White;
            this.txtServiceName.Location = new System.Drawing.Point(133, 63);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(160, 25);
            this.txtServiceName.TabIndex = 128;
            // 
            // btnSClear
            // 
            this.btnSClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSClear.BackgroundImage")));
            this.btnSClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSClear.ForeColor = System.Drawing.Color.White;
            this.btnSClear.Location = new System.Drawing.Point(827, 288);
            this.btnSClear.Name = "btnSClear";
            this.btnSClear.Size = new System.Drawing.Size(102, 49);
            this.btnSClear.TabIndex = 127;
            this.btnSClear.Text = "Clear";
            this.btnSClear.UseVisualStyleBackColor = true;
            this.btnSClear.Click += new System.EventHandler(this.btnSClear_Click);
            // 
            // btnSSave
            // 
            this.btnSSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSSave.BackgroundImage")));
            this.btnSSave.Enabled = false;
            this.btnSSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSSave.ForeColor = System.Drawing.Color.White;
            this.btnSSave.Location = new System.Drawing.Point(827, 220);
            this.btnSSave.Name = "btnSSave";
            this.btnSSave.Size = new System.Drawing.Size(102, 49);
            this.btnSSave.TabIndex = 126;
            this.btnSSave.Text = "Save";
            this.btnSSave.UseVisualStyleBackColor = true;
            this.btnSSave.Click += new System.EventHandler(this.btnSSave_Click);
            // 
            // btnSDelete
            // 
            this.btnSDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSDelete.BackgroundImage")));
            this.btnSDelete.Enabled = false;
            this.btnSDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSDelete.ForeColor = System.Drawing.Color.White;
            this.btnSDelete.Location = new System.Drawing.Point(827, 156);
            this.btnSDelete.Name = "btnSDelete";
            this.btnSDelete.Size = new System.Drawing.Size(102, 49);
            this.btnSDelete.TabIndex = 125;
            this.btnSDelete.Text = "Delete";
            this.btnSDelete.UseVisualStyleBackColor = true;
            this.btnSDelete.Click += new System.EventHandler(this.btnSDelete_Click);
            // 
            // btnSEdit
            // 
            this.btnSEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSEdit.BackgroundImage")));
            this.btnSEdit.Enabled = false;
            this.btnSEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEdit.ForeColor = System.Drawing.Color.White;
            this.btnSEdit.Location = new System.Drawing.Point(719, 220);
            this.btnSEdit.Name = "btnSEdit";
            this.btnSEdit.Size = new System.Drawing.Size(102, 49);
            this.btnSEdit.TabIndex = 124;
            this.btnSEdit.Text = "Edit";
            this.btnSEdit.UseVisualStyleBackColor = true;
            this.btnSEdit.Click += new System.EventHandler(this.btnSEdit_Click);
            // 
            // btnSAdd
            // 
            this.btnSAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSAdd.BackgroundImage")));
            this.btnSAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAdd.ForeColor = System.Drawing.Color.White;
            this.btnSAdd.Location = new System.Drawing.Point(719, 156);
            this.btnSAdd.Name = "btnSAdd";
            this.btnSAdd.Size = new System.Drawing.Size(102, 49);
            this.btnSAdd.TabIndex = 123;
            this.btnSAdd.Text = "Add";
            this.btnSAdd.UseVisualStyleBackColor = true;
            this.btnSAdd.Click += new System.EventHandler(this.btnSAdd_Click);
            // 
            // txtServiceID
            // 
            this.txtServiceID.BackColor = System.Drawing.Color.Firebrick;
            this.txtServiceID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServiceID.Enabled = false;
            this.txtServiceID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceID.ForeColor = System.Drawing.Color.White;
            this.txtServiceID.Location = new System.Drawing.Point(133, 24);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(52, 25);
            this.txtServiceID.TabIndex = 122;
            // 
            // lvServices
            // 
            this.lvServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvServices.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvServices.FullRowSelect = true;
            this.lvServices.GridLines = true;
            this.lvServices.Location = new System.Drawing.Point(32, 108);
            this.lvServices.Name = "lvServices";
            this.lvServices.Size = new System.Drawing.Size(314, 206);
            this.lvServices.TabIndex = 46;
            this.lvServices.UseCompatibleStateImageBehavior = false;
            this.lvServices.View = System.Windows.Forms.View.Details;
            this.lvServices.SelectedIndexChanged += new System.EventHandler(this.lvServices_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Service ID.";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Service Name";
            this.columnHeader2.Width = 221;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "Service ID.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Service Name:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Firebrick;
            this.tabPage2.Controls.Add(this.numFee);
            this.tabPage2.Controls.Add(this.cboVehicleType);
            this.tabPage2.Controls.Add(this.cboServiceName);
            this.tabPage2.Controls.Add(this.txtPriceID);
            this.tabPage2.Controls.Add(this.btnPClear);
            this.tabPage2.Controls.Add(this.btnPSave);
            this.tabPage2.Controls.Add(this.btnPDelete);
            this.tabPage2.Controls.Add(this.btnPEdit);
            this.tabPage2.Controls.Add(this.btnPAdd);
            this.tabPage2.Controls.Add(this.lvPrices);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(935, 359);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Services Prices";
            // 
            // numFee
            // 
            this.numFee.Enabled = false;
            this.numFee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFee.Location = new System.Drawing.Point(425, 46);
            this.numFee.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numFee.Name = "numFee";
            this.numFee.Size = new System.Drawing.Size(159, 29);
            this.numFee.TabIndex = 137;
            // 
            // cboVehicleType
            // 
            this.cboVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicleType.Enabled = false;
            this.cboVehicleType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVehicleType.FormattingEnabled = true;
            this.cboVehicleType.Location = new System.Drawing.Point(146, 94);
            this.cboVehicleType.Name = "cboVehicleType";
            this.cboVehicleType.Size = new System.Drawing.Size(178, 29);
            this.cboVehicleType.TabIndex = 136;
            // 
            // cboServiceName
            // 
            this.cboServiceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServiceName.Enabled = false;
            this.cboServiceName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboServiceName.FormattingEnabled = true;
            this.cboServiceName.Location = new System.Drawing.Point(146, 54);
            this.cboServiceName.Name = "cboServiceName";
            this.cboServiceName.Size = new System.Drawing.Size(178, 29);
            this.cboServiceName.TabIndex = 135;
            // 
            // txtPriceID
            // 
            this.txtPriceID.BackColor = System.Drawing.Color.Firebrick;
            this.txtPriceID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPriceID.Enabled = false;
            this.txtPriceID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceID.ForeColor = System.Drawing.Color.White;
            this.txtPriceID.Location = new System.Drawing.Point(146, 22);
            this.txtPriceID.Name = "txtPriceID";
            this.txtPriceID.Size = new System.Drawing.Size(52, 25);
            this.txtPriceID.TabIndex = 133;
            // 
            // btnPClear
            // 
            this.btnPClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPClear.BackgroundImage")));
            this.btnPClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPClear.ForeColor = System.Drawing.Color.White;
            this.btnPClear.Location = new System.Drawing.Point(637, 266);
            this.btnPClear.Name = "btnPClear";
            this.btnPClear.Size = new System.Drawing.Size(102, 49);
            this.btnPClear.TabIndex = 132;
            this.btnPClear.Text = "Clear";
            this.btnPClear.UseVisualStyleBackColor = true;
            this.btnPClear.Click += new System.EventHandler(this.btnPClear_Click);
            // 
            // btnPSave
            // 
            this.btnPSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPSave.BackgroundImage")));
            this.btnPSave.Enabled = false;
            this.btnPSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPSave.ForeColor = System.Drawing.Color.White;
            this.btnPSave.Location = new System.Drawing.Point(637, 198);
            this.btnPSave.Name = "btnPSave";
            this.btnPSave.Size = new System.Drawing.Size(102, 49);
            this.btnPSave.TabIndex = 131;
            this.btnPSave.Text = "Save";
            this.btnPSave.UseVisualStyleBackColor = true;
            this.btnPSave.Click += new System.EventHandler(this.btnPSave_Click);
            // 
            // btnPDelete
            // 
            this.btnPDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPDelete.BackgroundImage")));
            this.btnPDelete.Enabled = false;
            this.btnPDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDelete.ForeColor = System.Drawing.Color.White;
            this.btnPDelete.Location = new System.Drawing.Point(637, 134);
            this.btnPDelete.Name = "btnPDelete";
            this.btnPDelete.Size = new System.Drawing.Size(102, 49);
            this.btnPDelete.TabIndex = 130;
            this.btnPDelete.Text = "Delete";
            this.btnPDelete.UseVisualStyleBackColor = true;
            this.btnPDelete.Click += new System.EventHandler(this.btnPDelete_Click);
            // 
            // btnPEdit
            // 
            this.btnPEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPEdit.BackgroundImage")));
            this.btnPEdit.Enabled = false;
            this.btnPEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPEdit.ForeColor = System.Drawing.Color.White;
            this.btnPEdit.Location = new System.Drawing.Point(532, 198);
            this.btnPEdit.Name = "btnPEdit";
            this.btnPEdit.Size = new System.Drawing.Size(102, 49);
            this.btnPEdit.TabIndex = 129;
            this.btnPEdit.Text = "Edit";
            this.btnPEdit.UseVisualStyleBackColor = true;
            this.btnPEdit.Click += new System.EventHandler(this.btnPEdit_Click);
            // 
            // btnPAdd
            // 
            this.btnPAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPAdd.BackgroundImage")));
            this.btnPAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPAdd.ForeColor = System.Drawing.Color.White;
            this.btnPAdd.Location = new System.Drawing.Point(532, 134);
            this.btnPAdd.Name = "btnPAdd";
            this.btnPAdd.Size = new System.Drawing.Size(102, 49);
            this.btnPAdd.TabIndex = 128;
            this.btnPAdd.Text = "Add";
            this.btnPAdd.UseVisualStyleBackColor = true;
            this.btnPAdd.Click += new System.EventHandler(this.btnPAdd_Click);
            // 
            // lvPrices
            // 
            this.lvPrices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader11,
            this.columnHeader10});
            this.lvPrices.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPrices.FullRowSelect = true;
            this.lvPrices.GridLines = true;
            this.lvPrices.Location = new System.Drawing.Point(22, 129);
            this.lvPrices.Name = "lvPrices";
            this.lvPrices.Size = new System.Drawing.Size(508, 221);
            this.lvPrices.TabIndex = 93;
            this.lvPrices.UseCompatibleStateImageBehavior = false;
            this.lvPrices.View = System.Windows.Forms.View.Details;
            this.lvPrices.SelectedIndexChanged += new System.EventHandler(this.lvPrices_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Service ID.";
            this.columnHeader8.Width = 79;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Service Name";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 133;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Vehicle Type";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 118;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(372, 85);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 206);
            this.listView1.TabIndex = 129;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Additinal for";
            this.columnHeader5.Width = 89;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Additional Fee Name";
            this.columnHeader6.Width = 141;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Additional Fee";
            this.columnHeader7.Width = 109;
            // 
            // ucServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabInventory);
            this.Name = "ucServices";
            this.Size = new System.Drawing.Size(1015, 499);
            this.Load += new System.EventHandler(this.ucServices_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ucServices_MouseMove);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabInventory.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lvType;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabInventory;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lvServices;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lvPrices;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        public MyTextBox txtServiceName;
        private System.Windows.Forms.Button btnSClear;
        private System.Windows.Forms.Button btnSSave;
        private System.Windows.Forms.Button btnSDelete;
        private System.Windows.Forms.Button btnSEdit;
        private System.Windows.Forms.Button btnSAdd;
        public MyTextBox txtServiceID;
        private System.Windows.Forms.Button btnVClear;
        private System.Windows.Forms.Button btnVSave;
        private System.Windows.Forms.Button btnVDelete;
        private System.Windows.Forms.Button btnVEdit;
        private System.Windows.Forms.Button btnVAdd;
        private System.Windows.Forms.Button btnPClear;
        private System.Windows.Forms.Button btnPSave;
        private System.Windows.Forms.Button btnPDelete;
        private System.Windows.Forms.Button btnPEdit;
        private System.Windows.Forms.Button btnPAdd;
        public MyTextBox txtPriceID;
        private System.Windows.Forms.ComboBox cboVehicleType;
        private System.Windows.Forms.ComboBox cboServiceName;
        private System.Windows.Forms.NumericUpDown numFee;
        public MyTextBox txtTypeName;
        public MyTextBox txtTypeID;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}
