using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMain : Form
    {
        frmLogin frmlogin = new frmLogin();
        classDatabaseConnect dbcon = new classDatabaseConnect();
            bool f = false;
        clsUser user = new clsUser();
        public frmMain()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Login();

            //  clsUser clsUser = new clsUser(); --- supposse to create a new object but doesn't work
            //used the clsUser user object from frmLogin :(
            if (frmlogin.user.GetPrivelege() == null)
            {
                Close();
            }
        }
        private void Login()
        {
            frmlogin.ShowDialog();
            if (frmlogin.user.GetPrivelege() == "admin")
            {
                //this.clerkPanel.SendToBack();
                this.clerkPanel.Visible = false;
                this.splitCont.Visible = true;
                this.btnCollapse.Visible = true;
               // this.sidePanel.Visible = true;
                //this.btnCollapse.Visible = true;
            }
            else if (frmlogin.user.GetPrivelege() == "clerk")
            {
                this.btnCollapse.Visible = false;
                UCPointOfSale ucpointofsale = new UCPointOfSale();
                this.clerkPanel.Controls.Clear();
                this.clerkPanel.Controls.Add(ucpointofsale);
                this.btnCollapse.Visible = false;
                this.splitCont.Visible = false;
            }
            else
            {
                Close();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "UPDATE users SET login_status=0 WHERE userID='" + user.GetUserID() + "'";
                dbcon.ManipulateData(query);
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }      
        }
        private void ucFunctions1_Load(object sender, EventArgs e)
        {

        }

        private void ucFunctions2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UCInventory ucinventory = new UCInventory();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(ucinventory);
        }

        private void ucFunctions2_Load_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //for  point of sale
            UCPointOfSale ucpointofsale = new UCPointOfSale();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(ucpointofsale);
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //for inventory
            UCInventory ucinventory = new UCInventory();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(ucinventory);
            ucinventory.Dock = DockStyle.Fill;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //for reports
            ucReports rep = new ucReports();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(rep);
            rep.Dock = DockStyle.Fill;
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            ucServices ucservices = new ucServices();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(ucservices);
            ucservices.Dock = DockStyle.Fill;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ucLogsAndMaintenance uclogsandmaintenance = new ucLogsAndMaintenance();
            
            //myPanel.Controls.Add(uclogsandmaintenance);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "UPDATE users SET login_status=0 WHERE userID='" +user.GetUserID()+ "'";
                dbcon.ManipulateData(query);
                splitCont.Panel2.Controls.Clear();
                clerkPanel.Controls.Clear();
                clerkPanel.Visible = true;
                splitCont.Visible = false;
                frmlogin.txtUN.Text = "";
                frmlogin.txtPW.Text = "";
                btnCollapse.Visible = false;
                frmlogin.user.SetGName(null);
                frmlogin.user.SetUserID(null);
                frmlogin.user.SetPrivelge(null);
                Login();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void btnManageEmp_Click(object sender, EventArgs e)
        {
            UCEmployeeInfo employee = new UCEmployeeInfo();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(employee);
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            UCManageUser manage = new UCManageUser();
            //frmMain frmmain = new frmMain();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(manage);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            UCCustomerRecord cust = new UCCustomerRecord();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(cust);
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            ucLogs logs = new ucLogs();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(logs);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            UCPointOfSale ucpointofsale = new UCPointOfSale();
            splitCont.Panel2.Controls.Clear();
            splitCont.Panel2.Controls.Add(ucpointofsale);
            //ucpointofsale.Dock = DockStyle.Fill;
        }

        private void btnPos_MouseEnter(object sender, EventArgs e)
        {
            //this.btnPOS.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.pos_firebrick));
            //btnPOS.UseVisualStyleBackColor = false;
            btnPOS.BackColor= Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))); 
        }

        private void btnPos_MouseLeave(object sender, EventArgs e)
        {
            //this.btnPOS.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.pos_white));
            btnPOS.BackColor = Color.Transparent;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (f == false)
            {
                splitCont.Panel1Collapsed = true;
                f = true;
            }
            else
            {
                splitCont.Panel1Collapsed = false;
                
                f = false;
            }
           
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            splitCont.Panel2.Controls.Clear();
            maintenancePanel.Visible = true;
            splitCont.Panel2.Controls.Add(maintenancePanel);
            maintenancePanel.Dock = DockStyle.Fill;
        }

        private void btnInventory_MouseEnter(object sender, EventArgs e)
        {
            //btnInventory.UseVisualStyleBackColor = false;
            btnInventory.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void btnInventory_MouseLeave(object sender, EventArgs e)
        {
            btnInventory.BackColor = Color.Transparent;
        }

        private void btnReports_MouseEnter(object sender, EventArgs e)
        {
            btnReports.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void btnReports_MouseLeave(object sender, EventArgs e)
        {
            btnReports.BackColor = Color.Transparent;
        }

        private void btnServices_MouseEnter(object sender, EventArgs e)
        {
            btnServices.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));

        }

        private void btnServices_MouseLeave(object sender, EventArgs e)
        {
            btnServices.BackColor = Color.Transparent;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }
    }
}
