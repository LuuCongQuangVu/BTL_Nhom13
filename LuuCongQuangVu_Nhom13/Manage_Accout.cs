﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuuCongQuangVu_Nhom13
{
    public partial class Manage_Accout : Form
    {
        public Manage_Accout()
        {
            InitializeComponent();
        }
        private void clear()
        {
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            txtHoTen.Clear();
            cbCapDo.SelectedIndex = -1;
        }
        #region Xử lí lỗi
        private void txtTaiKhoan_Validated(object sender, EventArgs e)
        {
            GetError.SetError(txtTaiKhoan, "");
        }

        private void txtMatKhau_Validated(object sender, EventArgs e)
        {
            GetError.SetError(txtMatKhau, "");
        }

        private void txtHoTen_Validated(object sender, EventArgs e)
        {
            GetError.SetError(txtHoTen, "");
        }

        private void cbCapDo_Validated(object sender, EventArgs e)
        {
            GetError.SetError(cbCapDo, "");
        }
        #endregion
        #region Admin, Logout, Exits
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn muốn đăng xuất", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                this.Hide();
                new Login().Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        #endregion
        #region Xử lí main buttons
        private void btnThem_Click(object sender, EventArgs e)
        {
            lbThongBao.Text = btnThem.Text;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnPhanLoai.Visible = false;
            btnTimKiem.Visible = false;
            lbTaiKhoan.Visible = true;
            lbMatKhau.Visible = true;
            lbHoTen.Visible = true;
            lbCapDo.Visible = true;
            txtTaiKhoan.Visible = true;
            txtMatKhau.Visible = true;
            txtHoTen.Visible = true;
            cbCapDo.Visible = true;
            btnOK.Text = "Cấp";
            btnOK.Visible = true;
            btnCancel.Visible = true;
            clear();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            lbThongBao.Text = btnSua.Text;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnPhanLoai.Visible = false;
            btnTimKiem.Visible = false;
            lbTaiKhoan.Visible = true;
            lbMatKhau.Visible = true;
            lbHoTen.Visible = true;
            lbCapDo.Visible = true;
            txtTaiKhoan.Visible = true;
            txtMatKhau.Visible = true;
            txtHoTen.Visible = true;
            cbCapDo.Visible = true;
            btnOK.Text = "Đổi";
            btnOK.Visible = true;
            btnCancel.Visible = true;
            clear();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            lbThongBao.Text = btnXoa.Text;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnPhanLoai.Visible = false;
            btnTimKiem.Visible = false;
            lbTaiKhoan.Visible = true;
            txtTaiKhoan.Visible = true;
            btnOK.Text = "Xoá";
            btnOK.Visible = true;
            btnCancel.Visible = true;
            clear();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            lbThongBao.Text = btnTimKiem.Text;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnPhanLoai.Visible = false;
            btnTimKiem.Visible = false;
            lbTaiKhoan.Visible = true;
            lbMatKhau.Visible = true;
            lbHoTen.Visible = true;
            lbCapDo.Visible = true;
            txtTaiKhoan.Visible = true;
            txtMatKhau.Visible = true;
            txtHoTen.Visible = true;
            cbCapDo.Visible = true;
            btnOK.Text = "Tìm";
            btnOK.Visible = true;
            btnCancel.Visible = true;
            btnXoa1.Visible = true;
            btnSua1.Visible = true;
            rdTaiKhoan.Visible = true;
            rdMatKhau.Visible = true;
            rdHoTen.Visible = true;
            clear();
        }
        private void btnPhanLoai_Click(object sender, EventArgs e)
        {
            lbThongBao.Text = btnPhanLoai.Text;
            btnThem.Visible = false;
            btnSua.Visible = false;
            btnXoa.Visible = false;
            btnPhanLoai.Visible = false;
            btnTimKiem.Visible = false;
            lbTaiKhoan.Visible = true;
            lbMatKhau.Visible = true;
            lbHoTen.Visible = true;
            lbCapDo.Visible = true;
            txtTaiKhoan.Visible = true;
            txtMatKhau.Visible = true;
            txtHoTen.Visible = true;
            cbCapDo.Visible = true;
            btnOK.Text = "Thực thi";
            btnOK.Visible = true;
            btnCancel.Visible = true;
            btnXoa1.Visible = true;
            btnSua1.Visible = true;
            clear();
        }
        #endregion
        #region Xử lí child buttons
        private void btnCancel_Click(object sender, EventArgs e)
        {
            lbThongBao.Text = "";
            btnThem.Visible = true;
            btnSua.Visible = true;
            btnXoa.Visible = true;
            btnPhanLoai.Visible = true;
            btnTimKiem.Visible = true;
            lbTaiKhoan.Visible = false;
            lbMatKhau.Visible = false;
            lbHoTen.Visible = false;
            lbCapDo.Visible = false;
            txtTaiKhoan.Visible = false;
            txtMatKhau.Visible = false;
            txtHoTen.Visible = false;
            cbCapDo.Visible = false;
            btnOK.Visible = false;
            btnCancel.Visible = false;
            rdTaiKhoan.Visible = false;
            rdMatKhau.Visible = false;
            rdHoTen.Visible = false;
            btnXoa1.Visible = false;
            btnSua1.Visible = false;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lbThongBao.Text == btnThem.Text)
            {
                using (var dbcontext = new Models.QLThuVienContext())
                {
                    try
                    {
                        Models.Account acc = new Models.Account();
                        acc.Usename = txtTaiKhoan.Text;
                        acc.Password = txtMatKhau.Text;
                        acc.Tenchutaikhoan = txtHoTen.Text;
                        acc.Capdo = cbCapDo.Text;
                        dbcontext.Accounts.Add(acc);
                        dbcontext.SaveChanges();
                        ReadFile();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Tên tài khoản đã tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (lbThongBao.Text == btnSua.Text)
            {
                using (var dbcontext = new Models.QLThuVienContext())
                {
                    try
                    {
                        //Models.Account acc = dbcontext.Accounts.Where(a => a.Usename == txtTaiKhoan.Text).FirstOrDefault();
                        Models.Account acc = (from a in dbcontext.Accounts where a.Usename == txtTaiKhoan.Text select a).FirstOrDefault();
                        if (acc != null)
                        {
                            acc.Usename = txtTaiKhoan.Text;
                            acc.Password = txtMatKhau.Text;
                            acc.Tenchutaikhoan = txtHoTen.Text;
                            acc.Capdo = cbCapDo.Text;
                            dbcontext.SaveChanges();
                            ReadFile();
                        }
                        else
                        {
                            MessageBox.Show("Tên tài khoản không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không cho phép đổi cả tên tài khoản!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (lbThongBao.Text==btnXoa.Text)
            {
                using var dbcontext = new Models.QLThuVienContext();
                //Models.Account acc = dbcontext.Accounts.Where(a => a.Usename == txtTaiKhoan.Text).FirstOrDefault();
                Models.Account acc = (from a in dbcontext.Accounts where a.Usename == txtTaiKhoan.Text select a).FirstOrDefault();
                DialogResult confirm = MessageBox.Show("Bạn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm==DialogResult.Yes)
                {
                    if (acc != null)
                    {
                        dbcontext.Accounts.Remove(acc);
                        dbcontext.SaveChanges();
                        ReadFile();
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }  
            }
            else if (lbThongBao.Text==btnPhanLoai.Text)
            {
                using var dbcontext = new Models.QLThuVienContext();
                //var list_accout = dbcontext.Accounts.Where(a=>a.Capdo==cbCapDo.Text).ToList();
                var list_accout = (from a in dbcontext.Accounts where a.Capdo==cbCapDo.Text select a).ToList();
                if (list_accout != null)
                {
                    if (list_accout.Count() > 0)
                    {
                        dgvAccout.Rows.Clear();
                        dgvAccout.ColumnCount = 8;
                        for (int i = 0; i < list_accout.Count(); i++)
                        {
                            dgvAccout.Rows.Add();
                            dgvAccout.Rows[i].Cells[0].Value = list_accout[i].Usename;
                            dgvAccout.Rows[i].Cells[1].Value = list_accout[i].Password;
                            dgvAccout.Rows[i].Cells[2].Value = list_accout[i].Tenchutaikhoan;
                            dgvAccout.Rows[i].Cells[3].Value = list_accout[i].Capdo;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (lbThongBao.Text==btnTimKiem.Text)
            {
                if (rdTaiKhoan.Checked == false && rdMatKhau.Checked == false && rdHoTen.Checked==false)
                {
                    MessageBox.Show("Bạn vui chọn mục tìm kiếm theo Tài khoản / Mật khẩu/ Họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rdTaiKhoan.Checked)
                {
                    if (txtTaiKhoan.Text == "")
                    {
                        MessageBox.Show("Chưa tên tài khoản muốn tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        using var dbcontext = new Models.QLThuVienContext();
                        //var list_accout = dbcontext.Accounts.Where(a => a.Usename == txtTaiKhoan.Text).ToList();
                        var list_accout = (from a in dbcontext.Accounts where a.Usename == txtTaiKhoan.Text select a ).ToList();
                        if (list_accout != null)
                        {
                            if (list_accout.Count() > 0)
                            {
                                dgvAccout.Rows.Clear();
                                dgvAccout.ColumnCount = 4;
                                for (int i = 0; i < list_accout.Count(); i++)
                                {
                                    dgvAccout.Rows.Add();
                                    dgvAccout.Rows[i].Cells[0].Value = list_accout[i].Usename;
                                    dgvAccout.Rows[i].Cells[1].Value = list_accout[i].Password;
                                    dgvAccout.Rows[i].Cells[2].Value = list_accout[i].Tenchutaikhoan;
                                    dgvAccout.Rows[i].Cells[3].Value = list_accout[i].Capdo;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else if (rdMatKhau.Checked)
                {
                    if (txtTaiKhoan.Text == "")
                    {
                        MessageBox.Show("Chưa tên mật khẩu muốn tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        using var dbcontext = new Models.QLThuVienContext();
                        //var list_accout = dbcontext.Accounts.Where(a => a.Password == txtMatKhau.Text).ToList();
                        var list_accout = (from a in dbcontext.Accounts where a.Password == txtMatKhau.Text select a).ToList();
                        if (list_accout != null)
                        {
                            if (list_accout.Count() > 0)
                            {
                                dgvAccout.Rows.Clear();
                                dgvAccout.ColumnCount = 4;
                                for (int i = 0; i < list_accout.Count(); i++)
                                {
                                    dgvAccout.Rows.Add();
                                    dgvAccout.Rows[i].Cells[0].Value = list_accout[i].Usename;
                                    dgvAccout.Rows[i].Cells[1].Value = list_accout[i].Password;
                                    dgvAccout.Rows[i].Cells[2].Value = list_accout[i].Tenchutaikhoan;
                                    dgvAccout.Rows[i].Cells[3].Value = list_accout[i].Capdo;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                else if (rdHoTen.Checked)
                {
                    if (txtTaiKhoan.Text == "")
                    {
                        MessageBox.Show("Chưa tên mật khẩu muốn tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        using var dbcontext = new Models.QLThuVienContext();
                        //var list_accout = dbcontext.Accounts.Where(a => a.Password == txtMatKhau.Text).ToList();
                        var list_accout = (from a in dbcontext.Accounts where a.Password == txtMatKhau.Text select a).ToList();
                        if (list_accout != null)
                        {
                            if (list_accout.Count() > 0)
                            {
                                dgvAccout.Rows.Clear();
                                dgvAccout.ColumnCount = 4;
                                for (int i = 0; i < list_accout.Count(); i++)
                                {
                                    dgvAccout.Rows.Add();
                                    dgvAccout.Rows[i].Cells[0].Value = list_accout[i].Usename;
                                    dgvAccout.Rows[i].Cells[1].Value = list_accout[i].Password;
                                    dgvAccout.Rows[i].Cells[2].Value = list_accout[i].Tenchutaikhoan;
                                    dgvAccout.Rows[i].Cells[3].Value = list_accout[i].Capdo;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }

        }
        private void btnXoa1_Click(object sender, EventArgs e)
        {
            if (lbThongBao.Text == btnPhanLoai.Text)
            {
                using var dbcontext = new Models.QLThuVienContext();
                //Models.Account acc = dbcontext.Accounts.Where(a => a.Usename == txtTaiKhoan.Text).FirstOrDefault();
                Models.Account acc = (from a in dbcontext.Accounts where a.Usename == txtTaiKhoan.Text select a).FirstOrDefault();
                DialogResult confirm = MessageBox.Show("Bạn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    if (acc != null)
                    {
                        dbcontext.Accounts.Remove(acc);
                        dbcontext.SaveChanges();
                        ReadfilePhanLoai();
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                using var dbcontext = new Models.QLThuVienContext();
                //Models.Account acc = dbcontext.Accounts.Where(a => a.Usename == txtTaiKhoan.Text).FirstOrDefault();
                Models.Account acc = (from a in dbcontext.Accounts where a.Usename == txtTaiKhoan.Text select a).FirstOrDefault();
                DialogResult confirm = MessageBox.Show("Bạn muốn xoá không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    if (acc != null)
                    {
                        dbcontext.Accounts.Remove(acc);
                        dbcontext.SaveChanges();
                        ReadFile();
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            
        }
        private void btnSua1_Click(object sender, EventArgs e)
        {
            if (lbThongBao.Text==btnPhanLoai.Text)
            {
                using (var dbcontext = new Models.QLThuVienContext())
                {
                    try
                    {
                        //Models.Account acc = dbcontext.Accounts.Where(a => a.Usename == txtTaiKhoan.Text).FirstOrDefault();
                        Models.Account acc = (from a in dbcontext.Accounts where a.Usename == txtTaiKhoan.Text select a).FirstOrDefault();
                        if (acc != null)
                        {
                            acc.Usename = txtTaiKhoan.Text;
                            acc.Password = txtMatKhau.Text;
                            acc.Tenchutaikhoan = txtHoTen.Text;
                            acc.Capdo = cbCapDo.Text;
                            dbcontext.SaveChanges();
                            ReadfilePhanLoai();
                        }
                        else
                        {
                            MessageBox.Show("Tên tài khoản không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi ngoại lệ!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                using (var dbcontext = new Models.QLThuVienContext())
                {
                    try
                    {
                        //Models.Account acc = dbcontext.Accounts.Where(a => a.Usename == txtTaiKhoan.Text).FirstOrDefault();
                        Models.Account acc = (from a in dbcontext.Accounts where a.Usename == txtTaiKhoan.Text select a).FirstOrDefault();
                        if (acc != null)
                        {
                            acc.Usename = txtTaiKhoan.Text;
                            acc.Password = txtMatKhau.Text;
                            acc.Tenchutaikhoan = txtHoTen.Text;
                            acc.Capdo = cbCapDo.Text;
                            dbcontext.SaveChanges();
                            ReadFile();
                        }
                        else
                        {
                            MessageBox.Show("Tên tài khoản không tồn tại!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không cho phép đổi tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            clear();
        }
        #endregion

        private void ReadFile()
        {
            using var dbcontext = new Models.QLThuVienContext();
            var list_accout = dbcontext.Accounts.ToList();
            if (list_accout != null)
            {
                if (list_accout.Count() > 0)
                {
                    dgvAccout.Rows.Clear();
                    dgvAccout.ColumnCount = 4;
                    for (int i = 0; i < list_accout.Count(); i++)
                    {
                        dgvAccout.Rows.Add();
                        dgvAccout.Rows[i].Cells[0].Value = list_accout[i].Usename;
                        dgvAccout.Rows[i].Cells[1].Value = list_accout[i].Password;
                        dgvAccout.Rows[i].Cells[2].Value = list_accout[i].Tenchutaikhoan;
                        dgvAccout.Rows[i].Cells[3].Value = list_accout[i].Capdo;
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void ReadfilePhanLoai()
        {
            using var dbcontext = new Models.QLThuVienContext();
            //var list_accout = dbcontext.Accounts.Where(a => a.Capdo == cbCapDo.Text).ToList();
            var list_accout = (from a in dbcontext.Accounts where a.Capdo == cbCapDo.Text select a).ToList();
            if (list_accout != null)
            {
                if (list_accout.Count() > 0)
                {
                    dgvAccout.Rows.Clear();
                    dgvAccout.ColumnCount = 4;
                    for (int i = 0; i < list_accout.Count(); i++)
                    {
                        dgvAccout.Rows.Add();
                        dgvAccout.Rows[i].Cells[0].Value = list_accout[i].Usename;
                        dgvAccout.Rows[i].Cells[1].Value = list_accout[i].Password;
                        dgvAccout.Rows[i].Cells[2].Value = list_accout[i].Tenchutaikhoan;
                        dgvAccout.Rows[i].Cells[3].Value = list_accout[i].Capdo;
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void Manage_Accout_Load(object sender, EventArgs e)
        {
            ReadFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadFile();
        }

        private void cell_click_account(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvAccout.SelectedCells[0].RowIndex;
            DataGridViewRow row = dgvAccout.Rows[index];
            txtTaiKhoan.Text = Convert.ToString(row.Cells[0].Value);
            txtMatKhau.Text = Convert.ToString(row.Cells[1].Value);
            txtHoTen.Text = Convert.ToString(row.Cells[2].Value);
            cbCapDo.Text = Convert.ToString(row.Cells[3].Value);
        }

    }
}
