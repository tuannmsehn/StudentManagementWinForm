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
    public partial class FormXemDiem : Form
    {
        public FormXemDiem()
        {
            InitializeComponent();
        }

        private void FormXemDiem_Load(object sender, EventArgs e)
        {
            using (MyTestContext context = new MyTestContext())
            {
                var data = context.SinhViens.ToList();
                cboMaSV.DataSource = data;
                cboMaSV.DisplayMember = "MaSo";

                var data1 = context.SinhViens.ToList();
                cboTenSV.DataSource = data1;
                cboTenSV.DisplayMember = "HoTen";

                /*if(data != null && data1!= null)
                {
                    loadData();
                }*/
            }
        }

        private void cboMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cboMaSV.Text;
            using (MyTestContext context = new MyTestContext())
            {
                SinhVien s = context.SinhViens.Include(x => x.Khoas).FirstOrDefault(c => c.MaSo.ToString().Equals(value));
                //txtKhoa.Text = tenKhoa;

                if (s != null)
                {
                    cboTenSV.Text = s.HoTen;
                    txtKhoa.Text = s.Khoas.TenKhoa;
                }
            }
        }

        private void cboTenSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cboTenSV.Text;
            using (MyTestContext context = new MyTestContext())
            {
                SinhVien s = context.SinhViens.Include(x => x.Khoas).FirstOrDefault(c => c.HoTen.Equals(value));
                //txtKhoa.Text = tenKhoa;

                if (s != null)
                {
                    cboMaSV.Text = s.MaSo.ToString();
                    txtKhoa.Text = s.Khoas.TenKhoa;
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            
            txtSubject.Clear();
            txtMark.Clear();
            loadData();
            /*if (dgXemDiem.Rows.Count == 0)
            {
                MessageBox.Show("Sinh viên này chưa có điểm môn nào!");
            }*/

        }

        //int count = 0, total = 0;
        private void loadData()
        {
            //biến context sau khi ra ngoài hàm using tự đông giải phóng
            using (MyTestContext context = new MyTestContext())
            {
                var data1 = context.KetQuas.Where(p => p.MaSo == Convert.ToInt32(cboMaSV.Text)).Select(item => new
                {
                    TenMH = item.MaMhNavigation.TenMh,
                    Diem = item.Diem
                }).ToList();
                dgXemDiem.DataSource = data1;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (MyTestContext context = new MyTestContext())
            {
                if (String.IsNullOrEmpty(txtSubject.Text))
                {
                    MessageBox.Show("Chọn môn học muốn sửa điểm");
                }
                else
                {
                    try
                    {
                        //Tim du lieu Sinhvien muon update
                        //KetQua kq = context.KetQuas.Include(c => c.MaMhNavigation).SingleOrDefault(item => item.MaSo.Equals(cboMaSV.Text));
                        KetQua kq = context.KetQuas.Where(c => c.MaMhNavigation.TenMh.Equals(txtSubject.Text)).SingleOrDefault(item => item.MaSo.ToString().Equals(cboMaSV.Text));
                        //setting lai nhung gia tri muon update
                        if (kq != null)
                        {

                            kq.Diem = Convert.ToInt32(txtMark.Text);

                            if (context.SaveChanges() > 0)
                            {
                                MessageBox.Show("Sửa điểm thành công!");
                                loadData();
                                txtSubject.Clear();
                                txtMark.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Giá trị điểm không đổi!");
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Update error:" + ex.Message);
                    }
                }
            }
        }

        private void dgXemDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            txtSubject.Text = dgXemDiem.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtMark.Text = dgXemDiem.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
        }
    }
}
