using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject.Models
{
    public partial class SinhVien
    {
        public SinhVien()
        {
            KetQuas = new HashSet<KetQua>();
        }

        public int MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public bool? GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public int? DienThoai { get; set; }
        public string MaKhoa { get; set; }

        public virtual Khoa Khoas { get; set; }
        public virtual ICollection<KetQua> KetQuas { get; set; }
    }
}
