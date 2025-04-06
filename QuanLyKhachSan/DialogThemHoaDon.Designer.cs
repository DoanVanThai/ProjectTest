namespace QuanLyKhachSan
{
    partial class DialogThemHoaDon
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_FormThemHoaDon = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnTimKiem_FormThemHoaDon = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtDatPhongID_FormThemHoaDon = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTienDichVu_FormThemHoaDon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoLuongDichVu_FormThemHoaDon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTienPhong_FormThemHoaDon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoNgayO_FormThemHoaDon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonGia_FormThemHoaDon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNgayDi_FormThemHoaDon = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayDen_FormThemHoaDon = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayLap_FormThemHoaDon = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhongID_FormThemHoaDon = new System.Windows.Forms.TextBox();
            this.btnXacNhan_FormThemHoaDon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FormThemHoaDon)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_FormThemHoaDon);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 151);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch Vụ Sử Dụng";
            // 
            // dataGridView_FormThemHoaDon
            // 
            this.dataGridView_FormThemHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_FormThemHoaDon.Location = new System.Drawing.Point(5, 19);
            this.dataGridView_FormThemHoaDon.Name = "dataGridView_FormThemHoaDon";
            this.dataGridView_FormThemHoaDon.Size = new System.Drawing.Size(552, 126);
            this.dataGridView_FormThemHoaDon.TabIndex = 0;
            this.dataGridView_FormThemHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_FormThemHoaDon_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtDatPhongID_FormThemHoaDon,
            this.btnTimKiem_FormThemHoaDon});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(666, 54);
            this.toolStrip1.TabIndex = 21;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnTimKiem_FormThemHoaDon
            // 
            this.btnTimKiem_FormThemHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem_FormThemHoaDon.Image = global::QuanLyKhachSan.Properties.Resources.search__1_;
            this.btnTimKiem_FormThemHoaDon.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTimKiem_FormThemHoaDon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTimKiem_FormThemHoaDon.Name = "btnTimKiem_FormThemHoaDon";
            this.btnTimKiem_FormThemHoaDon.Size = new System.Drawing.Size(63, 51);
            this.btnTimKiem_FormThemHoaDon.Text = "Tìm kiếm";
            this.btnTimKiem_FormThemHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTimKiem_FormThemHoaDon.Click += new System.EventHandler(this.btnTimKiem_FormThemHoaDon_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(81, 51);
            this.toolStripLabel1.Text = "Đặt Phòng ID";
            // 
            // txtDatPhongID_FormThemHoaDon
            // 
            this.txtDatPhongID_FormThemHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDatPhongID_FormThemHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDatPhongID_FormThemHoaDon.Name = "txtDatPhongID_FormThemHoaDon";
            this.txtDatPhongID_FormThemHoaDon.Size = new System.Drawing.Size(100, 54);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTienDichVu_FormThemHoaDon);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtSoLuongDichVu_FormThemHoaDon);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTienPhong_FormThemHoaDon);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtSoNgayO_FormThemHoaDon);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtDonGia_FormThemHoaDon);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpNgayDi_FormThemHoaDon);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpNgayDen_FormThemHoaDon);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtpNgayLap_FormThemHoaDon);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPhongID_FormThemHoaDon);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 335);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Form Hóa Đơn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(329, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Tiền Dịch Vụ";
            // 
            // txtTienDichVu_FormThemHoaDon
            // 
            this.txtTienDichVu_FormThemHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienDichVu_FormThemHoaDon.Location = new System.Drawing.Point(332, 298);
            this.txtTienDichVu_FormThemHoaDon.Name = "txtTienDichVu_FormThemHoaDon";
            this.txtTienDichVu_FormThemHoaDon.Size = new System.Drawing.Size(100, 22);
            this.txtTienDichVu_FormThemHoaDon.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Số lượng dịch vụ sử dụng :";
            // 
            // txtSoLuongDichVu_FormThemHoaDon
            // 
            this.txtSoLuongDichVu_FormThemHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLuongDichVu_FormThemHoaDon.Location = new System.Drawing.Point(19, 302);
            this.txtSoLuongDichVu_FormThemHoaDon.Name = "txtSoLuongDichVu_FormThemHoaDon";
            this.txtSoLuongDichVu_FormThemHoaDon.Size = new System.Drawing.Size(255, 22);
            this.txtSoLuongDichVu_FormThemHoaDon.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Tiền Phòng";
            // 
            // txtTienPhong_FormThemHoaDon
            // 
            this.txtTienPhong_FormThemHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienPhong_FormThemHoaDon.Location = new System.Drawing.Point(332, 231);
            this.txtTienPhong_FormThemHoaDon.Name = "txtTienPhong_FormThemHoaDon";
            this.txtTienPhong_FormThemHoaDon.Size = new System.Drawing.Size(100, 22);
            this.txtTienPhong_FormThemHoaDon.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Số ngày ở";
            // 
            // txtSoNgayO_FormThemHoaDon
            // 
            this.txtSoNgayO_FormThemHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoNgayO_FormThemHoaDon.Location = new System.Drawing.Point(174, 231);
            this.txtSoNgayO_FormThemHoaDon.Name = "txtSoNgayO_FormThemHoaDon";
            this.txtSoNgayO_FormThemHoaDon.Size = new System.Drawing.Size(100, 22);
            this.txtSoNgayO_FormThemHoaDon.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Đơn giá Phòng";
            // 
            // txtDonGia_FormThemHoaDon
            // 
            this.txtDonGia_FormThemHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDonGia_FormThemHoaDon.Location = new System.Drawing.Point(19, 231);
            this.txtDonGia_FormThemHoaDon.Name = "txtDonGia_FormThemHoaDon";
            this.txtDonGia_FormThemHoaDon.Size = new System.Drawing.Size(100, 22);
            this.txtDonGia_FormThemHoaDon.TabIndex = 28;
            this.txtDonGia_FormThemHoaDon.TextChanged += new System.EventHandler(this.txtDonGia_FormThemHoaDon_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ngày Đi";
            // 
            // dtpNgayDi_FormThemHoaDon
            // 
            this.dtpNgayDi_FormThemHoaDon.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDi_FormThemHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDi_FormThemHoaDon.Location = new System.Drawing.Point(317, 96);
            this.dtpNgayDi_FormThemHoaDon.Name = "dtpNgayDi_FormThemHoaDon";
            this.dtpNgayDi_FormThemHoaDon.Size = new System.Drawing.Size(116, 22);
            this.dtpNgayDi_FormThemHoaDon.TabIndex = 26;
            this.dtpNgayDi_FormThemHoaDon.ValueChanged += new System.EventHandler(this.dtpNgayDi_FormThemHoaDon_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ngày Đến";
            // 
            // dtpNgayDen_FormThemHoaDon
            // 
            this.dtpNgayDen_FormThemHoaDon.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayDen_FormThemHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDen_FormThemHoaDon.Location = new System.Drawing.Point(159, 96);
            this.dtpNgayDen_FormThemHoaDon.Name = "dtpNgayDen_FormThemHoaDon";
            this.dtpNgayDen_FormThemHoaDon.Size = new System.Drawing.Size(116, 22);
            this.dtpNgayDen_FormThemHoaDon.TabIndex = 24;
            this.dtpNgayDen_FormThemHoaDon.ValueChanged += new System.EventHandler(this.dtpNgayDen_FormThemHoaDon_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ngày Lập";
            // 
            // dtpNgayLap_FormThemHoaDon
            // 
            this.dtpNgayLap_FormThemHoaDon.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap_FormThemHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap_FormThemHoaDon.Location = new System.Drawing.Point(19, 96);
            this.dtpNgayLap_FormThemHoaDon.Name = "dtpNgayLap_FormThemHoaDon";
            this.dtpNgayLap_FormThemHoaDon.Size = new System.Drawing.Size(116, 22);
            this.dtpNgayLap_FormThemHoaDon.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Phòng ID :";
            // 
            // txtPhongID_FormThemHoaDon
            // 
            this.txtPhongID_FormThemHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhongID_FormThemHoaDon.Location = new System.Drawing.Point(93, 29);
            this.txtPhongID_FormThemHoaDon.Name = "txtPhongID_FormThemHoaDon";
            this.txtPhongID_FormThemHoaDon.Size = new System.Drawing.Size(100, 22);
            this.txtPhongID_FormThemHoaDon.TabIndex = 20;
            this.txtPhongID_FormThemHoaDon.TextChanged += new System.EventHandler(this.txtPhongID_FormThemHoaDon_TextChanged);
            // 
            // btnXacNhan_FormThemHoaDon
            // 
            this.btnXacNhan_FormThemHoaDon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan_FormThemHoaDon.Location = new System.Drawing.Point(495, 383);
            this.btnXacNhan_FormThemHoaDon.Name = "btnXacNhan_FormThemHoaDon";
            this.btnXacNhan_FormThemHoaDon.Size = new System.Drawing.Size(118, 23);
            this.btnXacNhan_FormThemHoaDon.TabIndex = 23;
            this.btnXacNhan_FormThemHoaDon.Text = "Xác nhận";
            this.btnXacNhan_FormThemHoaDon.UseVisualStyleBackColor = true;
            // 
            // DialogThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 589);
            this.Controls.Add(this.btnXacNhan_FormThemHoaDon);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DialogThemHoaDon";
            this.Text = "Thêm Hóa Đơn";
            this.Load += new System.EventHandler(this.DialogThemHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FormThemHoaDon)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView_FormThemHoaDon;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtDatPhongID_FormThemHoaDon;
        private System.Windows.Forms.ToolStripButton btnTimKiem_FormThemHoaDon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTienDichVu_FormThemHoaDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoLuongDichVu_FormThemHoaDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTienPhong_FormThemHoaDon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoNgayO_FormThemHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonGia_FormThemHoaDon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNgayDi_FormThemHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayDen_FormThemHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayLap_FormThemHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPhongID_FormThemHoaDon;
        private System.Windows.Forms.Button btnXacNhan_FormThemHoaDon;
    }
}