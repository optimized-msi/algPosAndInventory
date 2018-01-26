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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            ucUserLogin ucUserLogin = new ucUserLogin(this);
            panel1.Controls.Add(ucUserLogin);
            //to do: set the panel of the to max when the user is to login
            //then resize the panel to show the navigation at the left side of the part, there are two panels
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
