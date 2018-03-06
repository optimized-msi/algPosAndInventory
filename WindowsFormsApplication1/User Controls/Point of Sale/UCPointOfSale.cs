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
        string query = ""; bool lvIclick = false, lvSclick=false;
        public UCPointOfSale()
        {
            InitializeComponent();
        }
        private void UserControl3_Load(object sender, EventArgs e)
        {
            clsUser clsuser = new clsUser();
            txtItemCode.Focus();
            //LoadCity();
            lblCashierName.Text = clsuser.GetGName();
        }
        private void txtItemCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectItem();
                AddTotalItem();
                //MessageBox.Show("Test");
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
                query = "SELECT products.product_ID,product_name,product_desc,TRUNCATE(discounted_price,2),discount FROM products,product_price WHERE products.product_ID=product_price.product_ID AND products.product_ID='"+txtItemCode.Text+"'";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvItems.View = View.Details;
                ListViewItem iItem; double total = 0.0; bool isItemExisting = false;
                //to do: surround w/ if to determine if datatable returns rows
                if (table != null && table.Rows.Count>0)
                {
                    if (!IsSameItem())
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            iItem = new ListViewItem();
                            for (int i = 0; i < 7; i++)
                            {
                                if (i == 0)
                                    iItem.Text = row.ItemArray[i].ToString();
                                else if (i == 3) {
                                    total = Convert.ToDouble(row.ItemArray[i].ToString()) * Convert.ToDouble(numQuan.Value.ToString());
                                    iItem.SubItems.Add((Math.Truncate(Convert.ToDouble(row.ItemArray[i]) * 100) / 100).ToString("F"));
                                    isItemExisting = true;
                                } else if (i == 4)
                                    iItem.SubItems.Add(row.ItemArray[i].ToString() + "%");
                                else if (i == 5) {
                                    iItem.SubItems.Add(numQuan.Value.ToString());
                                } else if (i == 6) {
                                    iItem.SubItems.Add(total.ToString("F"));
                                } else
                                    iItem.SubItems.Add(row.ItemArray[i].ToString());

                            }
                            lvItems.Items.Add(iItem);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Barcode not existing","Point of Sale");
                }
                txtItemCode.Clear(); numQuan.Value = 1;
                dbcon.mysqlconnect.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private bool IsSameItem()
        {
            bool same = false;
            foreach (ListViewItem item in lvItems.Items)
            {
                if (txtItemCode.Text == item.Text && !lvIclick)
                {
                    item.SubItems[5].Text =(Convert.ToInt16(numQuan.Value) + Convert.ToInt16(item.SubItems[5].Text)).ToString();
                    item.SubItems[6].Text =(Convert.ToDouble(item.SubItems[3].Text) * Convert.ToDouble(item.SubItems[5].Text)).ToString();
                    same = true;

                }else if (txtItemCode.Text == item.Text && lvIclick)
                {
                    item.SubItems[5].Text = Convert.ToInt16(numQuan.Value).ToString();
                    item.SubItems[6].Text = (Convert.ToDouble(item.SubItems[3].Text) * Convert.ToDouble(item.SubItems[5].Text)).ToString();
                    lvIclick = false;
                    same = true;
                }
            }
            return same;
        }
        private void btnAddService_Click(object sender, EventArgs e)
        {
            frmPosAddService frmposaddservice = new frmPosAddService();
            frmposaddservice.ShowDialog();
            if (clsPosService.plateNo != null)
            {
               ListViewItem iItem = new ListViewItem();
               iItem.Text = clsPosService.plateNo;
               iItem.SubItems.Add(clsPosService.vehicleType);
               iItem.SubItems.Add(clsPosService.model);
               iItem.SubItems.Add(clsPosService.color);
                iItem.SubItems.Add(clsPosService.serviceName);
               iItem.SubItems.Add(clsPosService.serviceFee);
               iItem.SubItems.Add(clsPosService.servicedBy);
               iItem.SubItems.Add(clsPosService.servicedAdded);
                lvServices.Items.Add(iItem);
            }
            AddTotalService();
        }
        private void AddTotalService() {
            double total = 0.0;
            foreach (ListViewItem item in lvServices.Items)
            {
                total = total+ (Convert.ToDouble(item.SubItems[5].Text.ToString()));
            }
            lblTotalService.Text = total.ToString();
            lblTotalAmount.Text = (Convert.ToDouble(lblTotalService.Text) + Convert.ToDouble(lblTotalItems.Text)).ToString();
            //if (numDiscount.Value == 0)
            lblDiscAmount.Text = lblTotalAmount.Text;
        }
        private void btnViewOngoing_Click(object sender, EventArgs e)
        {
            frmPosOngoing frmposonging = new frmPosOngoing();
            frmposonging.ShowDialog();
        }

        private void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count > 0)
            {
                ListViewItem item = lvItems.SelectedItems[0];
                txtItemCode.Text = item.SubItems[0].Text;
                numQuan.Text = item.SubItems[4].Text;
                lvIclick = true;
                btnRemove.Enabled = true;
            }
        }
        private void AddTotalItem()
        {
            double total = 0.0;
            foreach (ListViewItem item in lvItems.Items)
            {
                total = total + (Convert.ToDouble(item.SubItems[6].Text.ToString()));
            }
            lblTotalItems.Text = total.ToString("F");
            lblTotalAmount.Text = (Convert.ToDouble(lblTotalService.Text) + Convert.ToDouble(lblTotalItems.Text)).ToString("F");
            if (numDiscount.Value == 0)
                lblDiscAmount.Text = lblTotalAmount.Text;
        }
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            SelectItem();
            AddTotalItem();
        }

        private void lblTotalAmount_Click(object sender, EventArgs e)
        {
            
        }

        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {
            if (numDiscount.Value == 0)
            {
                lblDiscAmount.Text = lblTotalAmount.Text;
            }
            else
            {
                lblDiscAmount.Text = (Convert.ToDouble(lblTotalAmount.Text) - (Convert.ToDouble(lblTotalAmount.Text) * ((Convert.ToDouble(numDiscount.Value))/100))).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numDiscount.Enabled = true;
        }

        private void txtItemCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvSclick = true ;
            btnRemove.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count > 0)
            {
                foreach (ListViewItem eachItem in lvItems.SelectedItems)
                {
                    lvItems.Items.Remove(eachItem);
                }
            }
            else if (lvServices.SelectedItems.Count > 0)
            {
                foreach (ListViewItem eachItem in lvServices.SelectedItems)
                {
                    lvServices.Items.Remove(eachItem);
                }
            }
            AddTotalItem(); AddTotalService();
            btnRemove.Enabled = false;
        }
        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (lvItems.SelectedItems.Count > 0)
            {
                foreach (ListViewItem eachItem in lvItems.SelectedItems)
                {
                    lvItems.Items.Remove(eachItem);
                }
                AddTotalItem(); AddTotalService();
            }
            else if (lvServices.SelectedItems.Count > 0)
            {
                foreach (ListViewItem eachItem in lvServices.SelectedItems)
                {
                    lvServices.Items.Remove(eachItem);
                }
                AddTotalItem(); AddTotalService();
            } else
                MessageBox.Show("Select item/service to be removed", "Point of Sale" , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            numDiscount.Enabled = true;
        }

        private void btnPay_Click_1(object sender, EventArgs e)
        {
            if (lvServices.Items.Count > 0 || lvItems.Items.Count > 0)
            {
                frmPosPay frmpospay = new frmPosPay();
                if (lvServices.Items.Count > 0 && (cboCustName.Text == "")) {
                    MessageBox.Show("Please input name,address, and contact number", "Point of Sale");
                }
                else
                {
                    clsPosItems.total = lblTotalAmount.Text;
                    clsPosItems.totalItems = lblTotalItems.Text;
                    clsPosItems.totalServices = lblTotalService.Text;
                    clsPosItems.discount = numDiscount.Value.ToString();
                    clsPosItems.totalDisc = lblDiscAmount.Text;
                    clsPosItems.lvItems = lvItems;
                    clsPosItems.lvServices = lvServices;

                    frmpospay.ShowDialog();
                }
            }
            else
            {

            }
        }

        private void lvItems_SelectedIndexChanged_1(object sender, EventArgs e) {
            if (lvItems.SelectedItems.Count > 0) {
                ListViewItem item = lvItems.SelectedItems[0];
                txtItemCode.Text = item.SubItems[0].Text;
                numQuan.Text = item.SubItems[4].Text;
                lvIclick = true;
                btnRemove.Enabled = true;
            }
        }

        private void lvServices_SelectedIndexChanged_1(object sender, EventArgs e) {

        }

        private void UCPointOfSale_MouseMove(object sender, MouseEventArgs e) {
            frmMain.count = 0;

        }

        private void panel2_Paint(object sender, PaintEventArgs e) {

        }

        private void cboBarangay_SelectedIndexChanged(object sender, EventArgs e) {

        }
        private void label29_Click(object sender, EventArgs e) {

        }

       

        private void timer1_Tick(object sender, EventArgs e) {
            lblDateAndTime.Text = DateTime.Now.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            frmManageCustomer frmManageCustomer = new frmManageCustomer();
            frmManageCustomer.ShowDialog();
        }

        private void btnNewTrans_Click(object sender, EventArgs e) {
            txtItemCode.Clear(); numQuan.Value = 1; lblTotalAmount.Text = "0.00"; lblBalance.Text = "0.00"; lblDiscAmount.Text = "0.00"; lblPaid.Text = "0.00"; lblTotalItems.Text = "0.00"; lblTotalService.Text = "0.00"; lblAddress.Text = "-"; lblContact.Text = "-"; cboCustName.Text = ""; lvItems.Items.Clear(); lvServices.Items.Clear(); btnRemove.Enabled = false;
            //txtInvoiceNo.Text = GenerateInvoiceNo();
        }

       
    }
}
