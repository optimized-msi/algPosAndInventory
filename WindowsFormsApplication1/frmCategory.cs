using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication1
{
    public partial class frmCategory : Form
    {
        classDatabaseConnect dbcon = new classDatabaseConnect(); bool add=false, edit=false; string query;
        public frmCategory()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCat.SelectedItems.Count > 0)
            {
                ListViewItem item = lvCat.SelectedItems[0];
                txtCatNum.Text = item.SubItems[0].Text;
                txtCatName.Text = item.SubItems[1].Text;
                btnAdd.Enabled = false; btnEdit.Enabled = true;btnDelete.Enabled = true;btnSave.Enabled = false;
            }
            else
            {
                //
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false; btnSave.Enabled = true; txtCatName.Enabled = true;
            string res=""; add = true;
            try
            {
                query = "SELECT MAX(category_ID) FROM category";
                dbcon.mysqlconnect.Open();
                MySqlCommand myCommand = new MySqlCommand(query, dbcon.mysqlconnect);
                myCommand.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read()) { res = reader.GetString(0); res = (Convert.ToInt16(res) + 1).ToString(); }
                }
                else
                {
                    res = "0";
                }
                dbcon.mysqlconnect.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                // return false;   'no result is returned
            }
            txtCatNum.Text = res;
         }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false; btnSave.Enabled = true; edit = true;btnDelete.Enabled = false; txtCatName.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this category?", "Inventory", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                query = "DELETE FROM category WHERE category_ID='"+ txtCatNum.Text+"'";
                dbcon.ManipulateData(query);
                MessageBox.Show("Deleted a category", "Inventory");
                btnClear.PerformClick();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
        private void LoadLV()
        {
            lvCat.Items.Clear();
            try { 
                query = "SELECT category_ID,category_name FROM category";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvCat.View = View.Details;
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
                    lvCat.Items.Add(iItem);
                }

            dbcon.mysqlconnect.Close();
             }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadLV(); btnSave.Enabled = false; btnAdd.Enabled = true; btnEdit.Enabled = false; btnDelete.Enabled = false; txtCatName.Text = ""; txtCatNum.Text = ""; txtCatName.Enabled = false;
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadLV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCatName.Text.Trim() == "")
            {
                MessageBox.Show("Please Provide a category name");
                txtCatName.Focus();
            }
            else {
                string id = txtCatNum.Text, name = txtCatName.Text;
                if (add)
                {
                    add = false;
                    query = "INSERT INTO category(category_ID,category_name) VALUES ('"+id+"','"+name+"')";
                    dbcon.ManipulateData(query);
                    MessageBox.Show("Added a new product category", "Inventory");
                }else if (edit)
                {
                    edit = false;
                    query = "UPDATE category SET category_name='" + name + "' WHERE category_ID='" + id + "'";
                    dbcon.ManipulateData(query);
                    MessageBox.Show("Updated a product category", "Inventory");
                }
                btnClear.PerformClick();
            }
        }
    }
}
