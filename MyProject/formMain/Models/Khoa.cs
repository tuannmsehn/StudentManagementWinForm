using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject.Models
{
    public partial class Khoa
    {
        public Khoa()
        {
            SinhViens = new HashSet<SinhVien>();
        }

        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }

        public Khoa(string maKhoa, string tenKhoa)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
        }

        public virtual ICollection<SinhVien> SinhViens { get; set; }
    }
}
