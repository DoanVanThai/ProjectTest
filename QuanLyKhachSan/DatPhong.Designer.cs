namespace QuanLyKhachSan
{
    partial class DatPhong
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
<<<<<<< HEAD
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
=======
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.flpDanhSachPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.timkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbtimkiemtinhtrang = new System.Windows.Forms.ComboBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
>>>>>>> 6fa0bc3 (Lưu lại để pull)
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
<<<<<<< HEAD
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "dat phong";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(819, 515);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "dat phong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(827, 523);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "dat phong";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(835, 531);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "dat phong";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(843, 539);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "dat phong";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(590, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
=======
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // flpDanhSachPhong
            // 
            this.flpDanhSachPhong.AutoScroll = true;
            this.flpDanhSachPhong.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpDanhSachPhong.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpDanhSachPhong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flpDanhSachPhong.Location = new System.Drawing.Point(0, 0);
            this.flpDanhSachPhong.Name = "flpDanhSachPhong";
            this.flpDanhSachPhong.Size = new System.Drawing.Size(1228, 840);
            this.flpDanhSachPhong.TabIndex = 0;
            this.flpDanhSachPhong.Paint += new System.Windows.Forms.PaintEventHandler(this.flpDanhSachPhong_Paint);
            // 
            // timkiem
            // 
            this.timkiem.BackColor = System.Drawing.Color.Lime;
            this.timkiem.Location = new System.Drawing.Point(68, 234);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(75, 39);
            this.timkiem.TabIndex = 1;
            this.timkiem.Text = "Tìm Kiếm";
            this.timkiem.UseVisualStyleBackColor = false;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(6, 66);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(188, 22);
            this.txttimkiem.TabIndex = 2;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.btnreset);
            this.groupBox1.Controls.Add(this.cbbtimkiemtinhtrang);
            this.groupBox1.Controls.Add(this.timkiem);
            this.groupBox1.Controls.Add(this.txttimkiem);
            this.groupBox1.Location = new System.Drawing.Point(1275, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 350);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Phòng";
            // 
            // cbbtimkiemtinhtrang
            // 
            this.cbbtimkiemtinhtrang.FormattingEnabled = true;
            this.cbbtimkiemtinhtrang.Location = new System.Drawing.Point(6, 169);
            this.cbbtimkiemtinhtrang.Name = "cbbtimkiemtinhtrang";
            this.cbbtimkiemtinhtrang.Size = new System.Drawing.Size(188, 24);
            this.cbbtimkiemtinhtrang.TabIndex = 3;
            this.cbbtimkiemtinhtrang.SelectedIndexChanged += new System.EventHandler(this.cbbtimkiemtinhtrang_SelectedIndexChanged);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.Red;
            this.btnreset.Location = new System.Drawing.Point(68, 299);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 32);
            this.btnreset.TabIndex = 4;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
>>>>>>> 6fa0bc3 (Lưu lại để pull)
            // 
            // DatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1719, 1050);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
=======
            this.ClientSize = new System.Drawing.Size(1528, 840);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flpDanhSachPhong);
            this.Margin = new System.Windows.Forms.Padding(4);
>>>>>>> 6fa0bc3 (Lưu lại để pull)
            this.Name = "DatPhong";
            this.Text = "DatPhong";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
=======
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.FlowLayoutPanel flpDanhSachPhong;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbtimkiemtinhtrang;
        private System.Windows.Forms.Button btnreset;
>>>>>>> 6fa0bc3 (Lưu lại để pull)
    }
}