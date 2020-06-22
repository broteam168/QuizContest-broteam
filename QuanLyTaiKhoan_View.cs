using DoAnThiTracNghiem_Son.Controler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnThiTracNghiem_Son
{
    public partial class QuanLyTaiKhoan_View : DevExpress.XtraEditors.XtraForm
    {
        private string _Action;
        private int id_;
        private QuanLyTaiKhoan_Controler cls;
        public QuanLyTaiKhoan_View()
        {
            InitializeComponent();
            cls = new QuanLyTaiKhoan_Controler();
            changeControlState(true);
            init();
        }
        public void init()
        {
            gridTaiKhoan.DataSource = cls.listTaiKhoan();
        }
        private void changeControlState(Boolean _State)
        {
            cmdThem.Enabled = _State;
            cmdSua.Enabled = _State;
            cmdXoa.Enabled = _State;
            gridTaiKhoan.Enabled = _State;
            cmdGhi.Enabled = !_State;
            cmdHuy.Enabled = !_State;

            cbNhom.Enabled = !_State;
            txtHoten.Enabled = !_State;
            txtTaiKhoan.Enabled = !_State;
            txtThongTin.Enabled = !_State;
            btMK.Enabled = false;
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            _Action = "Add";
            txtHoten.Text = "";
            txtTaiKhoan.Text = "";
            txtThongTin.Text = "";
            lbHanhDong.Text = "Thao tác : Thêm mới";
            changeControlState(false);
            cbNhom.SelectedIndex = 1;
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            _Action = "Edit";
            lbHanhDong.Text = "Thao tác : sửa";
            changeControlState(false);
            btMK.Enabled = true;
            txtTaiKhoan.Enabled = false;
        }

        private void TaiKhoan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btMK.Enabled = false;
            try
            {
                id_ = int.Parse(TaiKhoan.GetFocusedRowCellValue("id").ToString());
                txtHoten.Text = TaiKhoan.GetFocusedRowCellValue("HoTen").ToString();
                txtTaiKhoan.Text = TaiKhoan.GetFocusedRowCellValue("userName").ToString();
                if (int.Parse(TaiKhoan.GetFocusedRowCellValue("phanQuyen").ToString()) == 1)
                {
                    cbNhom.SelectedIndex = 0;
                }
                else
                {
                    cbNhom.SelectedIndex = 1;
                }
                txtThongTin.Text = TaiKhoan.GetFocusedRowCellValue("thongTin").ToString();
            }
            catch (Exception)
            {
            }
        }

        private void cmdHuy_Click(object sender, EventArgs e)
        {
            _Action = "";
            changeControlState(true);
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text.Trim() != "" && txtTaiKhoan.Text.Trim() != "" && txtThongTin.Text.Trim() != "")
            {
                taiKhoan tk = new taiKhoan();
                tk.HoTen = txtHoten.Text.Trim();
                tk.userName = txtTaiKhoan.Text.Trim();
                tk.thongTin = txtThongTin.Text.Trim();
                if (cbNhom.SelectedIndex == 0)
                {
                    tk.phanQuyen = 1;
                }
                else
                {
                    tk.phanQuyen = 2;
                }
                if (_Action == "Add")
                {
                    if (cls.checkExist(txtTaiKhoan.Text.Trim()))
                    {
                        tk.pass = EncodeMD5(txtTaiKhoan.Text.Trim());
                        cls.instert(tk);
                        MessageBox.Show("Tạo tài khoản thành công!");
                        changeControlState(true);
                        gridTaiKhoan.DataSource = null;
                        gridTaiKhoan.DataSource = cls.listTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản đã tồn tại!");
                    }
                }
                if (_Action == "Edit")
                {
                    tk.id = id_;
                    cls.update(tk);
                    MessageBox.Show("Cập nhật tài khoản thành công!");
                    changeControlState(true);
                    gridTaiKhoan.DataSource = null;
                    gridTaiKhoan.DataSource = cls.listTaiKhoan();
                }
            }
            else
            {
                MessageBox.Show("Các trường không được để trống!");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridTaiKhoan.DataSource = null;
            gridTaiKhoan.DataSource = cls.listTaiKhoan();
        }

        private void btMK_Click(object sender, EventArgs e)
        {
            cls.resetPass(txtTaiKhoan.Text);
            MessageBox.Show("Reset mật khẩu thành công");
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Bạn có chắc chắn muốn xóa", "cảnh báo", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {
                if (cls.checkExist1(txtTaiKhoan.Text))
                {
                    cls.delete(id_);
                    gridTaiKhoan.DataSource = null;
                    gridTaiKhoan.DataSource = cls.listTaiKhoan();
                    MessageBox.Show("Xóa tài khoản thành công.");
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tham gia bài thì.Không thể xóa");
                }
            }
        }
        private string EncodeMD5(string pass)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);

            bs = md5.ComputeHash(bs);

            System.Text.StringBuilder s = new System.Text.StringBuilder();

            foreach (byte b in bs)
            {

                s.Append(b.ToString("x1").ToLower());

            }

            pass = s.ToString();

            return pass;

        }
    }
}
