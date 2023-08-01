using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manager
{
    public partial class frmThongke : Form
    {
        public frmThongke()
        {
            InitializeComponent();
       
        }
        string connectionString = "Data Source=DESKTOP-THANGWM\\SQLEXPRESS;Initial Catalog=shopabc;Integrated Security=True";
        private void DisplayProductQuantity()
        {
            // Thiết lập chuỗi kết nối CSDL
           

            // Tạo kết nối đến CSDL
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Truy vấn CSDL để tính tổng số lượng sản phẩm theo loại hàng
            string query = "SELECT loaihang.Ten, SUM(order_item.Quantity) as total_quantity " +
                           "FROM order_item " +
                           "INNER JOIN Hang ON Hang.MaMon = order_item.Item_id " +
                           "INNER JOIN loaihang ON loaihang.ID = Hang.IDloaihang " +
                           "GROUP BY loaihang.Ten";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            // Hiển thị số lượng sản phẩm theo từng loại hàng trên các button tương ứng
            while (reader.Read())
            {
                string categoryName = reader.GetString(0);
                int totalQuantity = reader.GetInt32(1);

                if (categoryName == "Áo")
                {
                    button1.Text = "Số áo đã bán(" + totalQuantity.ToString() + ")";
                }
                else if (categoryName == "Quần")
                {
                    button2.Text = "Số quần đã bán(" + totalQuantity.ToString() + ")";
                }
                else if (categoryName == "Giày")
                {
                    button3.Text = "Số Giày đã bán(" + totalQuantity.ToString() + ")";
                }
            }

            // Đóng kết nối và giải phóng tài nguyên
            reader.Close();
            command.Dispose();
            connection.Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public void load()
        {
            // Define connection string and query
            string connectionString = "Data Source=DESKTOP-THANGWM\\SQLEXPRESS;Initial Catalog=shopabc;Integrated Security=True";
            string query = "SELECT SUM(Total_price) FROM order_item";

            // Create a SqlConnection object and open the connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a SqlCommand object with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int totalSales = Convert.ToInt32(result);
                        guna2Button1.Text = "Tổng doanh thu: " + totalSales.ToString("N0") + " VNĐ";
                    }
                    else
                    {
                        // Handle the error as per your requirement
                    }
                }

            }
        }


        private void frmThongke_Load(object sender, EventArgs e)
        {
            DisplayProductQuantity();
            load();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
