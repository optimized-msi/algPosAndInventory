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
    public partial class UCEmployeeInfo : UserControl
    {
        string query = ""; bool add = false, edit = false;
        classDatabaseConnect dbcon = new classDatabaseConnect();
        public UCEmployeeInfo()
        {
            InitializeComponent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            LoadLV(); btnSave.Enabled = false; btnAdd.Enabled = true; btnEdit.Enabled = false; btnDelete.Enabled = false; txtGN.Text = ""; txtFN.Text = ""; txtMI.Text = ""; txtAddress.Text = ""; txtEmpNo.Text = ""; txtPosition.Text = ""; Lock();
        }
        private void Lock()
        {
            txtGN.Enabled = false; txtFN.Enabled = false; txtMI.Enabled = false;txtAddress.Enabled = false; txtPosition.Enabled = false;
        }
        private void Unlock()
        {
            txtGN.Enabled = true; txtFN.Enabled = true; txtMI.Enabled = true; txtAddress.Enabled = true; txtPosition.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false; btnSave.Enabled = true; Unlock(); add = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = false; btnSave.Enabled = true; edit = true; btnDelete.Enabled = false; Unlock();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this employee?", "Manage Employee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                query = "DELETE FROM employee WHERE emp_ID='" + txtEmpNo.Text + "'";
                dbcon.ManipulateData(query);
                MessageBox.Show("Deleted an employee", "Manage Employee");
                btnClear.PerformClick();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim() == "" || txtFN.Text.Trim() == "" || txtGN.Text.Trim() == "" || txtMI.Text.Trim() == "" || txtPosition.Text.Trim() == "")
            {
                MessageBox.Show("Please fill-up all fields", "Manage Employee");
            }
            else
            {
                string id = txtEmpNo.Text;
                if (add)
                {
                    add = false;
                    query = "INSERT INTO employee(emp_fName,emp_gName,emp_mInitial,emp_position,emp_address) VALUES ('" + txtFN.Text + "','" + txtGN.Text + "','" + txtMI.Text + "','" + txtPosition.Text + "','" + txtAddress.Text + "')";
                    dbcon.ManipulateData(query);
                    MessageBox.Show("Added a new employee", "Manage Employee");
                }
                else if (edit)
                {
                    edit = false;
                    query = "UPDATE employee SET emp_fName='" + txtFN.Text + "',emp_gName='" + txtGN.Text + "',emp_mInitial='" + txtMI.Text + "',emp_position='" + txtPosition.Text + "',emp_address='" + txtAddress.Text + "' WHERE emp_ID='" + id + "'";
                    dbcon.ManipulateData(query);
                    MessageBox.Show("Updated User information", "Manage Users");
                }
                btnClear.PerformClick();
            }
        }

        private void lvEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEmp.SelectedItems.Count > 0)
            {
                ListViewItem item = lvEmp.SelectedItems[0];
                txtEmpNo.Text = item.SubItems[0].Text;
                txtFN.Text = item.SubItems[1].Text;
                txtGN.Text = item.SubItems[2].Text;
                txtMI.Text = item.SubItems[3].Text;
                txtPosition.Text = item.SubItems[4].Text;
                txtAddress.Text = item.SubItems[5].Text;
                btnAdd.Enabled = false; btnEdit.Enabled = true; btnDelete.Enabled = true; btnSave.Enabled = false; add = false; edit = false;Lock();
            }
            else
            {
                //
            }
        }

        private void UCEmployeeInfo_Load(object sender, EventArgs e)
        {
            btnClear.PerformClick();
        }

        private void LoadLV()
        {
            lvEmp.Items.Clear();
            try
            {
                query = "SELECT emp_ID, emp_fName,emp_gName,emp_mInitial,emp_position,emp_address FROM employee";
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, dbcon.mysqlconnect);
                DataTable table = new DataTable("myTable");
                mySqlDataAdapter.Fill(table);
                lvEmp.View = View.Details;
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
                    lvEmp.Items.Add(iItem);
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
