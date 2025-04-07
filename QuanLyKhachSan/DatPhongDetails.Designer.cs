namespace QuanLyKhachSan
{
    partial class DatPhongDetails
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
            this.lblSoPhong = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblLoaiPhong = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.cbbkhachang = new System.Windows.Forms.ComboBox();
            this.cbbnhanvien = new System.Windows.Forms.ComboBox();
            this.ngayden = new System.Windows.Forms.DateTimePicker();
            this.ngaydi = new System.Windows.Forms.DateTimePicker();
            this.btndatphong = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoPhong
            // 
            this.lblSoPhong.AutoSize = true;
            this.lblSoPhong.Location = new System.Drawing.Point(49, 36);
            this.lblSoPhong.Name = "lblSoPhong";
            this.lblSoPhong.Size = new System.Drawing.Size(66, 16);
            this.lblSoPhong.TabIndex = 0;
            this.lblSoPhong.Text = "Số Phòng";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(49, 145);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(28, 16);
            this.lblGia.TabIndex = 1;
            this.lblGia.Text = "Giá";
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.AutoSize = true;
            this.lblLoaiPhong.Location = new System.Drawing.Point(49, 97);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(75, 16);
            this.lblLoaiPhong.TabIndex = 2;
            this.lblLoaiPhong.Text = "Loại Phòng";
            // 
            // cbbkhachang
            // 
            this.cbbkhachang.FormattingEnabled = true;
            this.cbbkhachang.Location = new System.Drawing.Point(86, 195);
            this.cbbkhachang.Name = "cbbkhachang";
            this.cbbkhachang.Size = new System.Drawing.Size(121, 24);
            this.cbbkhachang.TabIndex = 3;
            // 
            // cbbnhanvien
            // 
            this.cbbnhanvien.FormattingEnabled = true;
            this.cbbnhanvien.Location = new System.Drawing.Point(86, 323);
            this.cbbnhanvien.Name = "cbbnhanvien";
            this.cbbnhanvien.Size = new System.Drawing.Size(121, 24);
            this.cbbnhanvien.TabIndex = 4;
            // 
            // ngayden
            // 
            this.ngayden.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayden.Location = new System.Drawing.Point(86, 242);
            this.ngayden.Name = "ngayden";
            this.ngayden.Size = new System.Drawing.Size(200, 22);
            this.ngayden.TabIndex = 5;
            // 
            // ngaydi
            // 
            this.ngaydi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaydi.Location = new System.Drawing.Point(86, 282);
            this.ngaydi.Name = "ngaydi";
            this.ngaydi.Size = new System.Drawing.Size(200, 22);
            this.ngaydi.TabIndex = 6;
            // 
            // btndatphong
            // 
            this.btndatphong.Location = new System.Drawing.Point(86, 395);
            this.btndatphong.Name = "btndatphong";
            this.btndatphong.Size = new System.Drawing.Size(75, 23);
            this.btndatphong.TabIndex = 7;
            this.btndatphong.Text = "Đặt Phòng";
            this.btndatphong.UseVisualStyleBackColor = true;
            this.btndatphong.Click += new System.EventHandler(this.btndatphong_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(211, 395);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "Hủy";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // DatPhongDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndatphong);
            this.Controls.Add(this.ngaydi);
            this.Controls.Add(this.ngayden);
            this.Controls.Add(this.cbbnhanvien);
            this.Controls.Add(this.cbbkhachang);
            this.Controls.Add(this.lblLoaiPhong);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblSoPhong);
            this.Name = "DatPhongDetails";
            this.Text = "DatPhongDetails";
            this.Load += new System.EventHandler(this.DatPhongDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoPhong;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblLoaiPhong;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox cbbkhachang;
        private System.Windows.Forms.ComboBox cbbnhanvien;
        private System.Windows.Forms.DateTimePicker ngayden;
        private System.Windows.Forms.DateTimePicker ngaydi;
        private System.Windows.Forms.Button btndatphong;
        private System.Windows.Forms.Button btncancel;
    }
}