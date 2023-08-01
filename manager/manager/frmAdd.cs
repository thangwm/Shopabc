using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string connectionString = "Data Source=DESKTOP-THANGWM\\SQLEXPRESS;Initial Catalog=shopabc;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                // Set the new item's information
                string tenMon = textBox1.Text;
                string idLoaiHang = textBox2.Text;
                int gia = int.Parse(textBox3.Text);
                byte[] hinhAnh = null;
                if (pictureBox1.Image != null)
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        hinhAnh = stream.ToArray();
                    }
                }

                // Insert the new item into the database
                string sqlCommand = "INSERT INTO Hang (TenMon, IDloaihang, Gia, HinhAnh) VALUES (@TenMon, @IDloaihang, @Gia, @HinhAnh)";
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                command.Parameters.AddWithValue("@TenMon", tenMon);
                command.Parameters.AddWithValue("@IDloaihang", idLoaiHang);
                command.Parameters.AddWithValue("@Gia", gia);
                command.Parameters.AddWithValue("@HinhAnh", hinhAnh);
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Thêm thành công");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|All Files (*.*)|*.*";
            dialog.InitialDirectory = "C:\\";
            dialog.Title = "Chọn ảnh";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
