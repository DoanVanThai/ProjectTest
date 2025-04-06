namespace QuanLyKhachSan
{
    partial class DialogThemKhachHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.typekhAdd = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.addressAdd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cccdAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emailAdd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.birthdayAdd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbgt = new System.Windows.Forms.ComboBox();
            this.phoneAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.typekhAdd);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.addressAdd);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cccdAdd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.emailAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.birthdayAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbbgt);
            this.panel1.Controls.Add(this.phoneAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nameAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(39, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 553);
            this.panel1.TabIndex = 0;
            // 
            // typekhAdd
            // 
            this.typekhAdd.FormattingEnabled = true;
            this.typekhAdd.Items.AddRange(new object[] {
            "--Chọn--",
            "Khách lẻ",
            "Khách đoàn",
            "Khách hàng VIP"});
            this.typekhAdd.Location = new System.Drawing.Point(23, 496);
            this.typekhAdd.Name = "typekhAdd";
            this.typekhAdd.Size = new System.Drawing.Size(416, 28);
            this.typekhAdd.TabIndex = 16;
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
            // addressAdd
            // 
            this.addressAdd.Location = new System.Drawing.Point(23, 414);
            this.addressAdd.Name = "addressAdd";
            this.addressAdd.Size = new System.Drawing.Size(416, 26);
            this.addressAdd.TabIndex = 14;
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
            // cccdAdd
            // 
            this.cccdAdd.Location = new System.Drawing.Point(23, 348);
            this.cccdAdd.Name = "cccdAdd";
            this.cccdAdd.Size = new System.Drawing.Size(416, 26);
            this.cccdAdd.TabIndex = 12;
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
            // emailAdd
            // 
            this.emailAdd.Location = new System.Drawing.Point(23, 279);
            this.emailAdd.Name = "emailAdd";
            this.emailAdd.Size = new System.Drawing.Size(416, 26);
            this.emailAdd.TabIndex = 10;
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
            // birthdayAdd
            // 
            this.birthdayAdd.CustomFormat = "dd/MM/yyyy";
            this.birthdayAdd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayAdd.Location = new System.Drawing.Point(246, 133);
            this.birthdayAdd.Name = "birthdayAdd";
            this.birthdayAdd.Size = new System.Drawing.Size(193, 26);
            this.birthdayAdd.TabIndex = 8;
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
            // cbbgt
            // 
            this.cbbgt.FormattingEnabled = true;
            this.cbbgt.Location = new System.Drawing.Point(23, 133);
            this.cbbgt.Name = "cbbgt";
            this.cbbgt.Size = new System.Drawing.Size(207, 28);
            this.cbbgt.TabIndex = 6;
            // 
            // phoneAdd
            // 
            this.phoneAdd.Location = new System.Drawing.Point(23, 207);
            this.phoneAdd.Name = "phoneAdd";
            this.phoneAdd.Size = new System.Drawing.Size(416, 26);
            this.phoneAdd.TabIndex = 5;
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
            // nameAdd
            // 
            this.nameAdd.Location = new System.Drawing.Point(23, 64);
            this.nameAdd.Name = "nameAdd";
            this.nameAdd.Size = new System.Drawing.Size(416, 26);
            this.nameAdd.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thêm dữ liệu khách hàng";
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel.Location = new System.Drawing.Point(393, 604);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(112, 42);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.add.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.add.Location = new System.Drawing.Point(262, 604);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(125, 42);
            this.add.TabIndex = 4;
            this.add.Text = "Thêm mới";
            this.add.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // DialogThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(549, 656);
            this.Controls.Add(this.add);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "DialogThemKhachHang";
            this.Text = "DialogThemKhachHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox phoneAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbgt;
        private System.Windows.Forms.DateTimePicker birthdayAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addressAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cccdAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emailAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox typekhAdd;
    }
}