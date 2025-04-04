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
            this.tabChiTiet = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnIn = new System.Windows.Forms.ToolStripButton();
            this.btnQuayLai = new System.Windows.Forms.ToolStripButton();
            this.tabControl.SuspendLayout();
            this.tabChiTiet.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.tabControl.Size = new System.Drawing.Size(760, 450);
            this.tabControl.TabIndex = 3;
            // 
            // tabDanhSach
            // 
            this.tabDanhSach.Location = new System.Drawing.Point(4, 29);
            this.tabDanhSach.Name = "tabDanhSach";
            this.tabDanhSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabDanhSach.Size = new System.Drawing.Size(752, 417);
            this.tabDanhSach.TabIndex = 0;
            this.tabDanhSach.Text = "Danh sách";
            this.tabDanhSach.UseVisualStyleBackColor = true;
            // 
            // tabChiTiet
            // 
            this.tabChiTiet.Controls.Add(this.toolStrip1);
            this.tabChiTiet.Location = new System.Drawing.Point(4, 29);
            this.tabChiTiet.Name = "tabChiTiet";
            this.tabChiTiet.Padding = new System.Windows.Forms.Padding(3);
            this.tabChiTiet.Size = new System.Drawing.Size(752, 417);
            this.tabChiTiet.TabIndex = 1;
            this.tabChiTiet.Text = "Chi tiết";
            this.tabChiTiet.UseVisualStyleBackColor = true;
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
            this.toolStrip1.Size = new System.Drawing.Size(746, 54);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 451);
            this.Controls.Add(this.tabControl);
            this.Name = "CheckOut";
            this.Text = "CheckOut";
            this.Load += new System.EventHandler(this.CheckOut_Load);
            this.tabControl.ResumeLayout(false);
            this.tabChiTiet.ResumeLayout(false);
            this.tabChiTiet.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
    }
}