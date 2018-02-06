using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ucLogsAndMaintenance : UserControl
    {
        public ucLogsAndMaintenance()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            UCManageUser manage = new UCManageUser();
            frmMain frmmain = new frmMain();
            frmmain.myPanel.Controls.Clear();
            frmmain.myPanel.Controls.Add(manage);
        }

        private void btnManageEmp_Click(object sender, EventArgs e)
        {
            UCEmployeeInfo employee = new UCEmployeeInfo();
            frmMain frmmain = new frmMain();
            frmmain.myPanel.Controls.Clear();
            frmmain.myPanel.Controls.Add(employee);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            UCCustomerRecord cust = new UCCustomerRecord();
            frmMain frmmain = new frmMain();
            frmmain.myPanel.Controls.Clear();
            frmmain.myPanel.Controls.Add(cust);
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            ucLogs logs = new ucLogs();
            frmMain frmmain = new frmMain();
            frmmain.myPanel.Controls.Clear();
            frmmain.myPanel.Controls.Add(logs);
        }
    }
}
