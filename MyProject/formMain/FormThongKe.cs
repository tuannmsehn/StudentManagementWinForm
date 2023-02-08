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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            using (MyTestContext context = new MyTestContext())
            {
                var data = context.Khoas.ToList();
                cboMaKhoa.DataSource = data;
                cboMaKhoa.DisplayMember = "MaKhoa";

                var data1 = context.Khoas.ToList();
                cboTenKhoa.DataSource = data1;
                cboTenKhoa.DisplayMember = "TenKhoa";
            }
        }

        private void cboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cboMaKhoa.Text;
            using (MyTestContext context = new MyTestContext())
            {
                Khoa s = context.Khoas.FirstOrDefault(c => c.MaKhoa.Equals(value));

                if (s != null)
                {
                    cboTenKhoa.Text = s.TenKhoa;
                }
            }
        }

        private void cboTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cboTenKhoa.Text;
            using (MyTestContext context = new MyTestContext())
            {
                Khoa s = context.Khoas.FirstOrDefault(c => c.TenKhoa.Equals(value));

                if (s != null)
                {
                    cboMaKhoa.Text = s.MaKhoa;
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            //biến context sau khi ra ngoài hàm using tự đông giải phóng
            using (MyTestContext context = new MyTestContext())
            {
                var data1 = context.SinhViens.Where(p => p.MaKhoa == cboMaKhoa.Text).Select(item => new
                {
                    MaSo = item.MaSo,
                    HoTen = item.HoTen,
                    NgaySinh = item.NgaySinh,
                    GioiTinh = item.GioiTinh,
                    DiaChi = item.DiaChi,
                    DienThoai = item.DienThoai
                }).ToList();
                dataGridView1.DataSource = data1;

            }
        }
    }
}
