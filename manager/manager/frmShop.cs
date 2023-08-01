using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace manager
{
    public partial class frmShop : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-THANGWM\\SQLEXPRESS;Initial Catalog=shopabc;Integrated Security=True";
        private readonly List<MonTemp> selectedProducts = new List<MonTemp>();

        public frmShop()
        {
            InitializeComponent();
        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT HinhAnh FROM hang";
                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        byte[] imageData = (byte[])reader["HinhAnh"];
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Image = Image.FromStream(new MemoryStream(imageData));
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Width = 80;
                        pictureBox.Height = 80;
                        pictureBox.Margin = new Padding(3);
                        pictureBox.Click += PictureBox_Click;
                        //
                        flowLayoutPanel1.Controls.Add(pictureBox);
                        lblTotalPrice.Text = "Total price: 0";
                        lblTotalPrice.AutoSize = true;
                        lblTotalPrice.Location = new Point(10, 120);
                        Controls.Add(lblTotalPrice);

                    }
                }


            }
            loadAo();
            loadQuan();
            loadGiay();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                PictureBox pictureBox = (PictureBox)sender;
                byte[] imageData = (byte[])new ImageConverter().ConvertTo(pictureBox.Image, typeof(byte[]));
                string query = "SELECT MaMon, TenMon, Gia FROM hang WHERE HinhAnh = @HinhAnh";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HinhAnh", imageData);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int productId = reader.GetInt32(0);
                            string productName = reader.GetString(1);
                            int price = reader.GetInt32(2);

                            // Check if the product has already been selected
                            var selectedProduct = selectedProducts.FirstOrDefault(p => p.TenMon == productName);
                            if (selectedProduct != null)
                            {
                                // If the product has already been selected, increase the quantity by 1
                                selectedProduct.soLuong++;
                                UpdateSelectedProduct(selectedProduct);
                            }
                            else
                            {
                                // If the product has not been selected yet, add it to the list with quantity of 1
                                var product = new MonTemp
                                {
                                    MaMon = productId,
                                    TenMon = productName,
                                    Gia = price,
                                    soLuong = 1
                                };
                                selectedProducts.Add(product);
                                AddSelectedProductToListView(product);
                            }

                            UpdateTotalPrice();
                            xoa.Click += xoa_Click;
                        }
                    }
                }
            }
        }
        private void loadAo()
        {


            // Kết nối đến cơ sở dữ liệu
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Truy vấn để lấy thông tin món hàng và hình ảnh tương ứng
            int id_mon = 1; // Giả sử cần lấy thông tin của món hàng có id_mon = 1
            string query = "SELECT TenMon, Gia, HinhAnh FROM Hang WHERE IDloaihang = " + id_mon;
            SqlCommand command = new SqlCommand(query, connection);

            // Thực thi truy vấn và đọc kết quả trả về
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string tenMon = reader.GetString(0);
                int gia = reader.GetInt32(1);
                byte[] hinhAnhBytes = (byte[])reader.GetValue(2);

                // Chuyển đổi mảng byte thành đối tượng hình ảnh
                MemoryStream ms = new MemoryStream(hinhAnhBytes);
                Image hinhAnh = Image.FromStream(ms);

                // Tạo đối tượng PictureBox và thêm vào FlowLayoutPanel

                byte[] imageData = (byte[])reader["HinhAnh"];
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromStream(new MemoryStream(imageData));
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 80;
                pictureBox.Height = 80;
                pictureBox.Margin = new Padding(3);
                pictureBox.Click += PictureBox_Click;
                //
                flowLayoutPanel2.Controls.Add(pictureBox);
            }

            // Đóng kết nối
            reader.Close();
            connection.Close();

        }
        private void loadQuan()
        {


            // Kết nối đến cơ sở dữ liệu
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Truy vấn để lấy thông tin món hàng và hình ảnh tương ứng
            int id_mon = 2; // Giả sử cần lấy thông tin của món hàng có id_mon = 1
            string query = "SELECT TenMon, Gia, HinhAnh FROM hang WHERE  IDloaihang = " + id_mon;
            SqlCommand command = new SqlCommand(query, connection);

            // Thực thi truy vấn và đọc kết quả trả về
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string tenMon = reader.GetString(0);
                int gia = reader.GetInt32(1);
                byte[] hinhAnhBytes = (byte[])reader.GetValue(2);

                // Chuyển đổi mảng byte thành đối tượng hình ảnh
                MemoryStream ms = new MemoryStream(hinhAnhBytes);
                Image hinhAnh = Image.FromStream(ms);

                // Tạo đối tượng PictureBox và thêm vào FlowLayoutPanel
                byte[] imageData = (byte[])reader["HinhAnh"];
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromStream(new MemoryStream(imageData));
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 80;
                pictureBox.Height = 80;
                pictureBox.Margin = new Padding(3);
                pictureBox.Click += PictureBox_Click;
                //
                flowLayoutPanel3.Controls.Add(pictureBox);
            }

            // Đóng kết nối
            reader.Close();
            connection.Close();

        }
        private void loadGiay()
        {


            // Kết nối đến cơ sở dữ liệu
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // Truy vấn để lấy thông tin món hàng và hình ảnh tương ứng
            int id_mon = 3; // Giả sử cần lấy thông tin của món hàng có id_mon = 1
            string query = "SELECT TenMon, Gia, HinhAnh FROM hang WHERE IDloaihang = " + id_mon;
            SqlCommand command = new SqlCommand(query, connection);

            // Thực thi truy vấn và đọc kết quả trả về
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string tenMon = reader.GetString(0);
                int gia = reader.GetInt32(1);
                byte[] hinhAnhBytes = (byte[])reader.GetValue(2);

                // Chuyển đổi mảng byte thành đối tượng hình ảnh
                MemoryStream ms = new MemoryStream(hinhAnhBytes);
                Image hinhAnh = Image.FromStream(ms);

                // Tạo đối tượng PictureBox và thêm vào FlowLayoutPanel
                byte[] imageData = (byte[])reader["HinhAnh"];
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromStream(new MemoryStream(imageData));
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Width = 80;
                pictureBox.Height = 80;
                pictureBox.Margin = new Padding(3);
                pictureBox.Click += PictureBox_Click;
                //
                flowLayoutPanel4.Controls.Add(pictureBox);
            }

            // Đóng kết nối
            reader.Close();
            connection.Close();

        }
        private void AddSelectedProductToListView(MonTemp product)
        {
            ListViewItem item = new ListViewItem(product.MaMon.ToString());
            item.SubItems.Add(product.TenMon.ToString());
            item.SubItems.Add(product.Gia.ToString());
            item.SubItems.Add(product.soLuong.ToString());
            listView1.Items.Add(item);
        }
        private void UpdateSelectedProduct(MonTemp product)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Text == product.MaMon.ToString())
                {
                    item.SubItems[3].Text = product.soLuong.ToString();
                    break;
                }
            }
        }
        class MonTemp
        {
            public int MaMon { get; set; }
            public string TenMon { get; set; }
            public int Gia { get; set; }
            public int soLuong { get; set; }
        }
        private readonly Label lblTotalPrice = new Label();
        private int CalculateTotalPrice()
        {
            int totalPrice = 0;
            foreach (var product in selectedProducts)
            {
                totalPrice += product.Gia * product.soLuong;
            }
            return totalPrice;
        }
        private void UpdateTotalPrice()
        {
            int totalPrice = CalculateTotalPrice();
            lblTotalPrice.Text = "Total price: " + totalPrice.ToString("N0") + " VNĐ";
            txtGia.Text = totalPrice.ToString("N0") + " VNĐ";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UpdateTotalPrice();
        }

        private void xoa_Click(object sender, EventArgs e)
        {
        
                if (listView1.SelectedItems.Count > 0)
                {
                    // Lấy dòng đang được chọn
                    ListViewItem selectedItem = listView1.SelectedItems[0];
                    // Lấy tên món
                    string productId = selectedItem.SubItems[0].Text;
                    // Tìm kiếm món trong danh sách đã chọn
                    var selectedProduct = selectedProducts.FirstOrDefault(p => p.MaMon.ToString() == productId);
                    if (selectedProduct != null)
                    {
                        // Nếu tìm thấy, xóa khỏi danh sách đã chọn
                        selectedProducts.Remove(selectedProduct);
                        // Xóa khỏi ListView
                        listView1.Items.Remove(selectedItem);
                        // Cập nhật lại giá tiền
                        UpdateTotalPrice();
                    }
             
            }
           
        }
        private PrintDocument printDocument = new PrintDocument();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
       

        }
        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        { // Set the font and the brush to be used for drawing the text
            {
                Font titleFont = new Font("Arial", 16, FontStyle.Bold);
                Font headerFont = new Font("Arial", 12, FontStyle.Bold);
                Font contentFont = new Font("Arial", 12, FontStyle.Regular);
                SolidBrush brush = new SolidBrush(Color.Black);

                // Define the margins and offsets
                float startX = e.MarginBounds.Left;
                float startY = e.MarginBounds.Top;
                float offset = 20;
                float rightMargin = e.MarginBounds.Right;
                float leftMargin = e.MarginBounds.Left;

                // Create a rectangle to define the bounds of the text
                RectangleF rect = new RectangleF(leftMargin, startY, e.MarginBounds.Width, e.MarginBounds.Height);

                // Draw the title of the bill
                string title = "SHOP BILL";
                SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
                float titleX = (e.PageBounds.Width - titleSize.Width) / 2;
                e.Graphics.DrawString(title, titleFont, brush, titleX, 50);

                // Draw the header of the bill
                float headerY = startY + titleSize.Height + offset;
                e.Graphics.DrawString("Tên món", headerFont, brush, leftMargin, headerY);
                e.Graphics.DrawString("Số lượng", headerFont, brush, rightMargin - 150, headerY);
                e.Graphics.DrawString("Giá", headerFont, brush, rightMargin - 10, headerY);

                // Draw the details of the selected products
                float contentY = headerY + offset;
                foreach (var product in selectedProducts)
                {
                    e.Graphics.DrawString(product.TenMon, contentFont, brush, leftMargin, contentY);
                    e.Graphics.DrawString(product.soLuong.ToString(), contentFont, brush, rightMargin - 120, contentY);
                    e.Graphics.DrawString(product.Gia.ToString("N0") + " VNĐ", contentFont, brush, rightMargin - 10, contentY);
                    contentY += offset;
                }

                // Draw the total price
                float totalPriceY = contentY + offset;
                e.Graphics.DrawString("Tổng tiền:", headerFont, brush, rightMargin - 150, totalPriceY);
                e.Graphics.DrawString(CalculateTotalPrice().ToString("N0") + " VNĐ", contentFont, brush, rightMargin - 10, totalPriceY);

                // Draw the time and date
                float timeY = totalPriceY + offset;
                string timeString = "Thời gian: " + DateTime.Now.ToString();
                e.Graphics.DrawString(timeString, contentFont, brush, rightMargin - 200, timeY - 240);

                // Draw a line to separate the content from the footer
                float lineY = e.MarginBounds.Bottom - 550;
                e.Graphics.DrawLine(new Pen(Color.Black), leftMargin, lineY, rightMargin, lineY);

                // Draw the footer of the bill
                float footerY = lineY + offset;
                e.Graphics.DrawString("Cảm ơn quý khách!", headerFont, brush, leftMargin, footerY);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);

            // Set the printer settings to the default printer
            printDocument1.PrinterSettings = new PrinterSettings();

            // Show the print preview dialog
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thanh toán tổng tiền "+txtGia.Text+" không?", "Xác nhận thanh toán", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string connectionString = "Data Source=DESKTOP-THANGWM\\SQLEXPRESS;Initial Catalog=shopabc;Integrated Security=True"; // Thay đổi connection string tương ứng với database của bạn
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO order_item (item_id, MaHD, quantity, total_price, order_date) VALUES (@item_id, @MaHD, @quantity, @total_price, @order_date)", connection);

                    foreach (ListViewItem item in listView1.Items)
                    {
                        int maMon = Convert.ToInt32(item.SubItems[0].Text);
                        string tenMon = item.SubItems[1].Text;
                        int gia = Convert.ToInt32(item.SubItems[2].Text);
                        int soLuong = Convert.ToInt32(item.SubItems[3].Text);
                        int thanhTien = gia * soLuong;

                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@item_id", maMon);
                        command.Parameters.AddWithValue("@MaHD", DBNull.Value);
                        command.Parameters.AddWithValue("@quantity", soLuong);
                        command.Parameters.AddWithValue("@total_price", thanhTien);
                        command.Parameters.AddWithValue("@order_date", DateTime.Now);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Thanh toán thành công!");
                            selectedProducts.Clear();
                            listView1.Items.Clear();
                            lblTotalPrice.Text = "Total price: 0";
                            txtGia.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Thanh toán thất bại!");
                        }
                    }  
                }
            }

        }

        private void tabAo_Click(object sender, EventArgs e)
        {

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

