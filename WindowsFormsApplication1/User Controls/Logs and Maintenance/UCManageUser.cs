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
    public partial class UCManageUser : UserControl
    {
        string query = ""; bool add = false, edit = false;
        classDatabaseConnect dbcon = new classDatabaseConnect();
        public UCManageUser()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            btnClear.PerformClick();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadLV(); btnSave.Enabled = false; btnAdd.Enabled = true; btnEdit.Enabled = false; btnDelete.Enabled = false; txtGN.Text = ""; txtFN.Text = ""; txtMI.Text = ""; txtUN.Text = ""; txtPW.Text = ""; txtAddress.Text = ""; txtUserNo.Text = ""; cboType.Text = ""; Lock();
        }
        private void Lock()
        {
            txtGN.Enabled = false; txtFN.Enabled = false; txtMI.Enabled = false; txtUN.Enabled = false; txtPW.Enabled = false;txtAddress.Enabled =false; cboType.Enabled = false;
        }
        private void Unlock()
        {
            txtGN.Enabled = true; txtFN.Enabled = true; txtMI.Enabled = true; txtUN.Enabled = true; txtPW.Enabled = true; txtAddress.Enabled = true; cboType.Enabled = true;
        }
        private void LoadLV()
        {
            lvUsers.Items.Clear();
            try
            {
                query = "SELECT userID, fName,gName,mInitial,user_address,username,password,user_type FROM users";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvUsers.View = View.Details;
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
                    lvUsers.Items.Add(iItem);
                }

                dbcon.mysqlconnect.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false; btnSave.Enabled = true; Unlock(); add = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this User?", "Manage Users", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                query = "DELETE FROM users WHERE userID='" + txtUserNo.Text + "'";
                dbcon.ManipulateData(query);
                MessageBox.Show("Deleted a user", "Manage Users");
                btnClear.PerformClick();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void lvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUsers.SelectedItems.Count > 0)
            {
                ListViewItem item = lvUsers.SelectedItems[0];
                txtUserNo.Text = item.SubItems[0].Text;
                txtFN.Text = item.SubItems[1].Text;
                txtGN.Text = item.SubItems[2].Text;
                txtMI.Text = item.SubItems[3].Text;
                txtAddress.Text = item.SubItems[4].Text;
                txtUN.Text = item.SubItems[5].Text;
                txtPW.Text = item.SubItems[6].Text;
                cboType.Text = item.SubItems[7].Text;
                btnAdd.Enabled = false; btnEdit.Enabled = true; btnDelete.Enabled = true; btnSave.Enabled = false;add = false;edit = false; Lock();
            }
            else
            {
                //
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim() == "" || txtFN.Text.Trim() == ""|| txtGN.Text.Trim() == ""|| txtMI.Text.Trim() == ""|| txtPW.Text.Trim() == ""|| txtUN.Text.Trim() == ""|| cboType.Text.Trim() == "")
            {
                MessageBox.Show("Please fill-up all fields","Manage Users");
            }
            else
            {
                string id = txtUserNo.Text;
                if (add)
                {
                    add = false;
                    query = "INSERT INTO users(fName,gName,mInitial,username,password,user_type,user_address) VALUES ('" + txtFN.Text + "','" + txtGN.Text + "','" + txtMI.Text + "','" + txtUN.Text + "','" + txtPW.Text + "','" + cboType.Text + "','" + txtAddress.Text + "')";
                    dbcon.ManipulateData(query);
                    MessageBox.Show("Added a new User", "Manage Users");
                }
                else if (edit)
                {
                    edit = false;
                    query = "UPDATE users SET fName='" + txtFN.Text + "',gName='" + txtGN.Text + "',mInitial='" + txtMI.Text + "',username='" + txtUN.Text + "',password='" + txtPW.Text + "',user_type='" + cboType.Text + "',user_address='" + txtAddress.Text + "' WHERE userID='" + id + "'";
                    dbcon.ManipulateData(query);
                    MessageBox.Show("Updated User information", "Manage Users");
                }
                btnClear.PerformClick();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false; btnSave.Enabled = true; edit = true; btnDelete.Enabled = false; Unlock();
        }
    }
}
