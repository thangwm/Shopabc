using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" && txtpass.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản mật khẩu!");
                return;
            }
            else if (MainClass.IsValidUser(txtuser.Text, txtpass.Text) == false)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }

           else
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (checkBox1.Checked)
            {
                txtpass.PasswordChar = '\0'; // Hiển thị mật khẩu
            }
            else
            {
                txtpass.PasswordChar = '●'; // Ẩn mật khẩu
            }
            */

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
         
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpass.PasswordChar = '\0'; // Hiển thị mật khẩu
            }
            else
            {
                txtpass.PasswordChar = '●'; // Ẩn mật khẩu
            }
        }
    }
}
