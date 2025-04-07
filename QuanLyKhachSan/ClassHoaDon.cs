using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan
{
        public class ClassHoaDon
        {
            public int TenDV { get; set; }
            public int DonGia { get; set; }
            public int SL { get; set; }
            public int ThanhTien => DonGia * SL;
        }
}
