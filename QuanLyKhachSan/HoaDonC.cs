using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
    public class HoaDonC
    {
            public string TenDV { get; set; }
            public decimal DonGia { get; set; }
            public int SL { get; set; }
            public decimal ThanhTien => DonGia * SL;
    }
 
}
