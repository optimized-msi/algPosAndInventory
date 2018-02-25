using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
namespace WindowsFormsApplication1
{
    public partial class UCInventory : UserControl
    {
        classDatabaseConnect dbcon = new classDatabaseConnect();
        Products prod = new Products();
        bool add = true; bool filled = true;// bool edit = false; bool delete = false; 
        public UCInventory()
        {
            InitializeComponent();
        }
        private void UserControl4_Load(object sender, EventArgs e)
        {
            //products
            Clear(); Lock(); LoadListView(); LoadDrp(); LoadSDrp();
            //stocks
            LoadStockListView(); btnSClear.PerformClick(); LoadSupCbo(); btnSupClear.PerformClick();
            //supplier
            buttonSupClear(); 
            //product price

            btnAdd.Enabled = true; btnSave.Enabled = false; btnEdit.Enabled = false; btnDelete.Enabled = false; ProductPriceClear();
        }
        private void LoadListView()
        {
            //to do: find a way to use dictionary so retrieving data will be reusable
            lvProducts.Items.Clear();
            try
            {
                dbcon.mysqlconnect.Open();
                string query;
                query = "SELECT product_ID,product_name,brand_name,product_desc,viscosity_name,oil_type, wheel_type, volume,unit FROM products,viscosity,brand WHERE products.viscosity_ID=viscosity.viscosity_ID AND products.brand_ID=brand.brand_ID";

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvProducts.View = View.Details;
                ListViewItem iItem;
                foreach (DataRow row in table.Rows)
                {
                    iItem = new ListViewItem();
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        if (i == 0)
                            iItem.Text = row.ItemArray[i].ToString();
                        else
                            iItem.SubItems.Add(row.ItemArray[i].ToString());
                    }
                    lvProducts.Items.Add(iItem);
                }

                dbcon.mysqlconnect.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void LoadDrp() {
            cboVisc.Items.Clear();
            string query = "SELECT viscosity_name FROM viscosity";
            dbcon.mysqlconnect.Open();
            MySqlCommand myCommand = new MySqlCommand(query, dbcon.mysqlconnect);
            myCommand.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = myCommand.ExecuteReader();
            //List<string> myCollection = new List<string>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    cboVisc.Items.Add(reader.GetString(0));
                }
                //drpCat.Items = myCollection.ToArray();
            }
            dbcon.mysqlconnect.Close();

            cboBrand.Items.Clear();
            string query1 = "SELECT brand_name FROM brand";
            dbcon.mysqlconnect.Open();
            MySqlCommand cmd1 = new MySqlCommand(query1, dbcon.mysqlconnect);
            cmd1.CommandTimeout = 60;
            MySqlDataReader reader1;
            reader1 = cmd1.ExecuteReader();
            //List<string> myCollection = new List<string>();

            if (reader1.HasRows) {
                while (reader1.Read()) {

                    cboBrand.Items.Add(reader1.GetString(0));
                }
                //drpCat.Items = myCollection.ToArray();
            }
            dbcon.mysqlconnect.Close();
        }
        private void btnAddBrand_Click(object sender, EventArgs e) {
            frmBrands frmBrand = new frmBrands();
            frmBrand.ShowDialog();
            LoadDrp();LoadListView();
        }
        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                ListViewItem item = lvProducts.SelectedItems[0];
                txtProdNo.Text = item.SubItems[0].Text;
                txtProdName.Text = item.SubItems[1].Text;
                cboBrand.Text = item.SubItems[2].Text;
                txtProdDesc.Text = item.SubItems[3].Text;
                cboVisc.Text = item.SubItems[4].Text;
                if (item.SubItems[5].Text == "Semi Synthetic") {
                    rdSemi.Checked = true; rdFull.Checked = false; rdOrd.Checked = false;
                } else if (item.SubItems[5].Text == "Fully Synthetic") {
                    rdFull.Checked = true; rdSemi.Checked = false; rdOrd.Checked = false;
                } else if (item.SubItems[5].Text == "Ordinary") {
                    rdOrd.Checked = true; rdSemi.Checked = false; rdFull.Checked = false;
                }

                if (item.SubItems[6].Text == "4-Wheel") {
                    rd4.Checked = true; rd2.Checked = false;
                } else if (item.SubItems[6].Text == "2-Wheel") {
                    rd2.Checked = true; rd4.Checked = false;
                }
                numVolume.Value = Convert.ToDecimal(item.SubItems[7].Text);
                btnEdit.Enabled = true; btnDelete.Enabled = true; btnAdd.Enabled = false; add = false; Lock();
                oldID = txtProdNo.Text; oldName = txtProdName.Text;
            }
            else
            {
                Clear();
            }
        }
        private void CheckInput()
        {
            if (txtProdNo.Text == "" || txtProdName.Text == "" || txtProdDesc.Text == "" || cboVisc.Text == "")
                filled = false;
            else
                filled = true;
        }
        private void Clear()
        {
            txtProdNo.Text = ""; txtProdName.Text = ""; txtProdDesc.Text = ""; cboVisc.Text = ""; cboBrand.Text = ""; rdFull.Checked = false; rdSemi.Checked = false; rdOrd.Checked = false; rd4.Checked = false; rd2.Checked = false; cboBrand.Text = ""; numVolume.Value =1 ; cboVol.Text = ""; cboVisc.Text = "";
        }
        private void Lock()
        {
            txtProdNo.Enabled = false; txtProdName.Enabled = false; txtProdDesc.Enabled = false; cboVisc.Enabled = false; cboBrand.Enabled = false; grpOil.Enabled = false; grpWheel.Enabled = false; cboBrand.Enabled = false; numVolume.Enabled = false; cboVol.Enabled = false; cboVisc.Enabled = false; btnAddBrand.Enabled = false; btnAddViscosity.Enabled = false;
        }
        private void UnLock()
        {
            txtProdNo.Enabled = true; txtProdName.Enabled = true; txtProdDesc.Enabled = true; cboVisc.Enabled = true; cboBrand.Enabled = true; grpOil.Enabled = true; grpWheel.Enabled = true; cboBrand.Enabled = true; numVolume.Enabled = true; cboVol.Enabled = true; cboVisc.Enabled = true; btnAddBrand.Enabled = true; btnAddViscosity.Enabled = true;
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            UnLock(); add = true; btnSave.Enabled = true; btnAdd.Enabled = false; btnDelete.Enabled = false; btnEdit.Enabled = false;
            txtProdNo.Focus();
        }
        private string oldID, oldName;
        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            UnLock(); add = false; btnSave.Enabled = true; btnAdd.Enabled = false; btnDelete.Enabled = false; btnEdit.Enabled = false; txtProdNo.Enabled = false; txtProdNo.Enabled = false;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "Inventory", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                prod.prodNo = txtProdNo.Text;
                prod.DeleteProduct();
                LoadListView();
                btnClear.PerformClick();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            prod.prodNo = txtProdNo.Text; prod.prodName = txtProdName.Text; prod.prodDesc = txtProdDesc.Text; prod.viscosity = cboVisc.Text; prod.brand = cboBrand.Text; prod.volume = numVolume.Value.ToString(); prod.unit = cboVol.Text;
            if (rdSemi.Checked == true)
                prod.oilType = "Semi Synthetic";
            else if (rdFull.Checked == true)
                prod.oilType = "Full Synthetic";
            else if (rdOrd.Checked == true)
                prod.oilType = "Ordinary";

            if (rd4.Checked == true)
                prod.wheelType = "4-Wheel";
            else if (rd2.Checked == true)
                prod.wheelType = "2-Wheel";

            CheckInput();
            if (filled)
            {
                if (add) {
                    if (prod.InsertedProduct()) {
                        Clear(); Lock(); LoadListView();
                        btnAdd.Enabled = true; btnSave.Enabled = false; btnEdit.Enabled = false; btnDelete.Enabled = false;
                        LoadSDrp();
                    }
                } else {
                    if (prod.UpdatedProduct()) {
                        Clear(); Lock(); LoadListView();
                        btnAdd.Enabled = true; btnSave.Enabled = false; btnEdit.Enabled = false; btnDelete.Enabled = false;
                        LoadSDrp();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill-up all fields.", "Inventory");
            }
        }
        private void btnAddCategory_Click(object sender, EventArgs e) {
            frmViscosity frmCat = new frmViscosity();
            frmCat.ShowDialog();
            LoadDrp(); LoadListView();
        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear(); Lock(); btnAdd.Enabled = true; btnSave.Enabled = false; btnEdit.Enabled = false; btnDelete.Enabled = false;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            string query = "";
            if (drpSearch.Text == "All")
                query = "SELECT product_ID,product_name,product_desc,category.category_name,product_price,product_addedprice,product_sellingprice FROM products,category WHERE products.category_ID=category.category_ID";
            else if (drpSearch.Text == "Product ID")
                query = "SELECT product_ID,product_name,product_desc,category.category_name,product_price,product_addedprice,product_sellingprice FROM products,category WHERE products.category_ID=category.category_ID AND product_ID LIKE '%"+search+"%'";
            else if (drpSearch.Text == "Product Name")
                query = "SELECT product_ID,product_name,product_desc,category.category_name,product_price,product_addedprice,product_sellingprice FROM products,category WHERE products.category_ID=category.category_ID AND product_Name LIKE '%" + search + "%'";
            else if (drpSearch.Text == "Category")
                query = "SELECT product_ID,product_name,product_desc,category.category_name,product_price,product_addedprice,product_sellingprice FROM products,category WHERE products.category_ID=category.category_ID AND category.category_name LIKE '%" + search + "%'";
            lvProducts.Items.Clear();
            try
            {
                dbcon.mysqlconnect.Open();
                

                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvProducts.View = View.Details;
                ListViewItem iItem;
                foreach (DataRow row in table.Rows)
                {
                    iItem = new ListViewItem();
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        if (i == 0)
                            iItem.Text = row.ItemArray[i].ToString();
                        else
                            iItem.SubItems.Add(row.ItemArray[i].ToString());
                    }
                    lvProducts.Items.Add(iItem);
                }

                dbcon.mysqlconnect.Close();
            }
            catch (Exception)
            {
                LoadListView();
                dbcon.mysqlconnect.Close();
            }
        }

        private void drpSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpSearch.Text == "All")
                LoadListView();
        }
        private void drpProd_SelectedIndexChanged(object sender, EventArgs e) {
            string prodID = cboProd.Text;

            string query = "SELECT product_name FROM products WHERE product_ID='" + prodID + "'";
            dbcon.mysqlconnect.Open();
            MySqlCommand myCommand = new MySqlCommand(query, dbcon.mysqlconnect);
            myCommand.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = myCommand.ExecuteReader();
            //List<string> myCollection = new List<string>();

            if (reader.HasRows) {
                while (reader.Read()) {
                    txtSProdName.Text = reader.GetString(0);
                }
            }
            dbcon.mysqlconnect.Close();
        }



        //=============== Stocks ============
        string dt,sort;
        bool sAdd=false, sDeduct=false, sEdit=false,cChange=false;
        Stocks stock = new Stocks();
        private void LoadStockListView()
        {
            //to do: find a way to use dictionary so retrieving data will be reusable
            lvStocks.Items.Clear();
            try
            {
                dbcon.mysqlconnect.Open();
                string query="";
                if (sort== "Product ID")
                query = "SELECT stock_ID,products.product_ID,product_name,product_desc,total_stocks,remaining_stocks,received_date,supplier_name,supplier_price FROM products,stock,supplier WHERE stock.product_ID=products.product_ID AND supplier.supplier_ID=stock.supplier_ID ORDER BY stock.product_ID";
                else if(sort== "Product Name")
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,total_stocks,remaining_stocks,received_date,supplier_name,supplier_price FROM products,stock,supplier WHERE stock.product_ID=products.product_ID AND supplier.supplier_ID=stock.supplier_ID ORDER BY product_name";
                else if(sort== "Stock ID")
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,total_stocks,remaining_stocks,received_date,supplier_name,supplier_price FROM products,stock,supplier WHERE stock.product_ID=products.product_ID AND supplier.supplier_ID=stock.supplier_ID ORDER BY stock_ID";
                else if(sort== "Available Stock")
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,total_stocks,remaining_stocks,received_date,supplier_name,supplier_price FROM products,stock,supplier WHERE stock.product_ID=products.product_ID AND supplier.supplier_ID=stock.supplier_ID ORDER BY stock_quantity";
                else if(sort == "Date - Desc")
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,total_stocks,remaining_stocks,received_date,supplier_name,supplier_price FROM products,stock,supplier WHERE stock.product_ID=products.product_ID AND supplier.supplier_ID=stock.supplier_ID ORDER BY received_date DESC";
                else if(sort== "Date - Asc")
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,total_stocks,remaining_stocks,received_date,supplier_name,supplier_price FROM products,stock,supplier WHERE stock.product_ID=products.product_ID AND supplier.supplier_ID=stock.supplier_ID ORDER BY received_date ASC";
                else
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,total_stocks,remaining_stocks,received_date,supplier_name,supplier_price FROM products,stock,supplier WHERE stock.product_ID=products.product_ID AND supplier.supplier_ID=stock.supplier_ID";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvStocks.View = View.Details;
                ListViewItem iItem;
                foreach (DataRow row in table.Rows)
                {
                    iItem = new ListViewItem();
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        if (i == 0)
                            iItem.Text = row.ItemArray[i].ToString();
                        else if (i == 6)
                            iItem.SubItems.Add((row.ItemArray[i].ToString()).Substring(0,10));
                        else
                            iItem.SubItems.Add(row.ItemArray[i].ToString());
                    }
                    lvStocks.Items.Add(iItem);
                }

                dbcon.mysqlconnect.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void LoadSDrp()
        {
            cboProd.Items.Clear();
            string query = "SELECT product_ID FROM products";
            dbcon.mysqlconnect.Open();
            MySqlCommand myCommand = new MySqlCommand(query, dbcon.mysqlconnect);
            myCommand.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = myCommand.ExecuteReader();
            //List<string> myCollection = new List<string>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    cboProd.Items.Add(reader.GetString(0));
                }
                //drpCat.Items = myCollection.ToArray();
            }
            dbcon.mysqlconnect.Close();
        }

        private void SLock()
        {
            cboProd.Enabled = false; txtStockNo.Enabled = false; numQuan.Enabled = false; cboSuppliers.Enabled = false; numSupPrice.Enabled = false;
        }
        private void SUnLock()
        {
            cboProd.Enabled = true; txtStockNo.Enabled = false; numQuan.Enabled = true; cboSuppliers.Enabled = true; numSupPrice.Enabled = true;
        }
        private void SClear()
        {
            cboProd.Text = ""; txtStockNo.Text = "";numQuan.Minimum = 0;numDeduct.Minimum = 0;numQuan.Value = 0;numDeduct.Value = 0 ; txtSProdName.Text = "";txtReceived.Text = ""; txtSProdName.BackColor = Color.Firebrick; txtReceived.BackColor = Color.Firebrick; numSupPrice.Value = 0; cboSuppliers.Text = "";
        }
        private void SButtonLock()
        {
            btnSAdd.Enabled = true;
            btnSDeduct.Enabled = false;
            btnSEdit.Enabled = false;
            btnSSave.Enabled = false;
            btnRemoveStocks.Enabled = false;
        }
        private void btnChangePrice_Click(object sender, EventArgs e) {
            btnChangePrice.Enabled = false; numSupPrice.Enabled = true; numSupPrice.Focus(); btnSSave.Enabled = true; btnSEdit.Enabled = false; btnSDeduct.Enabled = false;btnRemoveStocks.Enabled = false; cChange = true;
        }

        private void btnSClear_Click(object sender, EventArgs e)
        {
            SClear(); SButtonLock(); SLock();LoadStockListView(); LoadSupCbo();
            sAdd = false; sDeduct = false; sEdit = false;cChange = false; btnRemoveZero.Enabled = true; btnSAdd.Enabled = true; cboSuppliers.Text = ""; numSupPrice.Value = 0; btnChangePrice.Enabled = false; numDeduct.Enabled = true;
        }
      
        private void btnSDeduct_Click(object sender, EventArgs e)
        {
            sDeduct = true;
            numQuan.Enabled = false; numDeduct.Focus(); numDeduct.Maximum = numQuan.Value;btnSSave.Enabled = true; btnSEdit.Enabled = false; btnSDeduct.Enabled = false; numDeduct.Enabled = true; btnChangePrice.Enabled = false; btnRemoveZero.Enabled = false; btnRemoveStocks.Enabled = false;
        }

        private void lvStocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStocks.SelectedItems.Count > 0)
            {
                ListViewItem item = lvStocks.SelectedItems[0];
                txtStockNo.Text = item.SubItems[0].Text;
                cboProd.Text = item.SubItems[1].Text;
                txtSProdName.Text = item.SubItems[2].Text;
                numQuan.Value = Convert.ToDecimal(item.SubItems[5].Text);
                txtReceived.Text = item.SubItems[6].Text;
                cboSuppliers.Text = item.SubItems[7].Text;
                numSupPrice.Value = Convert.ToDecimal(item.SubItems[8].Text);
                btnSAdd.Enabled = false; btnSSave.Enabled = false; btnSEdit.Enabled = true;btnRemoveStocks.Enabled = true;btnSDeduct.Enabled = true; btnRemoveZero.Enabled = false; btnChangePrice.Enabled = false; SLock(); sAdd = false; sEdit = false;cChange = false; btnChangePrice.Enabled = true; numDeduct.Enabled = false;
            }
            else
            {
                Clear();
            }
        }

        private void btnSEdit_Click(object sender, EventArgs e)
        {
            btnSAdd.Enabled = false; btnSDeduct.Enabled = false;btnRemoveStocks.Enabled = false; sEdit = true; btnChangePrice.Enabled = false; numDeduct.Enabled = false;
            numQuan.Enabled = true; numQuan.Focus(); btnSSave.Enabled=true;btnSEdit.Enabled = false; numQuan.Value = 0;
        }

        private void btnRemoveStocks_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this stock?", "Inventory", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                stock.stock_ID = txtStockNo.Text;
                stock.DeleteStock();
                LoadStockListView();
                btnSClear.PerformClick();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        private void LoadSupCbo() {
            cboSuppliers.Items.Clear();
            string query = "SELECT supplier_name FROM supplier";
            dbcon.mysqlconnect.Open();
            MySqlCommand myCommand = new MySqlCommand(query, dbcon.mysqlconnect);
            myCommand.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = myCommand.ExecuteReader();
            //List<string> myCollection = new List<string>();

            if (reader.HasRows) {
                while (reader.Read()) {

                    cboSuppliers.Items.Add(reader.GetString(0));
                }
                //drpCat.Items = myCollection.ToArray();
            }
            dbcon.mysqlconnect.Close();
        }
        private void btnRemoveZero_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all zero stock?", "Inventory", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                stock.RemoveZero();
                MessageBox.Show("Deleted all zero stocks.", "Inventory");
                btnSClear.PerformClick();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        private void cboSort_SelectedIndexChanged(object sender, EventArgs e) {
            sort = cboSort.Text;
            LoadStockListView();
        }

        private void btnSAdd_Click(object sender, EventArgs e) {
            txtStockNo.Text = stock.SetStockID();
            cboProd.Enabled = true;
            SUnLock();
            sAdd = true;
            dt = System.DateTime.Now.ToString();
            txtReceived.Text = dt.Substring(0, 10);
            btnSSave.Enabled = true; btnRemoveZero.Enabled = false; btnSAdd.Enabled = false; btnChangePrice.Enabled = false;
        }
        private void btnSSave_Click(object sender, EventArgs e) {
            stock.stock_ID = txtStockNo.Text; stock.product_ID = cboProd.Text; stock.received_date = dt; stock.stock_quantity = numQuan.Value.ToString(); stock.deduct = numDeduct.Value.ToString(); stock.supplier = cboSuppliers.Text; stock.supplier_price = numSupPrice.Value.ToString();
            if (sAdd) {
                if (numQuan.Value.ToString() == "0") {
                    MessageBox.Show("Quantity must not be equal to zero", "Inventory");
                    numQuan.Focus();
                } else if(txtStockNo.Text=="" || cboProd.Text == "" || cboSuppliers.Text == "" || numSupPrice.Text == "0") {
                    MessageBox.Show("Please fill-up all fields", "Inventory");
                } else {
                    stock.InsertStocks();
                     sAdd = false;
                    btnSClear.PerformClick();
                }
            } else if (sEdit) {
                stock.UpdateStock();
                sEdit = false;
                btnSClear.PerformClick();
            } else if (sDeduct) {
                stock.DeductStock();
                sDeduct = false;
                btnSClear.PerformClick();
            }else if (cChange) {
                stock.ChangePrice();
                cChange = false;
                btnSClear.PerformClick();
            }
        }

        //================ Supplier ==============
        clsSupplier clsSupplier = new clsSupplier();
       bool supadd = false, supedit = false; string query;
        private void SupLock() {
            txtSupplierName.Enabled = false; txtSupplierAddress.Enabled = false; txtSupplierContact.Enabled = false;
        }
        private void SupUnLock() {
            txtSupplierName.Enabled = true; txtSupplierAddress.Enabled = true; txtSupplierContact.Enabled = true;
        }
        private void SupClear() {
            txtSupplierName.Text = ""; txtSupplierAddress.Text = ""; txtSupplierContact.Text = ""; txtSupplierID.Text = "";
        }
        private void btnSupAdd_Click(object sender, EventArgs e) {
            btnSupAdd.Enabled = false; btnSupSave.Enabled = true; SupUnLock(); supadd = true;
        }

        private void btnSupDelete_Click(object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this supplier?", "Manage Supplier", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {
                clsSupplier.supplierID = txtSupplierID.Text;
                clsSupplier.DeleteSupplier();
                btnSupClear.PerformClick();
            } else if (dialogResult == DialogResult.No) {
                //do something else
            }
        }

        private void lvSupplier_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvSupplier.SelectedItems.Count > 0) {
                ListViewItem item = lvSupplier.SelectedItems[0];
                txtSupplierID.Text = item.SubItems[0].Text;
                txtSupplierName.Text = item.SubItems[1].Text;
                txtSupplierAddress.Text = item.SubItems[2].Text;
                txtSupplierAddress.Text = item.SubItems[3].Text;
                btnSupAdd.Enabled = false; btnSupEdit.Enabled = true; btnSupDelete.Enabled = true; btnSupSave.Enabled = false; supadd = false; supedit = false; SupLock();
            } else {
                //
            }
        }

        private void UCInventory_MouseMove(object sender, MouseEventArgs e) {
            frmMain.count = 0;
        }
        private void btnSupEdit_Click(object sender, EventArgs e) {
            btnSupEdit.Enabled = false; btnSupSave.Enabled = true; supedit = true; btnSupDelete.Enabled = false; SupUnLock();
        }

       

        private void btnSupSave_Click(object sender, EventArgs e) {
            if (txtSupplierName.Text.Trim() == "" || txtSupplierContact.Text.Trim() == "" || txtSupplierAddress.Text.Trim() == "") {
                MessageBox.Show("Please fill-up all fields", "Supplier");
            } else {
                clsSupplier.supplierID = txtSupplierID.Text; clsSupplier.supplierName = txtSupplierName.Text; clsSupplier.contact = txtSupplierContact.Text; clsSupplier.address = txtSupplierAddress.Text;
                if (supadd) {
                    add = false;
                    clsSupplier.InsertSupplier();
                } else if (supedit) {
                    supedit = false;
                    clsSupplier.UpdateSupplier();
                }
                btnSupClear.PerformClick();
            }
        }
        private void btnSupClear_Click(object sender, EventArgs e) {
            buttonSupClear(); LoadSupLV(); LoadSupCbo();
        }

       

        private void buttonSupClear() {
            LoadSupLV(); btnSupSave.Enabled = false; btnSupAdd.Enabled = true; btnSupEdit.Enabled = false; btnSupDelete.Enabled = false; SupClear(); SupLock();
        }
        private void LoadSupLV() {
            lvSupplier.Items.Clear();
            try {
                query = "SELECT supplier_ID, supplier_name, supplier_contact, supplier_address FROM supplier";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvSupplier.View = View.Details;
                ListViewItem iItem;
                foreach (DataRow row in table.Rows) {
                    iItem = new ListViewItem();
                    for (int i = 0; i < row.ItemArray.Length; i++) {
                        if (i == 0)
                            iItem.Text = row.ItemArray[i].ToString();
                        else
                            iItem.SubItems.Add(row.ItemArray[i].ToString());
                    }
                    lvSupplier.Items.Add(iItem);
                }
                dbcon.mysqlconnect.Close();
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //====== Product Price =========
        clsItems item = new clsItems();
        bool isPriceSet = false;
        private void cboPriceProductName_SelectedIndexChanged(object sender, EventArgs e) {
            btnPriceSetPrice.Enabled = true; numPriceDiscount.Enabled = true; numPriceSelling.Enabled = true;
            LoadSupplierPrice(cboPriceProductName.Text);
        }
        private void lvPriceProduct_SelectedIndexChanged(object sender, EventArgs e) {

        }
        private void lvPriceSupplier_SelectedIndexChanged(object sender, EventArgs e) {

        }
        double discountedPrice = 0;
        private void btnPriceSetPrice_Click(object sender, EventArgs e) {
            clsProductPrice prodPrice = new clsProductPrice();
            prodPrice.productID = lblPriceProductID.Text;  prodPrice.productPrice = numPriceSelling.Value.ToString();  prodPrice.discount = numPriceDiscount.Value.ToString(); prodPrice.discountedPrice = discountedPrice.ToString(); prodPrice.SetProductPrice(); prodPrice.isPriceSet = isPriceSet;
            btnPriceClear.PerformClick();
        }

        private void numPriceSelling_ValueChanged(object sender, EventArgs e) {
            try {
                lblPriceProductPrice.Text = numPriceSelling.Value.ToString();
                discountedPrice = (Convert.ToDouble(numPriceSelling.Value) - (Convert.ToDouble(numPriceSelling.Value) * ((Convert.ToDouble(numPriceDiscount.Value)) / 100)));
                lblPriceDiscounted.Text = discountedPrice.ToString();
            } catch (Exception) {
                throw;
            }
        }

        private void numPriceDiscount_ValueChanged(object sender, EventArgs e) {
            try {
                lblPriceDiscount.Text = numPriceDiscount.Value.ToString();
                discountedPrice = (Convert.ToDouble(numPriceSelling.Value) - (Convert.ToDouble(numPriceSelling.Value) * ((Convert.ToDouble(numPriceDiscount.Value)) / 100)));
                lblPriceDiscounted.Text = discountedPrice.ToString();
            } catch (Exception) {

            }
        }

        private void tabPage1_Click(object sender, EventArgs e) {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT product_ID,product_name,brand_name,product_desc,viscosity_name,oil_type, wheel_type, volume,unit FROM products,viscosity,brand WHERE products.viscosity_ID=viscosity.viscosity_ID AND products.brand_ID=brand.brand_ID";
                dbcon.mysqlconnect.Open();
                MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                MySqlDataAdapter adp = new MySqlDataAdapter();
                DataSet dt = new DataSet();
                adp.SelectCommand = cmd;
                adp.Fill(dt, "Products");
                CrystalReportProduct reporting = new CrystalReportProduct();
                reporting.SetDataSource(dt);
                frmReports frmreports = new frmReports();
                frmreports.crystalReportViewer.ReportSource = reporting;
                frmreports.crystalReportViewer.Refresh();
                cmd.Dispose(); adp.Dispose(); dt.Dispose(); dbcon.mysqlconnect.Close();
                frmreports.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string query = "";
                if (sort == "Product ID")
                {
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,total_stocks,remaining_stocks,received_date,supplier_name,supplier_price FROM products,stock,supplier WHERE stock.product_ID=products.product_ID AND supplier.supplier_ID=stock.supplier_ID ORDER BY stock.product_ID";
                    dbcon.mysqlconnect.Open();
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    MySqlDataAdapter adp = new MySqlDataAdapter();
                    DataSet dt = new DataSet();
                    adp.SelectCommand = cmd;
                    adp.Fill(dt, "Stocks");
                    CrystalReportStock reporting = new CrystalReportStock();
                    reporting.SetDataSource(dt);
                    frmReports frmreports = new frmReports();
                    frmreports.crystalReportViewer.ReportSource = reporting;
                    frmreports.crystalReportViewer.Refresh();
                    cmd.Dispose(); adp.Dispose(); dt.Dispose(); dbcon.mysqlconnect.Close();
                    frmreports.ShowDialog();
                }
                else if (sort == "Product Name")
                {
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,total_stocks,remaining_stocks,received_date,supplier_name,supplier_price FROM products,stock,supplier WHERE stock.product_ID=products.product_ID AND supplier.supplier_ID=stock.supplier_ID ORDER BY product_name";
                    dbcon.mysqlconnect.Open();
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    MySqlDataAdapter adp = new MySqlDataAdapter();
                    DataSet dt = new DataSet();
                    adp.SelectCommand = cmd;
                    adp.Fill(dt, "Stocks");
                    CrystalReportStock reporting = new CrystalReportStock();
                    reporting.SetDataSource(dt);
                    frmReports frmreports = new frmReports();
                    frmreports.crystalReportViewer.ReportSource = reporting;
                    frmreports.crystalReportViewer.Refresh();
                    cmd.Dispose(); adp.Dispose(); dt.Dispose(); dbcon.mysqlconnect.Close();
                    frmreports.ShowDialog();
                }
                else if (sort == "Stock ID")
                {
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,total_stocks,remaining_stocks,received_date,supplier_name,supplier_price FROM products,stock,supplier WHERE stock.product_ID=products.product_ID AND supplier.supplier_ID=stock.supplier_ID ORDER BY stock_ID";
                    dbcon.mysqlconnect.Open();
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    MySqlDataAdapter adp = new MySqlDataAdapter();
                    DataSet dt = new DataSet();
                    adp.SelectCommand = cmd;
                    adp.Fill(dt, "Stocks");
                    CrystalReportStock reporting = new CrystalReportStock();
                    reporting.SetDataSource(dt);
                    frmReports frmreports = new frmReports();
                    frmreports.crystalReportViewer.ReportSource = reporting;
                    frmreports.crystalReportViewer.Refresh();
                    cmd.Dispose(); adp.Dispose(); dt.Dispose(); dbcon.mysqlconnect.Close();
                    frmreports.ShowDialog();
                }
                else if (sort == "Available Stock")
                {
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,total_stocks,remaining_stocks,received_date,supplier_name,supplier_price FROM products,stock,supplier WHERE stock.product_ID=products.product_ID AND supplier.supplier_ID=stock.supplier_ID ORDER BY stock_quantity";
                    dbcon.mysqlconnect.Open();
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    MySqlDataAdapter adp = new MySqlDataAdapter();
                    DataSet dt = new DataSet();
                    adp.SelectCommand = cmd;
                    adp.Fill(dt, "Stocks");
                    CrystalReportStock reporting = new CrystalReportStock();
                    reporting.SetDataSource(dt);
                    frmReports frmreports = new frmReports();
                    frmreports.crystalReportViewer.ReportSource = reporting;
                    frmreports.crystalReportViewer.Refresh();
                    cmd.Dispose(); adp.Dispose(); dt.Dispose(); dbcon.mysqlconnect.Close();
                    frmreports.ShowDialog();
                }
                else if (sort == "Date - Desc")
                {
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,total_stocks,remaining_stocks,received_date,supplier_name,supplier_price FROM products,stock,supplier WHERE stock.product_ID=products.product_ID AND supplier.supplier_ID=stock.supplier_ID ORDER BY received_date DESC";
                    dbcon.mysqlconnect.Open();
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    MySqlDataAdapter adp = new MySqlDataAdapter();
                    DataSet dt = new DataSet();
                    adp.SelectCommand = cmd;
                    adp.Fill(dt, "Stocks");
                    CrystalReportStock reporting = new CrystalReportStock();
                    reporting.SetDataSource(dt);
                    frmReports frmreports = new frmReports();
                    frmreports.crystalReportViewer.ReportSource = reporting;
                    frmreports.crystalReportViewer.Refresh();
                    cmd.Dispose(); adp.Dispose(); dt.Dispose(); dbcon.mysqlconnect.Close();
                    frmreports.ShowDialog();
                }
                else if (sort == "Date - Asc")
                {
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,total_stocks,remaining_stocks,received_date,supplier_name,supplier_price FROM products,stock,supplier WHERE stock.product_ID=products.product_ID AND supplier.supplier_ID=stock.supplier_ID ORDER BY received_date ASC";
                    dbcon.mysqlconnect.Open();
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    MySqlDataAdapter adp = new MySqlDataAdapter();
                    DataSet dt = new DataSet();
                    adp.SelectCommand = cmd;
                    adp.Fill(dt, "Stocks");
                    CrystalReportStock reporting = new CrystalReportStock();
                    reporting.SetDataSource(dt);
                    frmReports frmreports = new frmReports();
                    frmreports.crystalReportViewer.ReportSource = reporting;
                    frmreports.crystalReportViewer.Refresh();
                    cmd.Dispose(); adp.Dispose(); dt.Dispose(); dbcon.mysqlconnect.Close();
                    frmreports.ShowDialog();
                }
                else
                {
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,total_stocks,remaining_stocks,received_date,supplier_name,supplier_price FROM products,stock,supplier WHERE stock.product_ID=products.product_ID AND supplier.supplier_ID=stock.supplier_ID";
                    dbcon.mysqlconnect.Open();
                    MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                    MySqlDataAdapter adp = new MySqlDataAdapter();
                    DataSet dt = new DataSet();
                    adp.SelectCommand = cmd;
                    adp.Fill(dt, "Stocks");
                    CrystalReportStock reporting = new CrystalReportStock();
                    reporting.SetDataSource(dt);
                    frmReports frmreports = new frmReports();
                    frmreports.crystalReportViewer.ReportSource = reporting;
                    frmreports.crystalReportViewer.Refresh();
                    cmd.Dispose(); adp.Dispose(); dt.Dispose(); dbcon.mysqlconnect.Close();
                    frmreports.ShowDialog();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtProdNo_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                txtProdName.Focus();
            }
        }

        private void btnPriceClear_Click(object sender, EventArgs e) {
            ProductPriceClear(); 
        }
        
        private void ProductPriceClear() {
            LoadCboProductPrice(); lvPriceSupplier.Items.Clear(); cboPriceProductName.Text = ""; btnPriceSetPrice.Enabled = false; isPriceSet = false; LoadProductPrice(); lblPriceDiscount.Text = "0.00"; LoadProductPrice();
        }
        private void LoadCboProductPrice() {
            cboPriceProductName.Items.Clear();
            foreach(string items in item.CboItem()) {
                cboPriceProductName.Items.Add(items);
            }
        }
        private void LoadSupplierPrice(string pname) {
            lvPriceSupplier.Items.Clear();
            int totalStocks = 0;
            try {
                query = "SELECT supplier_name, supplier_price, stock_ID, received_date, remaining_stocks FROM supplier,stock WHERE supplier.supplier_ID=stock.supplier_ID AND stock.product_ID=(SELECT product_ID FROM products WHERE product_name='" + pname+"')";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvPriceSupplier.View = View.Details;
                ListViewItem iItem;
                if (table.Rows.Count != 0) {
                    foreach (DataRow row in table.Rows) {
                        iItem = new ListViewItem();
                        for (int i = 0; i < row.ItemArray.Length; i++) {
                            if (i == 0)
                                iItem.Text = row.ItemArray[i].ToString();
                            else if (i == 3)
                                iItem.SubItems.Add((row.ItemArray[i].ToString()).Substring(0, 10));
                            else if (i == 4) {
                                iItem.SubItems.Add(row.ItemArray[i].ToString());
                                totalStocks += Convert.ToInt32(row.ItemArray[i].ToString());
                            } else
                                iItem.SubItems.Add(row.ItemArray[i].ToString());
                        }
                        lvPriceSupplier.Items.Add(iItem);
                    }
                    numPriceDiscount.Enabled = true; numPriceSelling.Enabled = true;
                } else {
                    lblPriceDiscount.Text = ""; lblPriceDiscounted.Text = ""; lblPriceProductPrice.Text = ""; btnPriceSetPrice.Enabled = false; numPriceDiscount.Value = 0; numPriceDiscount.Enabled = false; numPriceSelling.Value = 0; numPriceSelling.Enabled = false;
                }
                lblPriceTotalStocks.Text = totalStocks.ToString();
                dbcon.mysqlconnect.Close();

                dbcon.mysqlconnect.Open();
                query = "SELECT product_ID FROM products WHERE product_name='" + pname + "'";
                MySqlCommand cmd = new MySqlCommand(query, dbcon.mysqlconnect);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.HasRows) {
                    while (reader.Read()) {
                        lblPriceProductID.Text= reader.GetString(0);
                    }
                    //drpCat.Items = myCollection.ToArray();
                }
                lblPriceProductName.Text = pname;
                dbcon.mysqlconnect.Close();

                dbcon.mysqlconnect.Open();
                query = "SELECT product_price, discount, discounted_price FROM product_price WHERE product_price.product_ID=(SELECT product_ID FROM products WHERE product_name='" + pname + "')";
                MySqlCommand cmd1 = new MySqlCommand(query, dbcon.mysqlconnect);
                cmd1.CommandTimeout = 60;
                MySqlDataReader reader1;
                reader1 = cmd1.ExecuteReader();
                if (reader1.HasRows) {
                    while (reader1.Read()) {
                        lblPriceProductPrice.Text = reader1.GetString(0);
                        lblPriceDiscount.Text = reader1.GetString(1);
                        lblPriceDiscounted.Text = reader1.GetString(2);
                        numPriceSelling.Value = Convert.ToDecimal(reader1.GetString(0));
                        numPriceDiscount.Value = Convert.ToDecimal(reader1.GetString(1));
                    }
                    isPriceSet = true;
                } else
                    isPriceSet = false;
                dbcon.mysqlconnect.Close();
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void LoadProductPrice() {
            try {
                query = "SELECT products.product_ID,products.product_name,product_price.product_price, discount, discounted_price FROM products, product_price WHERE products.product_ID=product_price.product_ID";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvPriceProduct.View = View.Details;
                ListViewItem iItem;
                foreach (DataRow row in table.Rows) {
                    iItem = new ListViewItem();
                    for (int i = 0; i < row.ItemArray.Length; i++) {
                        if (i == 0)
                            iItem.Text = row.ItemArray[i].ToString();
                        else
                            iItem.SubItems.Add(row.ItemArray[i].ToString());
                    }
                    lvPriceProduct.Items.Add(iItem);
                }
                dbcon.mysqlconnect.Close();
            } catch (Exception) {

                throw;
            }
        }
    }
}
