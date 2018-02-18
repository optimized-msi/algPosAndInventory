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
    public partial class frmPosPay : Form
    {
        public frmPosPay()
        {
            InitializeComponent();
        }

        private void frmPosPay_Load(object sender, EventArgs e)
        {
            lblTotal.Text = clsPosItems.total;
            lblTotalAmount.Text = clsPosItems.totalDisc;
            lblDiscount.Text = clsPosItems.discount;
            lblTotalItems.Text = clsPosItems.totalItems;
            lblTotalService.Text = clsPosItems.totalServices;
            numCash.Maximum=Convert.ToDecimal(lblTotalAmount.Text);
            foreach (ListViewItem item in clsPosItems.lvItems.Items)
            {
               
            }
            foreach (ListViewItem item in clsPosItems.lvItems.Items)
            {

            }
            //last insert id
            //MySqlCommand dbcmd = _conn.CreateCommand();
            //dbcmd.CommandText = sqlCommandString;
            //dbcmd.ExecuteNonQuery();
            //long imageId = dbcmd.LastInsertedId;
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void numCash_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void numCash_ValueChanged_1(object sender, EventArgs e)
        {
            try
            {
                if ((Convert.ToDouble(numCash.Value)) >= (Convert.ToDouble(lblTotalAmount.Text)))
                    lblChange.Text = (Convert.ToDouble(numCash.Value) - Convert.ToDouble(lblTotalAmount.Text)).ToString();
                else
                    lblChange.Text = "0";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmPosPay_MouseMove(object sender, MouseEventArgs e) {
            frmMain.count = 0;

        }
    }
}
