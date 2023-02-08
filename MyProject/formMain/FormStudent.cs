using MyProject.Models;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MyProject
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void formStudent_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            //biến context sau khi ra ngoài hàm using tự đông giải phóng
            using (MyTestContext context = new MyTestContext())
            {
                var data1 = context.SinhViens.Select(item => new
                {
                    Maso = item.MaSo,
                    HoTen = item.HoTen,
                    NgaySinh = item.NgaySinh,
                    GioiTinh = item.GioiTinh,
                    DiaChi = item.DiaChi,
                    DienThoai = item.DienThoai,
                    MaKhoa = item.MaKhoa
                }).ToList();
                dgStudent.DataSource = data1;

                var data2 = context.Khoas.ToList();
                cboMaKhoa.DataSource = data2;
                cboMaKhoa.DisplayMember = "MaKhoa";
            }
        }

        string MaKhoa;
        private void dgStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaKhoa = dgStudent.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            if (e.RowIndex == -1)
            {
                return;
            }
            txtID.Text = dgStudent.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dgStudent.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dgStudent.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
            if (dgStudent.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Trim() == "True")
            {
                rdbMale.Checked = true;
            }
            else
            {
                rdbFemale.Checked = true;
            }
            txtAddress.Text = dgStudent.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtPhone.Text = dgStudent.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            cboMaKhoa.Text = dgStudent.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset()
        {
            txtID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            dateTimePicker1.Value = DateTime.Now;
            rdbFemale.Checked = false;
            rdbMale.Checked = false;
            cboMaKhoa.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*dateTimePicker1.Format = DateTimePickerFormat.Custom;
            // Display the date as "Mon 27 Feb 2012".  
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";*/
            int Age = DateTime.Today.Year - dateTimePicker1.Value.Year;
            Regex r = new Regex(@"^\d+$");
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Nhập tên sinh viên!");
            }
            else if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Nhập địa chỉ sinh viên!");
            }
            else if (String.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Nhập số điện thoại sinh viên!");
            }
            else if (r.IsMatch(txtPhone.Text) == false)
            {
                MessageBox.Show("Số điện thoại phải là số!");
            }
            else if (txtPhone.TextLength > 10)
            {
                MessageBox.Show("Số điện thoại chỉ có 10 số!");
            }
            else if (cboMaKhoa.SelectedIndex == -1)
            {
                MessageBox.Show("Nhập mã khoa!");
            }
            else if (rdbFemale.Checked == false && rdbMale.Checked == false)
            {
                MessageBox.Show("Chọn giới tính!");
            }
            else if (Age < 18)
            {
                MessageBox.Show("Sinh viên phải lớn hơn 18 tuổi!");
            }
            else
            {
                using (MyTestContext context = new MyTestContext())
                {
                    SinhVien s = context.SinhViens.Where(c => c.HoTen.Equals(txtName.Text) || c.DienThoai.ToString().Equals(txtPhone.Text)).SingleOrDefault(item => item.MaSo.ToString().Equals(txtID.Text));
                    if (s != null)
                    {
                        MessageBox.Show("Sinh viên này đã tồn tại trên hệ thống, xem danh sách để update thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        bool gender;
                        if (rdbMale.Checked == true)
                        {
                            gender = true;
                        }
                        else
                        {
                            gender = false;
                        }
                        //tạo đối tượng sẽ insert
                        SinhVien sv = new SinhVien
                        {
                            HoTen = txtName.Text,
                            NgaySinh = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()),
                            GioiTinh = gender,
                            DiaChi = txtAddress.Text,
                            DienThoai = Convert.ToInt32(txtPhone.Text),
                            MaKhoa = cboMaKhoa.Text
                        };

                        context.SinhViens.Add(sv);
                        if (context.SaveChanges() > 0)
                        {
                            MessageBox.Show("Thêm thành công!");
                            loadData();
                            reset();
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MyTestContext context = new MyTestContext())
            {
                if (String.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Chọn sinh viên muốn sửa");
                }
                else
                {
                    try
                    {
                        //Tim du lieu Sinhvien muon update
                        SinhVien sv = context.SinhViens.SingleOrDefault(item => item.MaSo == int.Parse(txtID.Text));
                        bool gender;
                        if (rdbMale.Checked == true)
                        {
                            gender = true;
                        }
                        else
                        {
                            gender = false;
                        }
                        //setting lai nhung gia tri muon update
                        if (sv != null)
                        {
                            sv.HoTen = txtName.Text;
                            sv.NgaySinh = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
                            sv.GioiTinh = gender;
                            sv.DiaChi = txtAddress.Text;
                            sv.DienThoai = Convert.ToInt32(txtPhone.Text);
                            sv.MaKhoa = cboMaKhoa.Text;

                            if (context.SaveChanges() > 0)
                            {
                                MessageBox.Show("Sửa thành công!");
                                loadData();
                                reset();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MyTestContext context = new MyTestContext())
            {
                try
                {

                    if (String.IsNullOrEmpty(txtID.Text))
                    {
                        MessageBox.Show("Chọn sinh viên muốn xóa");
                    }
                    else
                    {

                        if (MessageBox.Show("Xóa sinh viên?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            try
                            {


                                loadData();
                                SinhVien sv = context.SinhViens.SingleOrDefault(item => item.MaSo == Convert.ToInt32(txtID.Text));
                                //List<KetQua> kq = context.KetQuas.Where(c => c.MaSo == Convert.ToInt32(txtID.Text)).ToList();
                                KetQua kq = context.KetQuas.SingleOrDefault(c => c.MaSo == Convert.ToInt32(txtID.Text));
                                /*context.Entry(sv).State = EntityState.Deleted;
                                context.Entry(kq).State = EntityState.Deleted;*/
                                if (kq != null)
                                {
                                    MessageBox.Show("Xóa không thành công vì Sinh Viên này đã có điểm!");

                                    //context.KetQuas.RemoveRange(kq);
                                }
                                else if (sv != null)
                                {
                                    context.SinhViens.Remove(sv);
                                }

                                if (context.SaveChanges() > 0)
                                {
                                    MessageBox.Show("Xóa thành công!");
                                    loadData();
                                    reset();
                                }
                            }
                            catch (Exception)
                            {
                                MessageBox.Show("Xóa không thành công vì Sinh Viên này đã có điểm!");

                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xóa không thành công do:" + ex);
                }
            }

        }
    }
}