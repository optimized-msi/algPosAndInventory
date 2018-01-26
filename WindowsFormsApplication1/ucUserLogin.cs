using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace WindowsFormsApplication1
{
    public partial class ucUserLogin : UserControl
    {
        Form2 ths;
        public ucUserLogin(Form2 frm)
        {
            InitializeComponent();
            ths = frm;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string un = txtUN.Text;
            string pw = txtPW.Text;
            string fname;
            //to do: filter the input

            //to do: byte[] data = System.Text.Encoding.UTF8.GetBytes ("stRhong%pword");
            //       byte[] hash = SHA256.Create().ComputeHash(data);
            //The GetBytes method on an Encoding object converts a string to a byte array; the GetString method converts it back. An Encoding object cannot, however, convert an encrypted or hashed byte array to a string, because scrambled data usually violates text encoding rules.Instead, use Convert .ToBase64String and Convert.FromBase64String : these convert between any byte array and a legal(and XML - friendly) string.
            byte[] data = System.Text.Encoding.UTF8.GetBytes(pw);
            byte[] hash = SHA256.Create().ComputeHash(data);
            
            string query = "SELECT fname FROM users WHERE username='" + un + "'  AND password='" + pw + "'";
            classDatabaseConnect dbConnObj = new classDatabaseConnect();
            fname = dbConnObj.authenticate(query);
            if (fname == "Invalid" || fname=="empty"){
                MessageBox.Show("Please provide a valid credential");
            }else {
                MessageBox.Show("Welcome " + fname);
                ths.panel1.Size = new Size(1138, 732);
                ths.panel2.Size = new Size(174, 732);
                ths.panel2.Visible = true;
            }
            
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUN_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
