using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLyKhachSan
{
    public partial class FormXuatHoaDon : Form
    {
        private string hoaDonID;
        private string ngayDen;
        private string ngayDi;
        private string ngayTT;
        private string phongID;
        private string tenKH;
        private List<HoaDonC> hoaDonList;
        private string tongTien;

        public FormXuatHoaDon(string hoaDonID,string ngayDen, string ngayDi, string ngayTT, string phongID, string tenKH, List<HoaDonC> hoaDonList, string tongTien)
        {
            InitializeComponent();
            this.hoaDonID = hoaDonID;
            this.ngayDen = ngayDen;
            this.ngayDi = ngayDi;
            this.ngayTT = ngayTT;
            this.phongID = phongID;
            this.tenKH = tenKH;
            this.hoaDonList = hoaDonList;
            this.tongTien = tongTien;

        }

        private void FormXuatHoaDon_Load(object sender, EventArgs e)
        {
            // Tham số đơn (Parameter)
            ReportParameter[] parameters = new ReportParameter[7];
            parameters[0] = new ReportParameter("hoaDonID", hoaDonID);
            parameters[1] = new ReportParameter("tenKhachHang", tenKH);
            parameters[2] = new ReportParameter("phongID", phongID);
            parameters[3] = new ReportParameter("ngayDen", ngayDen);
            parameters[4] = new ReportParameter("ngayDi", ngayDi);
            parameters[5] = new ReportParameter("ngayTT", ngayTT);
            parameters[6] = new ReportParameter("tongTien", tongTien);

            reportViewer1.LocalReport.SetParameters(parameters);

            // DataSource 
            if (hoaDonList != null && hoaDonList.Count > 0)
            {
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", hoaDonList));
                reportViewer1.RefreshReport();
            }
            else
            {
                MessageBox.Show("Danh sách hóa đơn trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
