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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsmStudent_Click(object sender, EventArgs e)
        {
            FormStudent student = new FormStudent();
            student.Show();
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tsmFaculty_Click(object sender, EventArgs e)
        {
            FormKhoa formKhoa = new FormKhoa();
            formKhoa.Show();
        }

        private void tsmInputMark_Click(object sender, EventArgs e)
        {
            FormNhapDiem formNhapDiem = new FormNhapDiem();
            formNhapDiem.Show();
        }

        private void tsmSubject_Click(object sender, EventArgs e)
        {
            FormMonHoc formMonHoc = new FormMonHoc();
            formMonHoc.Show();
        }

        private void tsmViewMark_Click(object sender, EventArgs e)
        {
            FormXemDiem formXemDiem = new FormXemDiem();
            formXemDiem.Show();
        }

        private void tsmStatisticFaculty_Click(object sender, EventArgs e)
        {
            FormThongKe formThongKe = new FormThongKe();
            formThongKe.Show();
        }

        private void tsmSystem_Click(object sender, EventArgs e)
        {
            FormHeThong formHeThong = new FormHeThong();
            formHeThong.Show();
        }
    }
}
