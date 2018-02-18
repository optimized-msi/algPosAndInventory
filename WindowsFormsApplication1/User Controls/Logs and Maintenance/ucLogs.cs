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
    public partial class ucLogs : UserControl
    {
        public ucLogs()
        {
            InitializeComponent();
        }

        private void ucLogs_MouseMove(object sender, MouseEventArgs e) {
            frmMain.count = 0;

        }
    }
}
