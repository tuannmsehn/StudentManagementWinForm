using Microsoft.EntityFrameworkCore;
using MyProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();
        }


        private void FormNhapDiem_Load(object sender, EventArgs e)
        {
            using (MyTestContext context = new MyTestContext())
            {
                var data = context.Mons.ToList();
                cboSubjectID.DataSource = data;
                cboSubjectID.DisplayMember = "MaMH";

                var data2 = context.SinhViens.ToList();
                cboMaSo.DataSource = data2;
                cboMaSo.DisplayMember = "MaSo";
                cboMaSo.ValueMember = "HoTen";

                var data3 = context.SinhViens.ToList();
                cboHoTen.DataSource = data3;
                cboHoTen.DisplayMember = "HoTen";
                cboHoTen.ValueMember = "MaSo";
            }
        }

        private void cboSubjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cboSubjectID.Text.Trim();
            using (MyTestContext context = new MyTestContext())
            {
                var name = context.Mons.Where(c => c.MaMh.Equals(value))
                                 .Select(c => c.TenMh)
                                 .FirstOrDefault();
                if (name != null)
                {
                    txtSubjectName.Text = name;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int mark = Convert.ToInt32(txtMark.Text);
                Regex r = new Regex(@"^\d+$");
                if (String.IsNullOrEmpty(txtMark.Text))
                {
                    MessageBox.Show("Không được để trống điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (r.IsMatch(txtMark.Text) == false)
                {
                    MessageBox.Show("Điểm chỉ được nhập số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (mark > 10)
                {
                    MessageBox.Show("Điểm phải <= 10 chứ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string value = cboMaSo.Text.Trim();
                    using (MyTestContext context = new MyTestContext())
                    {



                        KetQua s = context.KetQuas.Where(c => c.MaMh.Equals(cboSubjectID.Text)).SingleOrDefault(item => item.MaSo.ToString().Equals(value));
                        if (s != null)
                        {
                            MessageBox.Show("Môn này sinh viên đã có điểm, truy cập xem điểm để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            int id = Convert.ToInt32(cboMaSo.Text);
                            KetQua ketqua = new KetQua
                            {
                                MaSo = id,
                                MaMh = cboSubjectID.Text,
                                Diem = Convert.ToInt32(txtMark.Text)
                            };

                            context.KetQuas.Add(ketqua);
                            if (context.SaveChanges() > 0)
                            {
                                MessageBox.Show("Nhập điểm thành công!");
                                reset();
                            }
                        }

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập điểm lỗi rồi!");
            }
        }

        public void reset()
        {
            cboMaSo.SelectedIndex = 0;
            cboHoTen.SelectedIndex = 0;
            txtMark.Clear();
            txtSubjectName.Clear();
            cboSubjectID.SelectedIndex = 0;
        }

        private void cboMaSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cboMaSo.Text;
            using (MyTestContext context = new MyTestContext())
            {
                var name = context.SinhViens.Where(c => c.MaSo.ToString().Equals(value))
                                 .Select(c => c.HoTen)
                                 .FirstOrDefault();

                if (name != null)
                {
                    cboHoTen.Text = name;
                }
            }
        }

        private void cboHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = cboHoTen.Text;
            using (MyTestContext context = new MyTestContext())
            {
                var name = context.SinhViens.Where(c => c.HoTen.Equals(value))
                                 .Select(c => c.MaSo)
                                 .FirstOrDefault();

                if (name != null)
                {
                    cboMaSo.Text = name.ToString();
                }
            }
        }
    }
}
