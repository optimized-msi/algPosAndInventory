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
    public partial class UCFunctions : UserControl
    {
        public UCFunctions()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel17_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel16_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            UCInventory ucinventory = new UCInventory();
            frmMain frmmain = new frmMain();
            frmmain.Controls.Add(ucinventory);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCInventory ucinventory = new UCInventory();
            frmMain frmmain = new frmMain();
            frmmain.Controls.Add(ucinventory);
            MessageBox.Show("hello world");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
