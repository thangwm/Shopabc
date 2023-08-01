namespace manager
{
    partial class frmShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShop));
            this.xoa = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtGia = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.All = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabAo = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabQuan = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabGiay = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.All.SuspendLayout();
            this.tabAo.SuspendLayout();
            this.tabQuan.SuspendLayout();
            this.tabGiay.SuspendLayout();
            this.SuspendLayout();
            // 
            // xoa
            // 
            this.xoa.Location = new System.Drawing.Point(404, 403);
            this.xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(54, 45);
            this.xoa.TabIndex = 3;
            this.xoa.Text = "Xóa";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 403);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "In Bill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(669, 403);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(135, 45);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(404, 30);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 370);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng";
            this.columnHeader4.Width = 84;
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.SystemColors.Control;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtGia.Location = new System.Drawing.Point(532, 403);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(132, 46);
            this.txtGia.TabIndex = 1;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGia.TextChanged += new System.EventHandler(this.txtGia_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.All);
            this.tabControl1.Controls.Add(this.tabAo);
            this.tabControl1.Controls.Add(this.tabQuan);
            this.tabControl1.Controls.Add(this.tabGiay);
            this.tabControl1.Location = new System.Drawing.Point(12, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(388, 442);
            this.tabControl1.TabIndex = 7;
            // 
            // All
            // 
            this.All.Controls.Add(this.flowLayoutPanel1);
            this.All.Location = new System.Drawing.Point(4, 25);
            this.All.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.All.Name = "All";
            this.All.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.All.Size = new System.Drawing.Size(380, 413);
            this.All.TabIndex = 0;
            this.All.Text = "All";
            this.All.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 5);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(379, 408);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabAo
            // 
            this.tabAo.Controls.Add(this.flowLayoutPanel2);
            this.tabAo.Location = new System.Drawing.Point(4, 25);
            this.tabAo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAo.Name = "tabAo";
            this.tabAo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAo.Size = new System.Drawing.Size(380, 413);
            this.tabAo.TabIndex = 1;
            this.tabAo.Text = "Áo";
            this.tabAo.UseVisualStyleBackColor = true;
            this.tabAo.Click += new System.EventHandler(this.tabAo_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(381, 415);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // tabQuan
            // 
            this.tabQuan.Controls.Add(this.flowLayoutPanel3);
            this.tabQuan.Location = new System.Drawing.Point(4, 25);
            this.tabQuan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabQuan.Name = "tabQuan";
            this.tabQuan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabQuan.Size = new System.Drawing.Size(380, 413);
            this.tabQuan.TabIndex = 2;
            this.tabQuan.Text = "Quần";
            this.tabQuan.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(379, 415);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // tabGiay
            // 
            this.tabGiay.Controls.Add(this.flowLayoutPanel4);
            this.tabGiay.Location = new System.Drawing.Point(4, 25);
            this.tabGiay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGiay.Name = "tabGiay";
            this.tabGiay.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabGiay.Size = new System.Drawing.Size(380, 413);
            this.tabGiay.TabIndex = 3;
            this.tabGiay.Text = "Giày";
            this.tabGiay.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(381, 415);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 483);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.txtGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmShop";
            this.Text = "frmShop";
            this.Load += new System.EventHandler(this.frmShop_Load);
            this.tabControl1.ResumeLayout(false);
            this.All.ResumeLayout(false);
            this.tabAo.ResumeLayout(false);
            this.tabQuan.ResumeLayout(false);
            this.tabGiay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button xoa;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage All;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tabAo;
        private System.Windows.Forms.TabPage tabQuan;
        private System.Windows.Forms.TabPage tabGiay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
    }
}