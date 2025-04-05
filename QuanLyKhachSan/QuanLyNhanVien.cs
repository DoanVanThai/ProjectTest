using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class QuanLyNhanVien: Form
    {
        private Label label1;

        public QuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // QuanLyNhanVien
            // 
            this.ClientSize = new System.Drawing.Size(759, 451);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyNhanVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
