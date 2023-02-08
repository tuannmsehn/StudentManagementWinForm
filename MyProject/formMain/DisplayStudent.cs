using Microsoft.EntityFrameworkCore;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class DisplayStudent : Form
    {
        public DisplayStudent()
        {
            InitializeComponent();
        }

        private void DisplayStudent_Load(object sender, EventArgs e)
        {
            loadData();
        }
        string maMon = FormMonHoc.maMon;
        private void loadData()
        {
            //biến context sau khi ra ngoài hàm using tự đông giải phóng
            using (MyTestContext context = new MyTestContext())
            {
                var data1 = context.KetQuas.Where(c => c.MaMh.Equals(maMon)).Select(item => new
                {
                    Name = item.MaSoNavigation.HoTen,
                    NgaySinh = item.MaSoNavigation.NgaySinh,
                    DiaChi = item.MaSoNavigation.DiaChi,
                    DienThoai = item.MaSoNavigation.DienThoai,
                    MaKhoa = item.MaSoNavigation.MaKhoa
                }).ToList();
                dataGridView1.DataSource = data1;
            }


        }
    }
}
