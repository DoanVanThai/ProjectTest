namespace QuanLyKhachSan
{
    partial class QuanLyPhong
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.tablePhong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxuat = new System.Windows.Forms.Button();
            this.btnnhap = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timkiemtheoloaiphong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.cbbtimkiemtinhtrang = new System.Windows.Forms.ComboBox();
            this.ccbtimkiemtang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timkiemtheotang = new System.Windows.Forms.Label();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.btnchangeview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePhong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tablePhong
            // 
            this.tablePhong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tablePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablePhong.Location = new System.Drawing.Point(53, 204);
            this.tablePhong.Name = "tablePhong";
            this.tablePhong.RowTemplate.Height = 24;
            this.tablePhong.Size = new System.Drawing.Size(1284, 382);
            this.tablePhong.TabIndex = 0;
            this.tablePhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnchangeview);
            this.groupBox1.Controls.Add(this.btnxuat);
            this.groupBox1.Controls.Add(this.btnnhap);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Location = new System.Drawing.Point(53, 614);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1284, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác Vụ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnxuat
            // 
            this.btnxuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnxuat.Location = new System.Drawing.Point(666, 31);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(75, 36);
            this.btnxuat.TabIndex = 4;
            this.btnxuat.Text = "Xuất";
            this.btnxuat.UseVisualStyleBackColor = false;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btnnhap
            // 
            this.btnnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnnhap.Location = new System.Drawing.Point(531, 31);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(75, 37);
            this.btnnhap.TabIndex = 3;
            this.btnnhap.Text = "Nhập";
            this.btnnhap.UseVisualStyleBackColor = false;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Red;
            this.btnxoa.Location = new System.Drawing.Point(361, 31);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 36);
            this.btnxoa.TabIndex = 2;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.Yellow;
            this.btnsua.Location = new System.Drawing.Point(201, 31);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 37);
            this.btnsua.TabIndex = 1;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.Lime;
            this.btnthem.Location = new System.Drawing.Point(58, 31);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 37);
            this.btnthem.TabIndex = 0;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.timkiemtheoloaiphong);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Controls.Add(this.btnreset);
            this.groupBox2.Controls.Add(this.cbbtimkiemtinhtrang);
            this.groupBox2.Controls.Add(this.ccbtimkiemtang);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.timkiemtheotang);
            this.groupBox2.Controls.Add(this.btntimkiem);
            this.groupBox2.Location = new System.Drawing.Point(53, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1284, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tìm Bất Kỳ";
            // 
            // timkiemtheoloaiphong
            // 
            this.timkiemtheoloaiphong.FormattingEnabled = true;
            this.timkiemtheoloaiphong.Location = new System.Drawing.Point(485, 10);
            this.timkiemtheoloaiphong.Name = "timkiemtheoloaiphong";
            this.timkiemtheoloaiphong.Size = new System.Drawing.Size(121, 24);
            this.timkiemtheoloaiphong.TabIndex = 8;
            this.timkiemtheoloaiphong.SelectedIndexChanged += new System.EventHandler(this.timkiemtheoloaiphong_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Loại Phòng";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(485, 61);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(473, 22);
            this.txttimkiem.TabIndex = 6;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(1148, 64);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 23);
            this.btnreset.TabIndex = 5;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // cbbtimkiemtinhtrang
            // 
            this.cbbtimkiemtinhtrang.FormattingEnabled = true;
            this.cbbtimkiemtinhtrang.Location = new System.Drawing.Point(201, 57);
            this.cbbtimkiemtinhtrang.Name = "cbbtimkiemtinhtrang";
            this.cbbtimkiemtinhtrang.Size = new System.Drawing.Size(121, 24);
            this.cbbtimkiemtinhtrang.TabIndex = 4;
            this.cbbtimkiemtinhtrang.SelectedIndexChanged += new System.EventHandler(this.cbbtimkiemtinhtrang_SelectedIndexChanged);
            // 
            // ccbtimkiemtang
            // 
            this.ccbtimkiemtang.FormattingEnabled = true;
            this.ccbtimkiemtang.Location = new System.Drawing.Point(201, 10);
            this.ccbtimkiemtang.Name = "ccbtimkiemtang";
            this.ccbtimkiemtang.Size = new System.Drawing.Size(121, 24);
            this.ccbtimkiemtang.TabIndex = 3;
            this.ccbtimkiemtang.SelectedIndexChanged += new System.EventHandler(this.ccbtimkiemtang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm theo tình trạng";
            // 
            // timkiemtheotang
            // 
            this.timkiemtheotang.AutoSize = true;
            this.timkiemtheotang.Location = new System.Drawing.Point(55, 18);
            this.timkiemtheotang.Name = "timkiemtheotang";
            this.timkiemtheotang.Size = new System.Drawing.Size(88, 16);
            this.timkiemtheotang.TabIndex = 1;
            this.timkiemtheotang.Text = "Tìm theo tầng";
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.Lime;
            this.btntimkiem.Location = new System.Drawing.Point(1148, 18);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(136, 26);
            this.btntimkiem.TabIndex = 0;
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // btnchangeview
            // 
            this.btnchangeview.Location = new System.Drawing.Point(819, 31);
            this.btnchangeview.Name = "btnchangeview";
            this.btnchangeview.Size = new System.Drawing.Size(115, 35);
            this.btnchangeview.TabIndex = 5;
            this.btnchangeview.Text = "ChangeView";
            this.btnchangeview.UseVisualStyleBackColor = true;
            this.btnchangeview.Click += new System.EventHandler(this.btnchangeview_Click);
            // 
            // QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 806);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tablePhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuanLyPhong";
            this.Text = "QuanLyPhong";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePhong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView tablePhong;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timkiemtheotang;
        private System.Windows.Forms.ComboBox cbbtimkiemtinhtrang;
        private System.Windows.Forms.ComboBox ccbtimkiemtang;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.ComboBox timkiemtheoloaiphong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnxuat;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.Button btnchangeview;
    }
}