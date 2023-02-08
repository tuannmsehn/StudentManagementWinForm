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
    public partial class FormKhoa : Form
    {
        public FormKhoa()
        {
            InitializeComponent();
        }

        private void FormKhoa_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            //biến context sau khi ra ngoài hàm using tự đông giải phóng
            using (MyTestContext context = new MyTestContext())
            {
                var data1 = context.Khoas.Select(item => new
                {
                    ID = item.MaKhoa,
                    Name = item.TenKhoa,
                }).ToList();
                dgKhoa.DataSource = data1;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Clear();
            txtTenKhoa.Clear();
            /*txtMaKhoa.ReadOnly = false;
            txtTenKhoa.ReadOnly = false;*/
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }
        string id;
        private void dgKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*txtMaKhoa.Enabled = false;
            txtTenKhoa.Enabled = false;*/
            if (e.RowIndex == -1)
            {
                return;
            }
            id = dgKhoa.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            btnDelete.Enabled = true;
            btnSave.Enabled = false;

            txtMaKhoa.Text = dgKhoa.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtTenKhoa.Text = dgKhoa.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string id = txtMaKhoa.Text.Trim().ToUpper();

            if (String.IsNullOrEmpty(txtMaKhoa.Text) || String.IsNullOrEmpty(txtTenKhoa.Text))
            {
                MessageBox.Show("Không được để trống Mã Khoa và Tên Khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                btnDelete.Enabled = true;
                //Khoa k = new Khoa(txtMaKhoa.Text, txtTenKhoa.Text);
                using (MyTestContext context = new MyTestContext())
                {
                    try
                    {
                        /*

                                                Khoa k = context.Khoas.SingleOrDefault(item => item.MaKhoa.ToString().Equals(txtMaKhoa.Text.Trim()));
                                                if (k != null)
                                                {
                                                    MessageBox.Show("Khoa này đã tồn tại trên hệ thống!");
                                                }
                                                else
                                                {*/
                        //tạo đối tượng sẽ insert
                        Khoa khoa = new Khoa
                        {
                            MaKhoa = txtMaKhoa.Text,
                            TenKhoa = txtTenKhoa.Text
                        };

                        context.Khoas.Add(khoa);
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Thêm Khoa thành công!");
                            loadData();
                            txtMaKhoa.Clear();
                            txtTenKhoa.Clear();
                            /*txtMaKhoa.ReadOnly = false;
                            txtTenKhoa.ReadOnly = false;*/
                        }
                    }
                    //}
                    catch (Exception)
                    {
                        MessageBox.Show("Khoa đã tồn tại trên hệ thống!");
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MyTestContext context = new MyTestContext())
            {
                //Tìm Khoa sẽ delete
                Khoa khoa = context.Khoas.SingleOrDefault(item => item.MaKhoa.Equals(txtMaKhoa.Text.Trim()));
                if (khoa == null)
                {
                    MessageBox.Show("Chọn Khoa muốn xóa!");
                }
                else
                {
                    if (MessageBox.Show("Xóa Khoa này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.Khoas.Remove(khoa);
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Xóa khoa thành công!");
                            loadData();
                            txtMaKhoa.Clear();
                            txtTenKhoa.Clear();
                            /*txtMaKhoa.ReadOnly = false;
                            txtTenKhoa.ReadOnly = false;*/
                            btnSave.Enabled = true;
                        }
                    }
                }
            }

        }
    }
}
