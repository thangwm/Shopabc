using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace manager
{
    public partial class frmSanpham : Form
    {
        public frmSanpham()
        {
            InitializeComponent();
        }

     
        public void loaddata()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-THANGWM\\SQLEXPRESS;Initial Catalog=shopabc;Integrated Security=True");

            // Khởi tạo lệnh SQL để lấy dữ liệu từ bảng Hang
            string sql = "SELECT MaMon, TenMon, IDloaihang, Gia, HinhAnh FROM Hang";
            SqlCommand command = new SqlCommand(sql, connection);

            // Mở kết nối và đọc dữ liệu từ CSDL
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            // Khởi tạo DataTable để lưu trữ dữ liệu từ CSDL
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            // Gán dữ liệu từ DataTable vào DataGridView1
            dataGridView1.DataSource = dataTable;

            // Đóng kết nối
            connection.Close();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmAdd f = new frmAdd();
            this.Hide();
            f.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Lấy giá trị của cột MaMon từ dòng được chọn
            int maMon = (int)dataGridView1.CurrentRow.Cells["MaMon"].Value;

            // Khởi tạo kết nối tới CSDL
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-THANGWM\\SQLEXPRESS;Initial Catalog=shopabc;Integrated Security=True");

            // Xóa các hàng trong bảng "order_item" tham chiếu đến hàng cần xóa
            SqlCommand cmd1 = new SqlCommand("DELETE FROM order_item WHERE Item_id = @MaMon", connection);
            cmd1.Parameters.AddWithValue("@MaMon", maMon);

            // Khởi tạo lệnh SQL để xóa dòng có MaMon bằng giá trị lấy được ở trên
            string sql = "DELETE FROM Hang WHERE MaMon=@MaMon";
            SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@MaMon", maMon);

            // Mở kết nối và thực hiện các lệnh SQL
            connection.Open();
            cmd1.ExecuteNonQuery();
            command.ExecuteNonQuery();

            // Refresh lại dữ liệu trên DataGridView1
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

            // Đóng kết nối
            connection.Close();
        }
    }
}
