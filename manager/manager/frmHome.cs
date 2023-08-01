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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        private int ImageNumber = 1;
        private void LoadNextImages()
        {
            timer1.Start();
            ImageNumber++;
            if(ImageNumber > 5)
            {
                ImageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"C:\Users\thang\Downloads\BT_lớn_nhóm6\manager\manager\imgg\" + ImageNumber+".jpg");
        }
        private void LoadImages()
        {
            timer1.Start();
            ImageNumber--;
            if (ImageNumber < 1)
            {
                ImageNumber = 5;
            }
            pictureBox1.ImageLocation = string.Format(@"C:\Users\thang\Downloads\BT_lớn_nhóm6\manager\manager\imgg\" + ImageNumber + ".jpg");
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = string.Format(@"C:\Users\thang\Downloads\BT_lớn_nhóm6\manager\manager\imgg\" + ImageNumber+".jpg");

        }

        private void guna2CustomRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           LoadNextImages();
        }

        private void guna2CustomRadioButton3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadImages();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadNextImages();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
