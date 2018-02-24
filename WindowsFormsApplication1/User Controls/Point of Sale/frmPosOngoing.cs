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
    public partial class frmPosOngoing : Form
    {
        public frmPosOngoing()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPosOngoing_MouseMove(object sender, MouseEventArgs e) {
            frmMain.count = 0;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
