namespace QuanLyKhachSan
{
    partial class CheckOut
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDanhSach = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabChiTiet = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtDatPhongID = new System.Windows.Forms.ToolStripTextBox();
            this.txtMaKH = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabelDatPhongID = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelMaKH = new System.Windows.Forms.ToolStripLabel();
            this.btnTaoHoaDon = new System.Windows.Forms.ToolStripButton();
            this.btnTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnDongTimKiem = new System.Windows.Forms.ToolStripButton();
            this.btnBoLoc = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.btnQuayLai = new System.Windows.Forms.ToolStripButton();
            this.cbbTrangThai = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabelTrangThai = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelKieuThanhToan = new System.Windows.Forms.ToolStripLabel();
            this.cbbKieuTT = new System.Windows.Forms.ToolStripComboBox();
            this.tabControl.SuspendLayout();
            this.tabDanhSach.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabChiTiet.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDanhSach);
            this.tabControl.Controls.Add(this.tabChiTiet);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(-1, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1146, 702);
            this.tabControl.TabIndex = 3;
            // 
            // tabDanhSach
            // 
            this.tabDanhSach.Controls.Add(this.toolStrip2);
            this.tabDanhSach.Controls.Add(this.groupBox2);
            this.tabDanhSach.Location = new System.Drawing.Point(4, 29);
            this.tabDanhSach.Name = "tabDanhSach";
            this.tabDanhSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanhSach.Size = new System.Drawing.Size(1138, 669);
            this.tabDanhSach.TabIndex = 0;
            this.tabDanhSach.Text = "Danh sách";
            this.tabDanhSach.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(6, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1129, 603);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa Đơn Tổng Hợp";
            // 
            // tabChiTiet
            // 
            this.tabChiTiet.Controls.Add(this.groupBox3);
            this.tabChiTiet.Controls.Add(this.toolStrip1);
            this.tabChiTiet.Location = new System.Drawing.Point(4, 29);
            this.tabChiTiet.Name = "tabChiTiet";
            this.tabChiTiet.Padding = new System.Windows.Forms.Padding(3);
            this.tabChiTiet.Size = new System.Drawing.Size(1138, 669);
            this.tabChiTiet.TabIndex = 1;
            this.tabChiTiet.Text = "Chi tiết";
            this.tabChiTiet.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(3, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1135, 606);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Hóa Đơn";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnSua,
            this.btnXoa,
            this.btnIn,
            this.btnQuayLai});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1132, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTaoHoaDon,
            this.toolStripLabelDatPhongID,
            this.txtDatPhongID,
            this.toolStripLabelMaKH,
            this.txtMaKH,
            this.btnTimKiem,
            this.btnDongTimKiem,
            this.btnBoLoc,
            this.toolStripLabelTrangThai,
            this.cbbTrangThai,
            this.toolStripLabelKieuThanhToan,
            this.cbbKieuTT});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1132, 54);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1117, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtDatPhongID
            // 
            this.txtDatPhongID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatPhongID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDatPhongID.Name = "txtDatPhongID";
            this.txtDatPhongID.Size = new System.Drawing.Size(100, 54);
            this.txtDatPhongID.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 54);
            // 
            // toolStripLabelDatPhongID
            // 
            this.toolStripLabelDatPhongID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelDatPhongID.Name = "toolStripLabelDatPhongID";
            this.toolStripLabelDatPhongID.Size = new System.Drawing.Size(81, 51);
            this.toolStripLabelDatPhongID.Text = "Đặt Phòng ID";
            // 
            // toolStripLabelMaKH
            // 
            this.toolStripLabelMaKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelMaKH.Name = "toolStripLabelMaKH";
            this.toolStripLabelMaKH.Size = new System.Drawing.Size(93, 51);
            this.toolStripLabelMaKH.Text = "Mã Khách Hàng";
            // 
            // btnTaoHoaDon
            // 
            this.btnTaoHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHoaDon.Image = global::QuanLyKhachSan.Properties.Resources.plus__1_;
            this.btnTaoHoaDon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTaoHoaDon.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.btnTaoHoaDon.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnTaoHoaDon.Name = "btnTaoHoaDon";
            this.btnTaoHoaDon.Size = new System.Drawing.Size(80, 51);
            this.btnTaoHoaDon.Text = "Tạo hóa đơn";
            this.btnTaoHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTaoHoaDon.Click += new System.EventHandler(this.btnTaoHoaDon_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::QuanLyKhachSan.Properties.Resources.search__1_;
            this.btnTimKiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(63, 51);
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnDongTimKiem
            // 
            this.btnDongTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongTimKiem.Image = global::QuanLyKhachSan.Properties.Resources.close;
            this.btnDongTimKiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDongTimKiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDongTimKiem.Name = "btnDongTimKiem";
            this.btnDongTimKiem.Size = new System.Drawing.Size(96, 51);
            this.btnDongTimKiem.Text = "Đóng Tìm kiếm";
            this.btnDongTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDongTimKiem.Click += new System.EventHandler(this.btnDongTimKiem_Click);
            // 
            // btnBoLoc
            // 
            this.btnBoLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoLoc.Image = global::QuanLyKhachSan.Properties.Resources.panel;
            this.btnBoLoc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBoLoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBoLoc.Name = "btnBoLoc";
            this.btnBoLoc.Size = new System.Drawing.Size(48, 51);
            this.btnBoLoc.Text = "Bộ Lọc";
            this.btnBoLoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBoLoc.Click += new System.EventHandler(this.btnBoLoc_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyKhachSan.Properties.Resources.plus__1_;
            this.btnThem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(43, 51);
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyKhachSan.Properties.Resources.pen;
            this.btnSua.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(36, 51);
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyKhachSan.Properties.Resources.delete;
            this.btnXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(36, 51);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = global::QuanLyKhachSan.Properties.Resources.print;
            this.btnIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIn.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(36, 51);
            this.btnIn.Text = "In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.Image = global::QuanLyKhachSan.Properties.Resources.undo;
            this.btnQuayLai.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnQuayLai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(54, 51);
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Chọn trạng thái",
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(121, 54);
            this.cbbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbbTrangThai_SelectedIndexChanged);
            // 
            // toolStripLabelTrangThai
            // 
            this.toolStripLabelTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelTrangThai.Name = "toolStripLabelTrangThai";
            this.toolStripLabelTrangThai.Size = new System.Drawing.Size(62, 51);
            this.toolStripLabelTrangThai.Text = "Trạng thái";
            // 
            // toolStripLabelKieuThanhToan
            // 
            this.toolStripLabelKieuThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelKieuThanhToan.Name = "toolStripLabelKieuThanhToan";
            this.toolStripLabelKieuThanhToan.Size = new System.Drawing.Size(95, 51);
            this.toolStripLabelKieuThanhToan.Text = "Kiểu thanh toán";
            // 
            // cbbKieuTT
            // 
            this.cbbKieuTT.DropDownWidth = 121;
            this.cbbKieuTT.Items.AddRange(new object[] {
            "Chọn kiểu thanh toán",
            "Ví điện tử",
            "Chuyển Khoản",
            "Tiền Mặt",
            "Thẻ"});
            this.cbbKieuTT.Name = "cbbKieuTT";
            this.cbbKieuTT.Size = new System.Drawing.Size(150, 54);
            this.cbbKieuTT.SelectedIndexChanged += new System.EventHandler(this.cbbKieuTT_SelectedIndexChanged);
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 701);
            this.Controls.Add(this.tabControl);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.tabControl.ResumeLayout(false);
            this.tabDanhSach.ResumeLayout(false);
            this.tabDanhSach.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabChiTiet.ResumeLayout(false);
            this.tabChiTiet.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDanhSach;
        private System.Windows.Forms.TabPage tabChiTiet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnIn;
        private System.Windows.Forms.ToolStripButton btnQuayLai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnTaoHoaDon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton btnTimKiem;
        private System.Windows.Forms.ToolStripTextBox txtDatPhongID;
        private System.Windows.Forms.ToolStripLabel toolStripLabelDatPhongID;
        private System.Windows.Forms.ToolStripTextBox txtMaKH;
        private System.Windows.Forms.ToolStripLabel toolStripLabelMaKH;
        private System.Windows.Forms.ToolStripButton btnDongTimKiem;
        private System.Windows.Forms.ToolStripButton btnBoLoc;
        private System.Windows.Forms.ToolStripComboBox cbbTrangThai;
        private System.Windows.Forms.ToolStripLabel toolStripLabelTrangThai;
        private System.Windows.Forms.ToolStripLabel toolStripLabelKieuThanhToan;
        private System.Windows.Forms.ToolStripComboBox cbbKieuTT;
    }
}