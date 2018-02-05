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
            Clear(); Lock(); LoadListView(); LoadDrp(); LoadSDrp(); LoadStockListView(); btnSClear.PerformClick();
            btnAdd.Enabled = true; btnSave.Enabled = false; btnEdit.Enabled = false; btnDelete.Enabled = false; txtSProdName.BackColor = Color.Firebrick;
            txtReceived.BackColor = Color.Firebrick;
        }
        private void LoadListView()
        {
            //to do: find a way to use dictionary so retrieving data will be reusable
            lvProducts.Items.Clear();
            try
            {
                dbcon.mysqlconnect.Open();
                string query;
                query = "SELECT product_ID,product_name,product_desc,category.category_name,product_price,product_addedprice,product_sellingprice FROM products,category WHERE products.category_ID=category.category_ID";

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
        private void LoadDrp()
        {
            string query = "SELECT category_name FROM category";
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

                    drpCat.Items.Add(reader.GetString(0));
                }
                //drpCat.Items = myCollection.ToArray();
            }
            dbcon.mysqlconnect.Close();
        }

        private void lvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProducts.SelectedItems.Count > 0)
            {
                ListViewItem item = lvProducts.SelectedItems[0];
                txtProdNo.Text = item.SubItems[0].Text;
                txtProdName.Text = item.SubItems[1].Text;
                txtProdDesc.Text = item.SubItems[2].Text;
                drpCat.Text = item.SubItems[3].Text;
                txtPriceBuy.Text = item.SubItems[4].Text;
                txtPriceAdded.Text = item.SubItems[5].Text;
                txtPriceSell.Text = item.SubItems[6].Text;
                btnEdit.Enabled = true; btnDelete.Enabled = true; btnAdd.Enabled = false;
            }
            else
            {
                Clear();
            }
        }
        private void CheckInput()
        {
            if (txtProdNo.Text == "" || txtProdName.Text == "" || txtProdDesc.Text == "" || drpCat.Text == "" || txtPriceBuy.Text == "" || txtPriceAdded.Text == "" || txtPriceSell.Text == "")
                filled = false;
            else
                filled = true;
        }
        private void Clear()
        {
            txtProdNo.Text = ""; txtProdName.Text = ""; txtProdDesc.Text = ""; drpCat.Text = ""; txtPriceBuy.Text = ""; txtPriceAdded.Text = ""; txtPriceSell.Text = "";
        }
        private void Lock()
        {
            txtProdNo.Enabled = false; txtProdName.Enabled = false; txtProdDesc.Enabled = false; drpCat.Enabled = false; txtPriceBuy.Enabled = false; txtPriceAdded.Enabled = false; txtPriceSell.Enabled = false;
        }
        private void UnLock()
        {
            txtProdNo.Enabled = true; txtProdName.Enabled = true; txtProdDesc.Enabled = true; drpCat.Enabled = true; txtPriceBuy.Enabled = true; txtPriceAdded.Enabled = true;
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            UnLock(); add = true; btnSave.Enabled = true; btnAdd.Enabled = false; btnDelete.Enabled = false; btnEdit.Enabled = false;
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            UnLock(); add = false; btnSave.Enabled = true; btnAdd.Enabled = false; btnDelete.Enabled = false; btnEdit.Enabled = false;
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
            prod.prodNo = txtProdNo.Text; prod.prodName = txtProdName.Text; prod.prodDesc = txtProdDesc.Text; prod.category = drpCat.Text; prod.buyPrice = txtPriceBuy.Text; prod.addPrice = txtPriceAdded.Text; prod.sellPrice = txtPriceSell.Text;
            CheckInput();
            if (filled)
            {
                if (add)
                    prod.InsertProduct();
                else
                    prod.UpdateProduct();
                Clear(); Lock(); LoadListView();
                btnAdd.Enabled = true; btnSave.Enabled = false; btnEdit.Enabled = false; btnDelete.Enabled = false;
                LoadSDrp();
            }
            else
            {
                MessageBox.Show("Please fill-up all fields.", "Inventory");
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Clear(); Lock(); btnAdd.Enabled = true; btnSave.Enabled = false; btnEdit.Enabled = false; btnDelete.Enabled = false;
        }

        private void txtUN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPriceAdded_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtPriceSell.Text = (Convert.ToDouble(txtPriceBuy.Text) + Convert.ToDouble(txtPriceAdded.Text)).ToString();
            }
            catch (Exception)
            {
                //do nothing
                //throw;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtPriceAdded_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtPriceSell.Text = (Convert.ToDouble(txtPriceBuy.Value) + Convert.ToDouble(txtPriceAdded.Text)).ToString();
            }
            catch (Exception)
            {
                //do nothing
                //throw;
            }
        }

        private void txtPriceBuy_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtPriceSell.Text = (Convert.ToDouble(txtPriceBuy.Value) + Convert.ToDouble(txtPriceAdded.Text)).ToString();
            }
            catch (Exception)
            {
                //do nothing
                //throw;
            }
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


        //=============== Stocks ============
        string dt,sort;
        bool sAdd=false, sDeduct=false, sEdit=false;
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
                query = "SELECT stock_ID,products.product_ID,product_name,product_desc,product_sellingprice,stock_quantity,received_date FROM products,stock WHERE stock.product_ID=products.product_ID ORDER BY stock.product_ID";
                else if(sort== "Product Name")
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,product_sellingprice,stock_quantity,received_date FROM products,stock WHERE stock.product_ID=products.product_ID ORDER BY product_name";
                else if(sort== "Stock ID")
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,product_sellingprice,stock_quantity,received_date FROM products,stock WHERE stock.product_ID=products.product_ID ORDER BY stock_ID";
                else if(sort== "Available Stock")
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,product_sellingprice,stock_quantity,received_date FROM products,stock WHERE stock.product_ID=products.product_ID ORDER BY stock_quantity";
                else if(sort == "Date - Desc")
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,product_sellingprice,stock_quantity,received_date FROM products,stock WHERE stock.product_ID=products.product_ID ORDER BY received_date DESC";
                else if(sort== "Date - Asc")
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,product_sellingprice,stock_quantity,received_date FROM products,stock WHERE stock.product_ID=products.product_ID ORDER BY received_date ASC";
                else
                    query = "SELECT stock_ID,products.product_ID,product_name,product_desc,product_sellingprice,stock_quantity,received_date FROM products,stock WHERE stock.product_ID=products.product_ID";
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
            drpProd.Items.Clear();
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

                    drpProd.Items.Add(reader.GetString(0));
                }
                //drpCat.Items = myCollection.ToArray();
            }
            dbcon.mysqlconnect.Close();
        }

        private void SLock()
        {
            drpProd.Enabled = false;
            txtStockNo.Enabled = false;
            numQuan.Enabled = false;
            numDeduct.Enabled = false;
        }
        private void SUnLock()
        {
            drpProd.Enabled = true;
            txtStockNo.Enabled = true;
            numQuan.Enabled = true;
        }
        private void SClear()
        {
            drpProd.Text = "";
            txtStockNo.Text = "";
            numQuan.Minimum = 0;
            numDeduct.Minimum = 0;
            numQuan.Value = 0;
            numDeduct.Value = 0 ;
            txtSProdName.Text = "";
            txtReceived.Text = "";
            txtSProdName.BackColor = Color.Firebrick;
            txtReceived.BackColor = Color.Firebrick;
        }
        private void SButtonLock()
        {
            btnSAdd.Enabled = true;
            btnSDeduct.Enabled = false;
            btnSEdit.Enabled = false;
            btnSSave.Enabled = false;
            btnRemoveStocks.Enabled = false;
        }
        private void btnSClear_Click(object sender, EventArgs e)
        {
            SClear(); SButtonLock(); SLock();LoadStockListView();
            sAdd = false; sDeduct = false; sEdit = false; btnRemoveZero.Enabled = true;
        }
        private void drpProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string prodID=drpProd.Text;

            string query = "SELECT product_name FROM products WHERE product_ID='"+prodID +"'";
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
                    txtSProdName.Text = reader.GetString(0);
                }
            }
            dbcon.mysqlconnect.Close();
        }

        private void btnSDeduct_Click(object sender, EventArgs e)
        {
            sDeduct = true;
            numQuan.Enabled = false; numDeduct.Focus(); numDeduct.Maximum = numQuan.Value;btnSSave.Enabled = true; btnSEdit.Enabled = false; btnSDeduct.Enabled = false; numDeduct.Enabled = true;
        }

        private void lvStocks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvStocks.SelectedItems.Count > 0)
            {
                ListViewItem item = lvStocks.SelectedItems[0];
                txtStockNo.Text = item.SubItems[0].Text;
                drpProd.Text = item.SubItems[1].Text;
                txtSProdName.Text = item.SubItems[2].Text;
                numQuan.Value = Convert.ToDecimal(item.SubItems[5].Text);
                txtReceived.Text = item.SubItems[6].Text;
                btnSAdd.Enabled = false; btnSSave.Enabled = false; btnSEdit.Enabled = true;btnRemoveStocks.Enabled = true;btnSDeduct.Enabled = true; btnRemoveZero.Enabled = false;
            }
            else
            {
                Clear();
            }
        }

        private void btnSEdit_Click(object sender, EventArgs e)
        {
            btnSAdd.Enabled = false; btnSDeduct.Enabled = false;btnRemoveStocks.Enabled = false; sEdit = true;
            numQuan.Enabled = true; numQuan.Focus(); btnSSave.Enabled=true;btnSEdit.Enabled = false;
            numQuan.Minimum = numQuan.Value;
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

        private void btnAddCategory_Click(object sender, EventArgs e)
        {

        }

        private void cboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort = cboSort.Text;
            LoadStockListView();
        }

        private void btnSAdd_Click(object sender, EventArgs e)
        {
            drpProd.Enabled = true;
            SUnLock();
            sAdd = true;
            dt = System.DateTime.Now.ToString();
            txtReceived.Text = dt.Substring(0,10);
            btnSSave.Enabled = true; btnRemoveZero.Enabled = false;
        }
        private void btnSSave_Click(object sender, EventArgs e)
        {
            stock.stock_ID = txtStockNo.Text; stock.product_ID = drpProd.Text;stock.received_date = dt;stock.stock_quantity = numQuan.Value.ToString();stock.deduct = numDeduct.Value.ToString();
            if (sAdd)
            {
                if (numQuan.Value.ToString() == "0")
                {
                    MessageBox.Show("Quantity must not be equal to zero", "Inventory");
                    numQuan.Focus();
                    
                }
                stock.InsertStocks();
                sAdd = false;
            }
            else if (sEdit)
            {
                stock.UpdateStock();
                sEdit = false;
            }else if (sDeduct)
            {
                stock.DeductStock();
                sDeduct = false;
            }
            btnSClear.PerformClick();
        }
    }
}
