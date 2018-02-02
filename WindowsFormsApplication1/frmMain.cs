﻿using System;
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
                this.sidePanel.Visible = true;
            }
            else if (frmlogin.user.GetPrivelege() == "clerk")
            {
                UCPointOfSale ucpointofsale = new UCPointOfSale();
                this.clerkPanel.Controls.Clear();
                this.clerkPanel.Controls.Add(ucpointofsale);
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
            Close();
        }

        private void ucFunctions1_Load(object sender, EventArgs e)
        {

        }

        private void ucFunctions2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
            InitializeComponent();
            UCPosPay ucinventory = new UCPosPay();
            this.myPanel.Controls.Clear();
            this.myPanel.Controls.Add(ucinventory);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UCInventory ucinventory = new UCInventory();
            myPanel.Controls.Clear();
            myPanel.Controls.Add(ucinventory);
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
            myPanel.Controls.Clear();
            myPanel.Controls.Add(ucpointofsale);
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //for inventory
            UCInventory ucinventory = new UCInventory();
            myPanel.Controls.Clear();
            myPanel.Controls.Add(ucinventory);
       
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //for reports

            ucReports rep = new ucReports();
            myPanel.Controls.Clear();
            myPanel.Controls.Add(rep);
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            ucServices ucservices = new ucServices();
            myPanel.Controls.Clear();
            myPanel.Controls.Add(ucservices);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ucLogsAndMaintenance uclogsandmaintenance = new ucLogsAndMaintenance();
            myPanel.Controls.Clear();
            myPanel.Controls.Add(uclogsandmaintenance);
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            myPanel.Controls.Clear();
            clerkPanel.Controls.Clear();
            clerkPanel.Visible = true;
            frmlogin.txtUN.Text = "";
            frmlogin.txtPW.Text = "";
            frmlogin.user.SetGName(null);
            frmlogin.user.SetUserID(null);
            frmlogin.user.SetPrivelge(null);
            Login();
        }
    }
}