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
    public partial class frmLogin : Form
    {
       public clsUser user = new clsUser();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.txtPW.isPassword = true;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string un = txtUN.Text;
            string pw = txtPW.Text;
            string[] result;
            //to do: filter the input

            //to do: byte[] data = System.Text.Encoding.UTF8.GetBytes ("stRhong%pword");
            //       byte[] hash = SHA256.Create().ComputeHash(data);
            //The GetBytes method on an Encoding object converts a string to a byte array; the GetString method converts it back. An Encoding object cannot, however, convert an encrypted or hashed byte array to a string, because scrambled data usually violates text encoding rules.Instead, use Convert .ToBase64String and Convert.FromBase64String : these convert between any byte array and a legal(and XML - friendly) string.
            //byte[] data = System.Text.Encoding.UTF8.GetBytes(pw);
            //byte[] hash = SHA256.Create().ComputeHash(data);

            string query = "SELECT userID,gname,privelegeLevel FROM users WHERE username='" + un + "'  AND password='" + pw + "'";
            classDatabaseConnect dbConnObj = new classDatabaseConnect();
            result = dbConnObj.authenticate(query);
            if (result == null)
            {
                MessageBox.Show("Please provide a valid credential");
            }
            else
            {
                user.SetUserID(result[0]);
                user.SetGName(result[1]);
                user.SetPrivelge(result[2]);

                MessageBox.Show("Welcome " + user.GetGName());
                //MessageBox.Show("You are: " + user.getPrivelege());
                //ths.panel1.Size = new Size(1138, 732);
                // ths.panel2.Size = new Size(174, 732);
                // ths.panel2.Visible = true;
                //return user.getPrivelege();
                Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                txtPW.isPassword = false;
            }
            else
            {
                txtPW.isPassword = true;
            }
        }
    }
}
