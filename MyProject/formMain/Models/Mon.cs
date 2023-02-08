using System;
using System.Collections.Generic;

#nullable disable

namespace MyProject.Models
{
    public partial class Mon
    {
        public Mon()
        {
            KetQuas = new HashSet<KetQua>();
        }

        public string MaMh { get; set; }
        public string TenMh { get; set; }
        public int? SoTiet { get; set; }

        public virtual ICollection<KetQua> KetQuas { get; set; }
    }
}
