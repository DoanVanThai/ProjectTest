namespace QuanLyKhachSan
{
    partial class DialogEditKhachHang
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
            this.add = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.typekhEdit = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addressEdit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cccdEdit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emailEdit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.birthdayEdit = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.genderEdit = new System.Windows.Forms.ComboBox();
            this.phoneEdit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerNameEdit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add.Location = new System.Drawing.Point(259, 596);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(125, 42);
            this.add.TabIndex = 8;
            this.add.Text = "Thêm mới";
            this.add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel.Location = new System.Drawing.Point(390, 596);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(112, 42);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, -87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thêm dữ liệu khách hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.typekhEdit);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.addressEdit);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cccdEdit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.emailEdit);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.birthdayEdit);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.genderEdit);
            this.panel1.Controls.Add(this.phoneEdit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.customerNameEdit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(36, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 553);
            this.panel1.TabIndex = 5;
            // 
            // typekhEdit
            // 
            this.typekhEdit.FormattingEnabled = true;
            this.typekhEdit.Items.AddRange(new object[] {
            "--Chọn--",
            "Khách lẻ",
            "Khách đoàn",
            "Khách hàng VIP"});
            this.typekhEdit.Location = new System.Drawing.Point(23, 496);
            this.typekhEdit.Name = "typekhEdit";
            this.typekhEdit.Size = new System.Drawing.Size(416, 28);
            this.typekhEdit.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Loại khách";
            // 
            // addressEdit
            // 
            this.addressEdit.Location = new System.Drawing.Point(23, 414);
            this.addressEdit.Name = "addressEdit";
            this.addressEdit.Size = new System.Drawing.Size(416, 26);
            this.addressEdit.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Địa chỉ";
            // 
            // cccdEdit
            // 
            this.cccdEdit.Location = new System.Drawing.Point(23, 348);
            this.cccdEdit.Name = "cccdEdit";
            this.cccdEdit.Size = new System.Drawing.Size(416, 26);
            this.cccdEdit.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số căn cước công dân";
            // 
            // emailEdit
            // 
            this.emailEdit.Location = new System.Drawing.Point(23, 279);
            this.emailEdit.Name = "emailEdit";
            this.emailEdit.Size = new System.Drawing.Size(416, 26);
            this.emailEdit.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email";
            // 
            // birthdayEdit
            // 
            this.birthdayEdit.CustomFormat = "dd/MM/yyyy";
            this.birthdayEdit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayEdit.Location = new System.Drawing.Point(246, 133);
            this.birthdayEdit.Name = "birthdayEdit";
            this.birthdayEdit.Size = new System.Drawing.Size(193, 26);
            this.birthdayEdit.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày sinh";
            // 
            // genderEdit
            // 
            this.genderEdit.FormattingEnabled = true;
            this.genderEdit.Location = new System.Drawing.Point(23, 133);
            this.genderEdit.Name = "genderEdit";
            this.genderEdit.Size = new System.Drawing.Size(207, 28);
            this.genderEdit.TabIndex = 6;
            // 
            // phoneEdit
            // 
            this.phoneEdit.Location = new System.Drawing.Point(23, 207);
            this.phoneEdit.Name = "phoneEdit";
            this.phoneEdit.Size = new System.Drawing.Size(416, 26);
            this.phoneEdit.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // customerNameEdit
            // 
            this.customerNameEdit.Location = new System.Drawing.Point(23, 64);
            this.customerNameEdit.Name = "customerNameEdit";
            this.customerNameEdit.Size = new System.Drawing.Size(416, 26);
            this.customerNameEdit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(66, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 33);
            this.panel2.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 28);
            this.label10.TabIndex = 17;
            this.label10.Text = "Chỉnh sửa khách hàng";
            // 
            // DialogEditKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.add);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "DialogEditKhachHang";
            this.Text = "DialogEditKhachHang";
            this.Load += new System.EventHandler(this.DialogEditKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox typekhEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addressEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cccdEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker birthdayEdit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox genderEdit;
        private System.Windows.Forms.TextBox phoneEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerNameEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
    }
}