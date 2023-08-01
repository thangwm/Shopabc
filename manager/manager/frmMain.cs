using System;
using System.Windows.Forms;

namespace manager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private Form currentFormChild;
        private void OpenchildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;

            if (MainClass.USER == "admin")
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                guna2Panel1.Controls.Add(childForm);
                guna2Panel1.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else if (childForm is frmShop || childForm is frmHome)
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                guna2Panel1.Controls.Add(childForm);
                guna2Panel1.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền tri cập!");
            }
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            if (MainClass.USER == "admin")
            {
                OpenchildForm(new frmHome());
            }
            else
            {
                OpenchildForm(new frmShop());
            }
            lblUser.Text = MainClass.USER;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click_1(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox1_Click_2(object sender, EventArgs e)
        {

            if (sizebars.Width == 53)
            {
                sizebars.Visible = false;
                sizebars.Width = 221;
                guna2Transition1.ShowSync(sizebars);
            }
            else
            {
                sizebars.Visible = true;
                sizebars.Width = 53;
                guna2Transition1.ShowSync(sizebars);
            }
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            OpenchildForm(new frmHome());
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            OpenchildForm(new frmThongke());
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            OpenchildForm(new frmTaikhoan());
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            OpenchildForm(new frmShop());

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin f = new frmLogin();
            f.Show();
            this.Hide();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void sizebars_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            OpenchildForm(new frmSanpham());
        }
    }
}
