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
    public partial class FormMonHoc : Form
    {
        public FormMonHoc()
        {
            InitializeComponent();
        }

        private void FormMonHoc_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            //biến context sau khi ra ngoài hàm using tự đông giải phóng
            using (MyTestContext context = new MyTestContext())
            {
                var data1 = context.Mons.Select(item => new
                {
                    ID = item.MaMh,
                    Name = item.TenMh,
                    SoTiet = item.SoTiet
                }).ToList();
                dgMon.DataSource = data1;
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            if (e.RowIndex == -1)
            {
                return;
            }
            txtMaMH.Text = dgMon.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtTenMH.Text = dgMon.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtSoTiet.Text = dgMon.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex r = new Regex(@"^\d+$");
            if (String.IsNullOrEmpty(txtMaMH.Text))
            {
                MessageBox.Show("Không được để trống Mã Môn Học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtTenMH.Text))
            {
                MessageBox.Show("Không được để trống Tên Môn Học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (String.IsNullOrEmpty(txtSoTiet.Text))
            {
                MessageBox.Show("Không được để trống Số Tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtMaMH.TextLength > 6)
            {
                MessageBox.Show("Mã môn phải < 6 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (r.IsMatch(txtSoTiet.Text) == false)
            {
                MessageBox.Show("Số tiét chỉ được nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                btnDelete.Enabled = true;
                using (MyTestContext context = new MyTestContext())
                {
                    try
                    {


                        //tạo đối tượng sẽ insert
                        Mon mon = new Mon
                        {
                            MaMh = txtMaMH.Text,
                            TenMh = txtTenMH.Text,
                            SoTiet = Convert.ToInt32(txtSoTiet.Text)
                        };

                        context.Mons.Add(mon);
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Thêm môn học thành công!");
                            loadData();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Môn học đã tồn tại trên hệ thống!");
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            reset();
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*if (dgMon.SelectedRows == null)
            {
                MessageBox.Show("Chọn môn học muốn xóa!");
            }
            else
            {*/

            using (MyTestContext context = new MyTestContext())
            {
                //Tìm Môn sẽ delete
                Mon mon = context.Mons.SingleOrDefault(item => item.MaMh.Equals(txtMaMH.Text.Trim()));
                if (mon == null)
                {
                    MessageBox.Show("Chọn môn học muốn xóa!");
                }
                else
                {
                    if (MessageBox.Show("Xóa Môn này không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        context.Mons.Remove(mon);
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Delete successfully!");
                            loadData();
                            reset();
                            btnSave.Enabled = true;
                        }
                    }
                }
            }
            //}
        }

        public void reset()
        {
            txtMaMH.Clear();
            txtTenMH.Clear();
            txtSoTiet.Clear();
        }
        public static string maMon = "";
        private void dgMon_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            maMon = dgMon.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            DisplayStudent ds = new DisplayStudent();
            ds.Show();
        }
    }
}
