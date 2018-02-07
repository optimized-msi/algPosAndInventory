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
namespace WindowsFormsApplication1
{
    public partial class UCPointOfSale : UserControl
    {
        classDatabaseConnect dbcon = new classDatabaseConnect();
        string query = "";
        public UCPointOfSale()
        {
            InitializeComponent();
        }
        private void UserControl3_Load(object sender, EventArgs e)
        {
            txtItemCode.Focus();
        }
        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectItem();
                MessageBox.Show("Test");
            }
        }
        //to do for adding and selling a product:
        //1. select match of the item code entered(add the list in the listview first then save to db if confirmed or paid)
        //2. default item quantity is 1. if user clicked the item in the listview, focused is on the quantity then the "add item" will become "edit item" then the Total price is multiplied from Price(product_sellingprice) and quantity - loop from all the items. make sure to deduct the stocks from the old stocks, if old  stock is not sufficient then move to the newer
        //3. for the total item - just add up all the total in the listview
        //4. add to the quantity if the user scans barcode that is already in the list view
        //5. result to be printed in the receipt will be based from the listview
        private void SelectItem()
        {
            try
            {
                query = "SELECT product_ID,product_name,product_desc,product_sellingprice FROM products WHERE product_ID='"+txtItemCode.Text+"'";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvItems.View = View.Details;
                ListViewItem iItem; double total = 0.0; bool isItemExisting = false;
                //to do: surround w/ if to determine if datatable returns rows
                foreach (DataRow row in table.Rows)
                {
                    iItem = new ListViewItem();
                    for (int i = 0; i < row.ItemArray.Length; i++)
                    {
                        if (i == 0)
                            iItem.Text = row.ItemArray[i].ToString();
                        else if (i==3)
                        {
                            total = Convert.ToDouble(row.ItemArray[i].ToString()) * Convert.ToDouble(txtItemQuan.ToString());
                            iItem.SubItems.Add(row.ItemArray[i].ToString());
                            isItemExisting = true;
                        }
                        else
                            iItem.SubItems.Add(row.ItemArray[i].ToString());

                    }
                    iItem.SubItems.Add(txtItemQuan.Text);
                    iItem.SubItems.Add(total.ToString());
                    iItem.SubItems.Add(row.ItemArray[5].ToString());
                    lvItems.Items.Add(iItem);
                }

                dbcon.mysqlconnect.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
