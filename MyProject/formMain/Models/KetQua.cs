using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject.Models
{
    public partial class KetQua
    {
        public int MaSo { get; set; }
        public string MaMh { get; set; }
        public int? Diem { get; set; }

        public virtual Mon MaMhNavigation { get; set; }
        public virtual SinhVien MaSoNavigation { get; set; }
    }
}
