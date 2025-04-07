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
using xls = Microsoft.Office.Interop.Excel;
using els = Microsoft.Office.Interop.Excel;

namespace QuanLyKhachSan
{
    public partial class QuanLyNhanVien : Form
    {
        private DataGridViewTextBoxColumn Column1;
        private TextBox txt_file;
        private Button btn_upload;
        private ComboBox cbb_chucvu;
        private TextBox txt_luong;
        private Button btn_luu;
        private TextBox txt_timmanv;
        private Label label13;
        private DateTimePicker dt_ngayvaolam;
        private Label label12;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txt_cccd;
        private Label label10;
        private ComboBox cbb_gioitinh;
        private TextBox txt_sdt;
        private Label label9;
        private DateTimePicker dt_ngaysinh;
        private Label label8;
        private Label label7;
        private TextBox txt_email;
        private TextBox txt_hoten;
        private Label label4;
        private Label label5;
        private Label label1;
        private Panel panel1;
        private Button btn_themmoi;
        private Button button1;
        private Button btn_xuatfile;
        private Button btn_refesh;
        private Panel panel2;
        private Label label2;
        private Button btn_timkiem;
        private Label label11;
        private ComboBox cbb_timchucvu;
        private DataGridView tble_nhanvien;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private Label label14;
        private OpenFileDialog openFileDialog1;

        public QuanLyNhanVien()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.cbb_chucvu = new System.Windows.Forms.ComboBox();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.txt_timmanv = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dt_ngayvaolam = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cccd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_gioitinh = new System.Windows.Forms.ComboBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbb_timchucvu = new System.Windows.Forms.ComboBox();
            this.tble_nhanvien = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_themmoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_xuatfile = new System.Windows.Forms.Button();
            this.btn_refesh = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tble_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NhanVienID";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // txt_file
            // 
            this.txt_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_file.Location = new System.Drawing.Point(223, 31);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(561, 22);
            this.txt_file.TabIndex = 25;
            this.txt_file.UseWaitCursor = true;
            // 
            // cbb_chucvu
            // 
            this.cbb_chucvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_chucvu.FormattingEnabled = true;
            this.cbb_chucvu.Location = new System.Drawing.Point(875, 108);
            this.cbb_chucvu.Name = "cbb_chucvu";
            this.cbb_chucvu.Size = new System.Drawing.Size(197, 24);
            this.cbb_chucvu.TabIndex = 24;
            this.cbb_chucvu.UseWaitCursor = true;
            this.cbb_chucvu.TextChanged += new System.EventHandler(this.luong_change);
            // 
            // txt_luong
            // 
            this.txt_luong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_luong.Location = new System.Drawing.Point(875, 147);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(197, 22);
            this.txt_luong.TabIndex = 23;
            this.txt_luong.UseWaitCursor = true;
            // 
            // txt_timmanv
            // 
            this.txt_timmanv.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timmanv.Location = new System.Drawing.Point(18, 28);
            this.txt_timmanv.Name = "txt_timmanv";
            this.txt_timmanv.Size = new System.Drawing.Size(168, 22);
            this.txt_timmanv.TabIndex = 19;
            this.txt_timmanv.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(801, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 19);
            this.label13.TabIndex = 22;
            this.label13.Text = "Lương:";
            this.label13.UseWaitCursor = true;
            // 
            // dt_ngayvaolam
            // 
            this.dt_ngayvaolam.CustomFormat = "yyyy-mm-dd";
            this.dt_ngayvaolam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngayvaolam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngayvaolam.Location = new System.Drawing.Point(875, 75);
            this.dt_ngayvaolam.Name = "dt_ngayvaolam";
            this.dt_ngayvaolam.Size = new System.Drawing.Size(197, 22);
            this.dt_ngayvaolam.TabIndex = 21;
            this.dt_ngayvaolam.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(752, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Ngày vào làm: ";
            this.label12.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.txt_file);
            this.groupBox2.Controls.Add(this.btn_upload);
            this.groupBox2.Controls.Add(this.cbb_chucvu);
            this.groupBox2.Controls.Add(this.txt_luong);
            this.groupBox2.Controls.Add(this.btn_luu);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.dt_ngayvaolam);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_cccd);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbb_gioitinh);
            this.groupBox2.Controls.Add(this.txt_sdt);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dt_ngaysinh);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_email);
            this.groupBox2.Controls.Add(this.txt_hoten);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 438);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1120, 233);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Nhân Viên";
            this.groupBox2.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(792, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Chức vụ:";
            this.label6.UseWaitCursor = true;
            // 
            // txt_cccd
            // 
            this.txt_cccd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cccd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cccd.Location = new System.Drawing.Point(494, 78);
            this.txt_cccd.Name = "txt_cccd";
            this.txt_cccd.Size = new System.Drawing.Size(197, 22);
            this.txt_cccd.TabIndex = 17;
            this.txt_cccd.UseWaitCursor = true;
            this.txt_cccd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ktra_cccd);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(399, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 19);
            this.label10.TabIndex = 16;
            this.label10.Text = "Số CCCD: ";
            this.label10.UseWaitCursor = true;
            // 
            // cbb_gioitinh
            // 
            this.cbb_gioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_gioitinh.FormattingEnabled = true;
            this.cbb_gioitinh.Items.AddRange(new object[] {
            "--Chọn giới tính--",
            "Nam ",
            "Nữ",
            "Khác"});
            this.cbb_gioitinh.Location = new System.Drawing.Point(128, 147);
            this.cbb_gioitinh.Name = "cbb_gioitinh";
            this.cbb_gioitinh.Size = new System.Drawing.Size(197, 24);
            this.cbb_gioitinh.TabIndex = 15;
            this.cbb_gioitinh.UseWaitCursor = true;
            // 
            // txt_sdt
            // 
            this.txt_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(494, 141);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(197, 22);
            this.txt_sdt.TabIndex = 13;
            this.txt_sdt.UseWaitCursor = true;
            this.txt_sdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ktra_sdt);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(399, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Điện thoại: ";
            this.label9.UseWaitCursor = true;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.CustomFormat = "yyyy-mm-dd";
            this.dt_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaysinh.Location = new System.Drawing.Point(128, 110);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(197, 22);
            this.dt_ngaysinh.TabIndex = 9;
            this.dt_ngaysinh.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(399, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Email:";
            this.label8.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ngày sinh: ";
            this.label7.UseWaitCursor = true;
            // 
            // txt_email
            // 
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(494, 108);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(197, 22);
            this.txt_email.TabIndex = 6;
            this.txt_email.UseWaitCursor = true;
            // 
            // txt_hoten
            // 
            this.txt_hoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoten.Location = new System.Drawing.Point(130, 75);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(195, 22);
            this.txt_hoten.TabIndex = 5;
            this.txt_hoten.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới tính:";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Họ và tên: ";
            this.label5.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID:";
            this.label1.UseWaitCursor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btn_themmoi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_xuatfile);
            this.panel1.Controls.Add(this.btn_refesh);
            this.panel1.Location = new System.Drawing.Point(31, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 61);
            this.panel1.TabIndex = 45;
            this.panel1.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.txt_timmanv);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_timkiem);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.cbb_timchucvu);
            this.panel2.Location = new System.Drawing.Point(648, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 73);
            this.panel2.TabIndex = 46;
            this.panel2.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 32;
            this.label2.UseWaitCursor = true;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ImageKey = "(none)";
            this.btn_timkiem.Location = new System.Drawing.Point(386, 22);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(82, 33);
            this.btn_timkiem.TabIndex = 22;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.UseWaitCursor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(192, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 24;
            this.label11.Text = "Chức Vụ:";
            this.label11.UseWaitCursor = true;
            // 
            // cbb_timchucvu
            // 
            this.cbb_timchucvu.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_timchucvu.FormattingEnabled = true;
            this.cbb_timchucvu.Location = new System.Drawing.Point(195, 28);
            this.cbb_timchucvu.Name = "cbb_timchucvu";
            this.cbb_timchucvu.Size = new System.Drawing.Size(168, 23);
            this.cbb_timchucvu.TabIndex = 25;
            this.cbb_timchucvu.UseWaitCursor = true;
            // 
            // tble_nhanvien
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tble_nhanvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.tble_nhanvien.BackgroundColor = System.Drawing.Color.Silver;
            this.tble_nhanvien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tble_nhanvien.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.tble_nhanvien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tble_nhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.tble_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tble_nhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column5,
            this.Column7,
            this.Column6,
            this.Column9,
            this.Column10,
            this.Column11});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tble_nhanvien.DefaultCellStyle = dataGridViewCellStyle13;
            this.tble_nhanvien.GridColor = System.Drawing.Color.Black;
            this.tble_nhanvien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tble_nhanvien.Location = new System.Drawing.Point(9, 170);
            this.tble_nhanvien.Name = "tble_nhanvien";
            this.tble_nhanvien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tble_nhanvien.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.tble_nhanvien.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tble_nhanvien.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.tble_nhanvien.RowTemplate.Height = 24;
            this.tble_nhanvien.Size = new System.Drawing.Size(1120, 262);
            this.tble_nhanvien.StandardTab = true;
            this.tble_nhanvien.TabIndex = 42;
            this.tble_nhanvien.UseWaitCursor = true;
            this.tble_nhanvien.VirtualMode = true;
            this.tble_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tble_nhanvien_CellClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Họ và tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgaySinh";
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GioiTinh";
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Giới Tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenChucVu";
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "Chức Vụ";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SoCCCD";
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "Số CCCD";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SoDienThoai";
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "Điện Thoại";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Email";
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "Email";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "NgayVaoLam";
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "Ngày Vào Làm ";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Luong";
            this.Column10.Frozen = true;
            this.Column10.HeaderText = "Lương";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "CHUCVUID";
            this.Column11.Frozen = true;
            this.Column11.HeaderText = "Chức Vụ ID";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Location = new System.Drawing.Point(409, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(357, 38);
            this.label14.TabIndex = 44;
            this.label14.Text = "DANH SÁCH NHÂN VIÊN ";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.UseWaitCursor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_upload.Image = global::QuanLyKhachSan.Properties.Resources.wallet__1_;
            this.btn_upload.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_upload.Location = new System.Drawing.Point(807, 23);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(113, 37);
            this.btn_upload.TabIndex = 19;
            this.btn_upload.Text = "Nhập file";
            this.btn_upload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.UseWaitCursor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_luu.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Image = global::QuanLyKhachSan.Properties.Resources.save;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_luu.Location = new System.Drawing.Point(990, 184);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(82, 43);
            this.btn_luu.TabIndex = 16;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.UseWaitCursor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_themmoi
            // 
            this.btn_themmoi.BackColor = System.Drawing.Color.LightBlue;
            this.btn_themmoi.Image = global::QuanLyKhachSan.Properties.Resources.them;
            this.btn_themmoi.Location = new System.Drawing.Point(18, 3);
            this.btn_themmoi.Name = "btn_themmoi";
            this.btn_themmoi.Size = new System.Drawing.Size(53, 54);
            this.btn_themmoi.TabIndex = 31;
            this.btn_themmoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_themmoi.UseVisualStyleBackColor = false;
            this.btn_themmoi.UseWaitCursor = true;
            this.btn_themmoi.Click += new System.EventHandler(this.btn_themmoi_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Image = global::QuanLyKhachSan.Properties.Resources.timmmm;
            this.button1.Location = new System.Drawing.Point(136, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 54);
            this.button1.TabIndex = 34;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_xuatfile
            // 
            this.btn_xuatfile.BackColor = System.Drawing.Color.LightGreen;
            this.btn_xuatfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xuatfile.Image = global::QuanLyKhachSan.Properties.Resources.xuatfile;
            this.btn_xuatfile.Location = new System.Drawing.Point(77, 3);
            this.btn_xuatfile.Name = "btn_xuatfile";
            this.btn_xuatfile.Size = new System.Drawing.Size(53, 54);
            this.btn_xuatfile.TabIndex = 23;
            this.btn_xuatfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_xuatfile.UseVisualStyleBackColor = false;
            this.btn_xuatfile.UseWaitCursor = true;
            this.btn_xuatfile.Click += new System.EventHandler(this.btn_xuatfile_Click);
            // 
            // btn_refesh
            // 
            this.btn_refesh.BackColor = System.Drawing.Color.LightGreen;
            this.btn_refesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refesh.Image = global::QuanLyKhachSan.Properties.Resources.refesh;
            this.btn_refesh.Location = new System.Drawing.Point(195, 4);
            this.btn_refesh.Name = "btn_refesh";
            this.btn_refesh.Size = new System.Drawing.Size(53, 54);
            this.btn_refesh.TabIndex = 33;
            this.btn_refesh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_refesh.UseVisualStyleBackColor = false;
            this.btn_refesh.UseWaitCursor = true;
            this.btn_refesh.Click += new System.EventHandler(this.btn_refesh_Click);
            // 
            // QuanLyNhanVien
            // 
            this.ClientSize = new System.Drawing.Size(1144, 693);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tble_nhanvien);
            this.Controls.Add(this.label14);
            this.Name = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tble_nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_themmoi_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void btn_xuatfile_Click(object sender, EventArgs e)
        {
            if (classTT.con.State == ConnectionState.Closed)
                classTT.con.Open();
            string search = "SELECT nv.NHANVIENID, nv.HOTEN, nv.NGAYSINH, nv.GIOITINH, nv.SOCCCD, " +
                "nv.SODIENTHOAI, nv.EMAIL, cv.TENCHUCVU, nv.NGAYVAOLAM, nv.LUONG " +
                "FROM  NhanVien nv LEFT JOIN ChucVu cv ON nv.CHUCVUID = cv.CHUCVUID";
            DataTable tb = new DataTable();
            classTT.load_nhanvien(tble_nhanvien);
            DialogResult result = MessageBox.Show("Bạn muốn xuất file Excel?", "THÔNG BÁO", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                ExportExcel(tb, "DANH SÁCH NHÂN VIÊN");
            }
        }
        public void ExportExcel(DataTable tb, string sheetname)
        {
            //Tạo các đối tượng Excel
            els.Application oExcel = new els.Application();
            els.Workbooks oBooks;
            els.Sheets oSheets;
            els.Workbook oBook;
            els.Worksheet oSheet;
            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (els.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (els.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetname;
            // Tạo phần đầu nếu muốn
            els.Range head = oSheet.get_Range("A1", "J1");
            head.MergeCells = true;
            head.Value2 = "DANH SÁCH THÔNG TIN NHÂN VIÊN";
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = els.XlHAlign.xlHAlignCenter;
            els.Range cl2 = oSheet.get_Range("A3", "A3");
            cl2.Value2 = "Mã NV";
            cl2.ColumnWidth = 7.0;
            els.Range cl3 = oSheet.get_Range("B3", "B3");
            cl3.Value2 = "Họ và Tên";
            cl3.ColumnWidth = 30.0;
            els.Range cl4 = oSheet.get_Range("C3", "C3");
            cl4.Value2 = "Ngày sinh";
            cl4.Columns.NumberFormat = "dd/mm/yyyy";
            cl4.ColumnWidth = 10.0;
            els.Range cl5 = oSheet.get_Range("D3", "D3");
            cl5.Value2 = "Giới tính";
            cl5.ColumnWidth = 10.0;
            els.Range cl6 = oSheet.get_Range("E3", "E3");
            cl6.Value2 = "CCCD";
            cl6.ColumnWidth = 15.0;
            els.Range cl7 = oSheet.get_Range("F3", "F3");
            cl7.Value2 = "Số điện thoại";
            cl7.ColumnWidth = 15;
            els.Range cl8 = oSheet.get_Range("G3", "G3");
            cl8.Value2 = "Email";
            cl8.ColumnWidth = 25.0;
            els.Range cl9 = oSheet.get_Range("H3", "H3");
            cl9.Value2 = "Ngày vào làm";
            cl9.Columns.NumberFormat = "dd/mm/yyyy";
            cl9.ColumnWidth = 15.0;
            els.Range cl10 = oSheet.get_Range("I3", "I3");
            cl10.Value2 = "Chức vụ";
            cl10.ColumnWidth = 15.0;
            els.Range cl11 = oSheet.get_Range("J3", "J3");
            cl11.Value2 = "Lương";
            cl11.ColumnWidth = 15.0;
            els.Range rowHead = oSheet.get_Range("A3", "J3");
            rowHead.Font.Bold = true;
            // Kẻ viền
            rowHead.Borders.LineStyle = els.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = els.XlHAlign.xlHAlignCenter;
            // vì dữ liệu được được gán vào các Cell trong Excel phải thông qua object thuần.
            object[,] arr = new object[tb.Rows.Count, tb.Columns.Count];
            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int r = 0; r < tb.Rows.Count; r++)
            {
                DataRow dr = tb.Rows[r];
                for (int c = 0; c < tb.Columns.Count; c++)

                {
                    if (c == 5 || c == 6)
                        arr[r, c] = "'" + dr[c];
                    else
                        arr[r, c] = dr[c];

                }
            }
            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + tb.Rows.Count - 1;
            int columnEnd = tb.Columns.Count;
            if (oSheet != null)
            {
                els.Range c1 = (els.Range)oSheet.Cells[rowStart, columnStart];
                els.Range c2 = (els.Range)oSheet.Cells[rowEnd, columnEnd];

                if (c1 != null && c2 != null)
                {
                    els.Range range = oSheet.get_Range(c1, c2);
                    range.Value2 = arr; // Điền dữ liệu vào vùng
                }
                else
                {
                    MessageBox.Show("Ô không hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Worksheet không hợp lệ.");
            }

            // Ô bắt đầu điền dữ liệu
            //if (oSheet != null)
            //{
            //    els.Range c1 = (els.Range)oSheet.Cells[rowStart, columnStart];
            //    els.Range c2 = (els.Range)oSheet.Cells[rowEnd, columnEnd];

            //    if (c1 != null && c2 != null)
            //    {
            //        // Lấy về vùng điền dữ liệu
            //        els.Range a = oSheet.get_Range(c1, c2);
            //        //Điền dữ liệu vào vùng đã thiết lập
            //        a.Value2 = arr;
            //        // Kẻ viền
            //        a.Borders.LineStyle = els.Constants.xlSolid;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Ô không hợp lệ.");
            //    }

            // Căn giữa cột STT
            //els.Range c3 = (els.Range)oSheet.Cells[rowEnd, columnStart];
            //els.Range c4 = oSheet.get_Range(c1, c3);
            //oSheet.get_Range(c3, c4).HorizontalAlignment = els.XlHAlign.xlHAlignCenter;
            //định dạng ngày sinh 
            els.Range cl_ns = oSheet.get_Range("C" + rowStart, "C" + rowEnd);
            cl_ns.Columns.NumberFormat = "dd/mm/yyyy";
            els.Range cl_nvl = oSheet.get_Range("H" + rowStart, "H" + rowEnd);
            cl_nvl.Columns.NumberFormat = "dd/mm/yyyy";

        }
        public void xoatrang()
        {
            txt_hoten.Clear();
            txt_cccd.Clear();
            txt_email.Clear();
            txt_sdt.Clear();
            cbb_gioitinh.SelectedIndex = 0;
            txt_luong.Clear();
            txt_timmanv.Clear();
            cbb_chucvu.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_timmanv.Enabled = true;
            cbb_timchucvu.Enabled = true;
            btn_timkiem.Enabled = true;
        }

        private void btn_refesh_Click(object sender, EventArgs e)
        {
            classTT.load_nhanvien(tble_nhanvien);
            xoatrang();
            txt_timmanv.Enabled = false;
            cbb_timchucvu.Enabled = false;
            btn_timkiem.Enabled = false;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string tim_ma = txt_timmanv.Text.Trim();
            string tim_chucvu = cbb_timchucvu.SelectedValue?.ToString() ?? "";
            if (classTT.con.State == ConnectionState.Closed)
                classTT.con.Open();
            string search = "SELECT NHANVIENID, HOTEN, NGAYSINH, GIOITINH, SOCCCD, " +
                            "SODIENTHOAI, EMAIL, nv.CHUCVUID, cv.TENCHUCVU, NGAYVAOLAM, nv.LUONG " +
                            "FROM NhanVien nv JOIN ChucVu cv ON nv.CHUCVUID = cv.CHUCVUID " +
                            "WHERE NHANVIENID LIKE'%" + tim_ma + "%' AND " +
                                    "nv.CHUCVUID LIKE N'%" + tim_chucvu + "%'";
            SqlCommand cmd = new SqlCommand(search, classTT.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);

            tble_nhanvien.DataSource = tb;
            tble_nhanvien.Refresh();

            if (tb.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả.");
            }
        }
        private void ktra_sdt(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấn phím không phải là số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho nhập ký tự không phải số
                MessageBox.Show("SDT chỉ chứa chữ số", "THÔNG BÁO");
            }

            // Kiểm tra số lượng ký tự đã nhập
            if (txt_sdt.Text.Length != 10 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho nhập thêm ký tự nếu đã đủ 10 số
                MessageBox.Show("SDT chỉ chứa 10 chữ số", "THÔNG BÁO");
            }
        }
        private void luong_change(object sender, EventArgs e)
        {
            if (cbb_chucvu.SelectedItem != null)
            {
                int machucvu = cbb_chucvu.SelectedIndex;
                if (classTT.con.State == ConnectionState.Closed)
                    classTT.con.Open();
                string query = "SELECT LUONG FROM ChucVu WHERE ChucVuID= @Machucvu";
                SqlCommand cmd = new SqlCommand(query, classTT.con);
                cmd.Parameters.AddWithValue("@Machucvu", machucvu);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    txt_luong.Text = result.ToString();
                }
                else
                {
                    txt_luong.Text = "0";
                }
                cmd.Dispose();
                classTT.con.Close();

            }
        }
        public bool checktrungcccd(String cccd)
        {
            if (classTT.con.State == ConnectionState.Closed)

                classTT.con.Open();
            // tạo đối tượng conmand để thực hiện bản ghi có mã tác giả = mtg
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE SOCCCD='" + cccd + "'";
            SqlCommand cmd = new SqlCommand(sql, classTT.con);
            int kqua = (int)cmd.ExecuteScalar();
            if (kqua > 0)
                return true;
            else
                return false;

        }

        private void ktra_cccd(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu người dùng nhấn phím không phải là số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho nhập ký tự không phải số
                MessageBox.Show("CCCD chỉ chứa chữ số", "THÔNG BÁO");
            }

            // Kiểm tra số lượng ký tự đã nhập
            if (txt_cccd.Text.Length != 12 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho nhập thêm ký tự nếu đã đủ 10 số
                MessageBox.Show("CCCD phải chứa 12 chữ số", "THÔNG BÁO");
            }
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            //hiển thị hộp file
            DialogResult kq = openFileDialog1.ShowDialog();
            //chỉ hiển thị file excel 
            openFileDialog1.Filter = "excel file |*.xls;*,.xlsx";
            openFileDialog1.FilterIndex = 1;// trỏ vào vị trí đầu tiên của bộ lọc
            openFileDialog1.RestoreDirectory = true; //nhớ đường dẫn truy cập lần gần nhất
            openFileDialog1.Multiselect = false;// Không cho phép nhập nhiều file
            if (kq == DialogResult.OK)
            {
                txt_file.Text = openFileDialog1.FileName;
                string tenfile = openFileDialog1.FileName;
                ReadExcel(tenfile);
            }

        }
        private void FormatExcelSheet(xls.Worksheet wsheet)
        {
            xls.Range dateRangecol2 = wsheet.Columns[2];
            dateRangecol2.NumberFormat = "yyyy/mm/dd";
            xls.Range dateRangecol8 = wsheet.Columns[8];
            dateRangecol8.NumberFormat = "yyyy/mm/dd";
        }
        private void ReadExcel(String filename)
        {
            if (filename == null)
            {
                MessageBox.Show("Chưa chọn file");
            }
            else
            {
                xls.Application Excel = new xls.Application();
                Excel.Workbooks.Open(filename);
                //đọc dữ liệu từng sheet của excel
                foreach (xls.Worksheet wsheet in Excel.Worksheets)
                {
                    int i = 2;  //để đọc từng dòng của sheet bắt đầu từ dòng số 2
                    do
                    {
                        if (wsheet.Cells[i, 1].Value == null && wsheet.Cells[i, 2].Value == null && wsheet.Cells[i, 3].Value == null)
                        {
                            break;
                        }
                        else
                        {
                            //Đổ dòng dữ liệu vào DB
                            DateTime ns;
                            DateTime nvl = DateTime.MinValue;
                            if (DateTime.TryParse(wsheet.Cells[i, 2].Value?.ToString(), out ns) &&
                                DateTime.TryParse(wsheet.Cells[i, 8].Value?.ToString(), out nvl))
                            {
                                ThemmoiNhanVien(
                                    wsheet.Cells[i, 1].Value?.ToString() ?? "",
                                    ns,
                                    wsheet.Cells[i, 3].Value?.ToString() ?? "",
                                    wsheet.Cells[i, 4].Value?.ToString() ?? "",
                                    wsheet.Cells[i, 5].Value?.ToString() ?? "",
                                    wsheet.Cells[i, 6].Value?.ToString() ?? "",
                                    wsheet.Cells[i, 7].Value?.ToString() ?? "",
                                    nvl,
                                    wsheet.Cells[i, 9].Value?.ToString() ?? ""
                                );
                            }
                            else
                            {
                                MessageBox.Show($"Ngày sinh không hợp lệ ở dòng {i}");
                            }
                            i++;
                        }
                    }
                    while (true);
                }
            }
        }
        private void ThemmoiNhanVien(string hoten, DateTime ngaysinh, string gioitinh, string cccd, string sdt, string email, string chucvu, DateTime ngayvaolam, string luong)
        {
            if (classTT.con.State == ConnectionState.Closed)
                classTT.con.Open();
            String query = "INSERT INTO NhanVien VALUES (@ten, @ns, @gt, @cccd, @sdt, @email,@chucvu, @nvl, @luong)";
            SqlCommand cmd = new SqlCommand(query, classTT.con);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 100).Value = hoten;
            cmd.Parameters.Add("@ns", SqlDbType.Date).Value = ngaysinh;
            cmd.Parameters.Add("@gt", SqlDbType.NVarChar, 10).Value = gioitinh;
            cmd.Parameters.Add("@cccd", SqlDbType.VarChar, 10).Value = cccd;
            cmd.Parameters.Add("@sdt", SqlDbType.VarChar, 10).Value = sdt;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = email;
            cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar, 100).Value = chucvu;
            cmd.Parameters.Add("@nvl", SqlDbType.Date).Value = ngayvaolam;
            cmd.Parameters.Add("@luong", SqlDbType.Decimal).Value = luong;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            classTT.con.Close();
            MessageBox.Show("Thêm mới nhân viên thành công", "THÔNG BÁO");
            classTT.load_nhanvien(tble_nhanvien);
        }

        private void tble_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0) // Kiểm tra chỉ số dòng hợp lệ
            {
                int ma = int.Parse(tble_nhanvien.Rows[i].Cells[0].Value.ToString());
                string hoten = tble_nhanvien.Rows[i].Cells[1].Value.ToString();
                DateTime ngaysinh = DateTime.Parse(tble_nhanvien.Rows[i].Cells[2].Value.ToString());
                string gioitinh = tble_nhanvien.Rows[i].Cells[3].Value.ToString();
                string cccd = tble_nhanvien.Rows[i].Cells[4].Value.ToString();
                string sdt = tble_nhanvien.Rows[i].Cells[5].Value.ToString();
                string email = tble_nhanvien.Rows[i].Cells[6].Value.ToString();
                DateTime ngayvaolam = DateTime.Parse(tble_nhanvien.Rows[i].Cells[8].Value.ToString());
                string chucvu = tble_nhanvien.Rows[i].Cells[10].Value.ToString();
                string luong = tble_nhanvien.Rows[i].Cells[9].Value.ToString();

                // Mở form mới và truyền dữ liệu
                ThongTinNhanVien ct = new ThongTinNhanVien(ma, hoten, ngaysinh, gioitinh, cccd, sdt, email, ngayvaolam, chucvu, luong);
                ct.ShowDialog(); // Hiển thị dưới dạng dialog
            }
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            txt_timmanv.Enabled = false;
            txt_timmanv.BackColor = Color.White;
            cbb_timchucvu.Enabled = false;
            cbb_timchucvu.BackColor = Color.White;
            btn_timkiem.Enabled = false;
            groupBox2.Visible = false;
            classTT.load_nhanvien(tble_nhanvien);
            classTT.load_chucvu(cbb_chucvu, cbb_timchucvu, "CHUCVUID", "TENCHUCVU");
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            String hoten = txt_hoten.Text.Trim();
            DateTime ngaysinh = dt_ngaysinh.Value;
            String gioitinh;
            if (cbb_gioitinh.SelectedItem == null)
                gioitinh = "";
            else
                gioitinh = cbb_gioitinh.SelectedItem.ToString();
            String cccd = txt_cccd.Text.Trim();
            String sdt = txt_sdt.Text.Trim();
            String email = txt_email.Text.Trim();
            DateTime ngayvaolam = dt_ngayvaolam.Value;
            String chucvu = cbb_chucvu.SelectedValue.ToString();
            String luong = txt_luong.Text.Trim();
            if (string.IsNullOrWhiteSpace(hoten) ||
                string.IsNullOrWhiteSpace(cccd) ||
                string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(chucvu) ||
                string.IsNullOrWhiteSpace(luong) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên!", "THÔNG BÁO");
                return;
            }
            if (checktrungcccd(cccd))
            {
                MessageBox.Show("CCCD đã tồn tại", "THÔNG BÁO");
                txt_cccd.Focus();
                return;
            }
            if (!email.EndsWith("@gmail.com") ||
                    email.Length < 11 ||
                    !char.IsLetter(email[0]) ||
                    email.All(c => char.IsLetterOrDigit(c) || c == '.' || c == '_'))
            {
                MessageBox.Show("Vui lòng nhập email hợp lệ!");
                return;
            }
            if (classTT.con.State == ConnectionState.Closed)
                classTT.con.Open();
            String query = "INSERT INTO NhanVien VALUES (@ten, @ns, @gt, @cccd, @sdt, @email,@chucvu, @nvl, @luong)";
            SqlCommand cmd = new SqlCommand(query, classTT.con);
            cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 100).Value = hoten;
            cmd.Parameters.Add("@ns", SqlDbType.Date).Value = ngaysinh;
            cmd.Parameters.Add("@gt", SqlDbType.NVarChar, 10).Value = gioitinh;
            cmd.Parameters.Add("@cccd", SqlDbType.VarChar, 10).Value = cccd;
            cmd.Parameters.Add("@sdt", SqlDbType.VarChar, 10).Value = sdt;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 100).Value = email;
            cmd.Parameters.Add("@chucvu", SqlDbType.NVarChar, 100).Value = chucvu;
            cmd.Parameters.Add("@nvl", SqlDbType.Date).Value = ngayvaolam;
            cmd.Parameters.Add("@luong", SqlDbType.Decimal).Value = luong;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            classTT.con.Close();
            MessageBox.Show("Thêm mới nhân viên thành công", "THÔNG BÁO");
            xoatrang();
            classTT.load_nhanvien(tble_nhanvien);
        }
    }
}
