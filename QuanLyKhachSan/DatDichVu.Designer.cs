﻿namespace QuanLyKhachSan
{
    partial class DatDichVu
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
            this.grvSearchDV = new System.Windows.Forms.DataGridView();
            this.grvDVdaDat = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSearchDV = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateDV = new System.Windows.Forms.Panel();
            this.cbbphong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datdv = new System.Windows.Forms.Button();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.grvSearchDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDVdaDat)).BeginInit();
            this.panel1.SuspendLayout();
            this.dateDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grvSearchDV
            // 
            this.grvSearchDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSearchDV.Location = new System.Drawing.Point(37, 245);
            this.grvSearchDV.Name = "grvSearchDV";
            this.grvSearchDV.RowHeadersWidth = 62;
            this.grvSearchDV.RowTemplate.Height = 28;
            this.grvSearchDV.Size = new System.Drawing.Size(765, 552);
            this.grvSearchDV.TabIndex = 0;
            this.grvSearchDV.SelectionChanged += new System.EventHandler(this.grvSearchDV_SelectionChanged);
            // 
            // grvDVdaDat
            // 
            this.grvDVdaDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvDVdaDat.Location = new System.Drawing.Point(909, 245);
            this.grvDVdaDat.Name = "grvDVdaDat";
            this.grvDVdaDat.RowHeadersWidth = 62;
            this.grvDVdaDat.RowTemplate.Height = 28;
            this.grvDVdaDat.Size = new System.Drawing.Size(765, 552);
            this.grvDVdaDat.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.txtSum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtsl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtSearchDV);
            this.panel1.Location = new System.Drawing.Point(37, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 194);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm dịch vụ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSearchDV
            // 
            this.txtSearchDV.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDV.Location = new System.Drawing.Point(30, 33);
            this.txtSearchDV.Name = "txtSearchDV";
            this.txtSearchDV.Size = new System.Drawing.Size(308, 37);
            this.txtSearchDV.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(930, 139);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // dateDV
            // 
            this.dateDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dateDV.Controls.Add(this.dateTimePicker1);
            this.dateDV.Controls.Add(this.cbbphong);
            this.dateDV.Controls.Add(this.label2);
            this.dateDV.Controls.Add(this.datdv);
            this.dateDV.Location = new System.Drawing.Point(900, 12);
            this.dateDV.Name = "dateDV";
            this.dateDV.Size = new System.Drawing.Size(765, 194);
            this.dateDV.TabIndex = 3;
            // 
            // cbbphong
            // 
            this.cbbphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbphong.FormattingEnabled = true;
            this.cbbphong.Location = new System.Drawing.Point(51, 41);
            this.cbbphong.Name = "cbbphong";
            this.cbbphong.Size = new System.Drawing.Size(428, 33);
            this.cbbphong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đặt dịch vụ";
            // 
            // datdv
            // 
            this.datdv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.datdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datdv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.datdv.Location = new System.Drawing.Point(512, 78);
            this.datdv.Name = "datdv";
            this.datdv.Size = new System.Drawing.Size(186, 38);
            this.datdv.TabIndex = 1;
            this.datdv.Text = "Đặt dịch vụ";
            this.datdv.UseVisualStyleBackColor = false;
            this.datdv.Click += new System.EventHandler(this.datdv_Click);
            // 
            // txtsl
            // 
            this.txtsl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsl.Location = new System.Drawing.Point(637, 32);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(50, 37);
            this.txtsl.TabIndex = 3;
            this.txtsl.TextChanged += new System.EventHandler(this.txtsl_TextChanged);
            this.txtsl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsl_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(709, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(580, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng thanh toán:";
            // 
            // txtSum
            // 
            this.txtSum.AutoSize = true;
            this.txtSum.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSum.ForeColor = System.Drawing.Color.Red;
            this.txtSum.Location = new System.Drawing.Point(562, 145);
            this.txtSum.Name = "txtSum";
            this.txtSum.Size = new System.Drawing.Size(28, 32);
            this.txtSum.TabIndex = 7;
            this.txtSum.Text = "0";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 127);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(428, 37);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // DatDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1719, 1050);
            this.Controls.Add(this.dateDV);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grvDVdaDat);
            this.Controls.Add(this.grvSearchDV);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DatDichVu";
            this.Text = "DatDichVu";
            ((System.ComponentModel.ISupportInitialize)(this.grvSearchDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDVdaDat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.dateDV.ResumeLayout(false);
            this.dateDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grvSearchDV;
        private System.Windows.Forms.DataGridView grvDVdaDat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSearchDV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel dateDV;
        private System.Windows.Forms.ComboBox cbbphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button datdv;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label txtSum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}